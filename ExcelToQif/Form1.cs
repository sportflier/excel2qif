﻿using DragDropLib;
using ExcelDataReader;
using NLog;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ComIDataObject = System.Runtime.InteropServices.ComTypes.IDataObject;

namespace ExcelToQif
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private Color dateColor = Color.Blue;
        private Color valueColor = Color.Red;
        private Color payeeColor = Color.Green;

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private DataSet ds = null;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ReadyToWrite())
            {
                MessageBox.Show("not ready");
                return;
            }

            Stream stream;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "qif files (*.qif)|*.qif";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile()) != null)
                {
                    GenerateQif(stream, ds.Tables[0]);
                    stream.Close();
                }
            }
        }

        private void GenerateQif(Stream stream, DataTable dt)
        {
            int lines = 0;
            using (StreamWriter sw = new StreamWriter(stream))
            {
                sw.WriteLine("!Type:Bank");
                foreach(DataRow r in dt.Rows)
                {
                    if (GetDate(r) != DateTime.MinValue && GetValue(r) != null && GetPayee(r) != null)
                    {
                        sw.WriteLine("D{0}", GetDate(r).ToString("dd/MM/yy"));
                        sw.WriteLine("T{0}", GetValue(r));
                        sw.WriteLine("P{0}", GetPayee(r));
                        sw.WriteLine("^");
                        lines++;
                    }
                }
            }
            if (lines > 0)
                MetroFramework.MetroMessageBox.Show(this, lines + " lines generated.");
        }

        private string GetPayee(DataRow r)
        {
            try
            {
                return r[txtPayee.Text].ToString();
            }
            catch(Exception e)
            {
                logger.Warn(e, "getting payee");
                return null;
            }
        }

        private DateTime GetDate(DataRow r)
        {
            try
            {
                return Convert.ToDateTime(r[txtDate.Text]);
            }
            catch(Exception e)
            {
                logger.Warn(e, "getting date");
                return DateTime.MinValue;
            }
        }

        private string GetValue(DataRow r)
        {
            try
            {
                decimal value = Convert.ToDecimal(r[txtValue.Text]);
                if (chkInvertCD.Checked)
                    value *= -1;
                return value.ToString(CultureInfo.InvariantCulture);
            }
            catch(Exception e)
            {
                logger.Warn(e, "getting value");
                return null;
            }
        }

        private bool ReadyToWrite()
        {
            return true;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Point p = Cursor.Position;
            Win32Point wp;
            wp.x = p.X;
            wp.y = p.Y;
            IDropTargetHelper dropHelper = (IDropTargetHelper)new DragDropHelper();
            dropHelper.Drop((ComIDataObject)e.Data, ref wp, (int)e.Effect);

            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Any())
            {
                using (var stream = File.Open(files.First(), FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        ds = reader.AsDataSet();
                        dataGridView1.DataSource = ds.Tables[0];
                        DisableSorting();
                        lblDrop.Visible = false;
                        SetComponentsEnabled(true);
                        SelectDate();
                    }
                }
            }
        }

        private void DisableSorting()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void SelectDate()
        {
            radioDate.Checked = true;            
            txtDate.BackColor = dateColor;
            txtDate.WaterMark = "Please click date column.";
        }

        private void SetComponentsEnabled(bool enabled)
        {
            radioDate.Enabled = radioPayee.Enabled = radioValue.Enabled = enabled;
            txtDate.Enabled = txtPayee.Enabled = txtValue.Enabled = enabled;
            chkInvertCD.Enabled = enabled;
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Point p = Cursor.Position;
            Win32Point wp;
            wp.x = p.X;
            wp.y = p.Y;
            IDropTargetHelper dropHelper = (IDropTargetHelper)new DragDropHelper();
            dropHelper.DragEnter(IntPtr.Zero, (ComIDataObject)e.Data, ref wp, (int)e.Effect);
        }

        private void dataGridView1_DragLeave(object sender, EventArgs e)
        {
            IDropTargetHelper dropHelper = (IDropTargetHelper)new DragDropHelper();
            dropHelper.DragLeave();
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Point p = Cursor.Position;
            Win32Point wp;
            wp.x = p.X;
            wp.y = p.Y;
            IDropTargetHelper dropHelper = (IDropTargetHelper)new DragDropHelper();
            dropHelper.DragOver(ref wp, (int)e.Effect);
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ChoosingDateColumn())
            {
                txtDate.Text = ds.Tables[0].Columns[e.ColumnIndex].ColumnName;
                txtDate.BackColor = 
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = dateColor;
                radioPayee.Checked = true;
                return;
            }

            if (ChoosingPayeeColumn())
            {
                txtPayee.Text = ds.Tables[0].Columns[e.ColumnIndex].ColumnName;
                txtPayee.BackColor =
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = payeeColor;
                radioValue.Checked = true;
                return;
            }

            if (ChoosingValueColumn())
            {
                txtValue.Text = ds.Tables[0].Columns[e.ColumnIndex].ColumnName;
                txtValue.BackColor = 
                dataGridView1.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = valueColor;
                button1.Enabled = true;
            }
        }

        private bool ChoosingValueColumn()
        {
            return radioValue.Checked;
        }

        private bool ChoosingPayeeColumn()
        {
            return radioPayee.Checked;
        }

        private bool ChoosingDateColumn()
        {
            return radioDate.Checked;
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            if (ds == null)
                MetroFramework.MetroMessageBox.Show(this, "Please drop excel file first");
            else
            {
                txtDate.BackColor = Color.Yellow;
                MetroFramework.MetroMessageBox.Show(this, "Please double-click the choosen date column.");
            }
        }

        private void txtValue_Click(object sender, EventArgs e)
        {
            if (ds == null)
                MetroFramework.MetroMessageBox.Show(this, "Please drop excel file first");
        }

        private void txtPayee_Click(object sender, EventArgs e)
        {
            if (ds == null)
                MetroFramework.MetroMessageBox.Show(this, "Please drop excel file first");
        }

        private void radioPayee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPayee.Checked)
                txtPayee.WaterMark = "Double click on Payee Column";
        }

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1_ColumnHeaderMouseClick(sender, e);
        }
    }
}
