using MetroFramework.Controls;

namespace ExcelToQif
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.txtPayee = new MetroFramework.Controls.MetroTextBox();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.radioDate = new MetroFramework.Controls.MetroRadioButton();
            this.radioPayee = new MetroFramework.Controls.MetroRadioButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkInvertCD = new MetroFramework.Controls.MetroCheckBox();
            this.radioValue = new MetroFramework.Controls.MetroRadioButton();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.lblDrop = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tableLayoutPanel1.Controls.Add(this.txtDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPayee, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioPayee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.radioValue, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.39506F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.60493F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 75);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.Enabled = false;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(3, 24);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.PromptText = "Date Column";
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(166, 20);
            this.txtDate.TabIndex = 0;
            this.txtDate.UseCustomBackColor = true;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMark = "Date Column";
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDate.Click += new System.EventHandler(this.txtDate_Click);
            // 
            // txtPayee
            // 
            // 
            // 
            // 
            this.txtPayee.CustomButton.Image = null;
            this.txtPayee.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtPayee.CustomButton.Name = "";
            this.txtPayee.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtPayee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPayee.CustomButton.TabIndex = 1;
            this.txtPayee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPayee.CustomButton.UseSelectable = true;
            this.txtPayee.CustomButton.Visible = false;
            this.txtPayee.Enabled = false;
            this.txtPayee.Lines = new string[0];
            this.txtPayee.Location = new System.Drawing.Point(175, 24);
            this.txtPayee.MaxLength = 32767;
            this.txtPayee.Name = "txtPayee";
            this.txtPayee.PasswordChar = '\0';
            this.txtPayee.PromptText = "Payee Column";
            this.txtPayee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPayee.SelectedText = "";
            this.txtPayee.SelectionLength = 0;
            this.txtPayee.SelectionStart = 0;
            this.txtPayee.ShortcutsEnabled = true;
            this.txtPayee.Size = new System.Drawing.Size(166, 20);
            this.txtPayee.TabIndex = 5;
            this.txtPayee.UseCustomBackColor = true;
            this.txtPayee.UseSelectable = true;
            this.txtPayee.WaterMark = "Payee Column";
            this.txtPayee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPayee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPayee.Click += new System.EventHandler(this.txtPayee_Click);
            // 
            // txtValue
            // 
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.Enabled = false;
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(0, 0);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.PromptText = "Value Column";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(166, 20);
            this.txtValue.TabIndex = 1;
            this.txtValue.UseCustomBackColor = true;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMark = "Value Column";
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValue.Click += new System.EventHandler(this.txtValue_Click);
            // 
            // radioDate
            // 
            this.radioDate.AutoSize = true;
            this.radioDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioDate.Enabled = false;
            this.radioDate.Location = new System.Drawing.Point(3, 3);
            this.radioDate.Name = "radioDate";
            this.radioDate.Size = new System.Drawing.Size(93, 15);
            this.radioDate.TabIndex = 6;
            this.radioDate.TabStop = true;
            this.radioDate.Text = "Date Column";
            this.radioDate.UseSelectable = true;
            // 
            // radioPayee
            // 
            this.radioPayee.AutoSize = true;
            this.radioPayee.Enabled = false;
            this.radioPayee.Location = new System.Drawing.Point(175, 3);
            this.radioPayee.Name = "radioPayee";
            this.radioPayee.Size = new System.Drawing.Size(100, 15);
            this.radioPayee.TabIndex = 7;
            this.radioPayee.TabStop = true;
            this.radioPayee.Text = "Payee Column";
            this.radioPayee.UseSelectable = true;
            this.radioPayee.CheckedChanged += new System.EventHandler(this.radioPayee_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(553, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate QIF file";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkInvertCD);
            this.panel1.Controls.Add(this.txtValue);
            this.panel1.Location = new System.Drawing.Point(347, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 10;
            // 
            // chkInvertCD
            // 
            this.chkInvertCD.AutoSize = true;
            this.chkInvertCD.Enabled = false;
            this.chkInvertCD.Location = new System.Drawing.Point(0, 26);
            this.chkInvertCD.Name = "chkInvertCD";
            this.chkInvertCD.Size = new System.Drawing.Size(126, 15);
            this.chkInvertCD.TabIndex = 9;
            this.chkInvertCD.Text = "Invert Credit/Debit?";
            this.chkInvertCD.UseSelectable = true;
            // 
            // radioValue
            // 
            this.radioValue.AutoSize = true;
            this.radioValue.Enabled = false;
            this.radioValue.Location = new System.Drawing.Point(347, 3);
            this.radioValue.Name = "radioValue";
            this.radioValue.Size = new System.Drawing.Size(97, 15);
            this.radioValue.TabIndex = 8;
            this.radioValue.TabStop = true;
            this.radioValue.Text = "Value Column";
            this.radioValue.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(20, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 345);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.DragLeave += new System.EventHandler(this.dataGridView1_DragLeave);
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDrop.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDrop.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDrop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDrop.Location = new System.Drawing.Point(305, 289);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(228, 25);
            this.lblDrop.TabIndex = 7;
            this.lblDrop.Text = "Drop your excel file here!";
            this.lblDrop.UseCustomBackColor = true;
            this.lblDrop.UseCustomForeColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 500);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Excel2QIF";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroTextBox txtValue;
        private MetroTextBox txtDate;
        private MetroTextBox txtPayee;
        private MetroButton button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroRadioButton radioDate;
        private MetroRadioButton radioPayee;
        private MetroRadioButton radioValue;
        private MetroGrid dataGridView1;
        private MetroLabel lblDrop;
        private System.Windows.Forms.Panel panel1;
        private MetroCheckBox chkInvertCD;
    }
}

