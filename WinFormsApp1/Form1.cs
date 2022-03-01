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
             


           
           int bitisTarihi       = Convert.ToInt32((new DateTime(this.bitisTarihi.Value.Year, this.bitisTarihi.Value.Month, this.bitisTarihi.Value.Day, this.bitisTarihi.Value.Hour, this.bitisTarihi.Value.Minute, this.bitisTarihi.Value.Second)).ToOADate());
           int baslangicTarihi   = Convert.ToInt32((new DateTime(this.baslangicTarihi.Value.Year, this.baslangicTarihi.Value.Month, this.baslangicTarihi.Value.Day, this.baslangicTarihi.Value.Hour, this.baslangicTarihi.Value.Minute, this.baslangicTarihi.Value.Second)).ToOADate());


            STIManager sTIManager = new STIManager();
            var result = sTIManager.GetAll(malKodlari.Text, baslangicTarihi, bitisTarihi);
            
            for (int i = 0; i < result.Count; i++)
            {




                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = result[i].SiraNo;
                dataGridView1.Rows[i].Cells[1].Value = result[i].IslemTur;
                dataGridView1.Rows[i].Cells[2].Value = result[i].EvrakNo;
                dataGridView1.Rows[i].Cells[3].Value = result[i].Tarih;
                dataGridView1.Rows[i].Cells[4].Value = result[i].GirisMiktari;
                dataGridView1.Rows[i].Cells[5].Value = result[i].CikisMiktari;
                dataGridView1.Rows[i].Cells[6].Value = result[i].StokMiktari;


               
            }
       
            
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
    }
}