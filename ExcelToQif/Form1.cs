using DragDropLib;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComIDataObject = System.Runtime.InteropServices.ComTypes.IDataObject;

namespace ExcelToQif
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
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
            using (StreamWriter sw = new StreamWriter(stream))
            {
                sw.WriteLine("!Type:Bank");
                foreach(DataRow r in dt.Rows)
                {
                    sw.WriteLine("D{0}", GetDate(r).ToString("dd/MM/yy"));
                    sw.WriteLine("T{0}", GetValue(r));
                    sw.WriteLine("P{0}", GetPayee(r));
                    sw.WriteLine("^");
                }
            }                
        }

        private string GetPayee(DataRow r)
        {
            return r[txtPayee.Text].ToString();
        }

        private DateTime GetDate(DataRow r)
        {
            return Convert.ToDateTime(r[txtDate.Text]);
        }

        private string GetValue(DataRow r)
        {
            return Convert.ToDecimal(r[txtValue.Text]).ToString(CultureInfo.InvariantCulture);
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

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
            {
                using (var stream = File.Open(files.First(), FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        ds = reader.AsDataSet();
                        dataGridView1.DataSource = ds.Tables[0];
                        lblDrop.Visible = false;
                    }
                }
            }
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
    }
}
