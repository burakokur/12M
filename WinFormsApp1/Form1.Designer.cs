namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.malKodlari = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // malKodlari
            // 
            this.malKodlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.malKodlari.FormattingEnabled = true;
            this.malKodlari.Items.AddRange(new object[] {
            "10081 SİEMENS",
            "10082 SİEMENS",
            "10083 SİEMENS",
            "10086 SİEMENS",
            "10087 SİEMENS",
            "10091 SİEMENS"});
            this.malKodlari.Location = new System.Drawing.Point(520, 44);
            this.malKodlari.Name = "malKodlari";
            this.malKodlari.Size = new System.Drawing.Size(240, 23);
            this.malKodlari.TabIndex = 8;
            this.malKodlari.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(195, 6);
            this.baslangicTarihi.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.baslangicTarihi.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(198, 23);
            this.baslangicTarihi.TabIndex = 6;
            this.baslangicTarihi.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.baslangicTarihi.ValueChanged += new System.EventHandler(this.baslangicTarihi_ValueChanged);
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(195, 44);
            this.bitisTarihi.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.bitisTarihi.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(198, 23);
            this.bitisTarihi.TabIndex = 7;
            this.bitisTarihi.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "                 Mal Kodunu Seciniz";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Baslangıç Tarihi";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(146, 23);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Bitiş Tarihi";
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(0, 134);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(799, 317);
            this.dataGrid.TabIndex = 12;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.malKodlari);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private DateTimePicker baslangicTarihi;
        private DateTimePicker bitisTarihi;
        private ComboBox malKodlari;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGrid;
    }
}