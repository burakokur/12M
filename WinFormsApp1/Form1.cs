using Business.Concrete;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    

   
        private void button1_Click(object sender, EventArgs e)
        {
             


            STIManager sTIManager = new STIManager();
           
           int bitisTarihi       = Convert.ToInt32((new DateTime(this.bitisTarihi.Value.Year, this.bitisTarihi.Value.Month, this.bitisTarihi.Value.Day, this.bitisTarihi.Value.Hour, this.bitisTarihi.Value.Minute, this.bitisTarihi.Value.Second)).ToOADate());
           int baslangicTarihi   = Convert.ToInt32((new DateTime(this.baslangicTarihi.Value.Year, this.baslangicTarihi.Value.Month, this.baslangicTarihi.Value.Day, this.baslangicTarihi.Value.Hour, this.baslangicTarihi.Value.Minute, this.baslangicTarihi.Value.Second)).ToOADate());


            dataGrid.DataSource = sTIManager.GetAll(malKodlari.Text, baslangicTarihi, bitisTarihi);
            
           
       
            
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void baslangicTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}