using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace turis_vlad_gavriil_proiect_bd_262
{
    public partial class Produs : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Produs()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Produs", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO Produs(IDProdus,Nume,CostProductie,PretVanzare,IDCategorieProdus,InceputDataComercializare,SfarsitDataComercializare) " + "VALUES(:IDProdus1,:Nume1,:CostProductie1,:PretVanzare1,:IDCategorieProdus1,:InceputDataComercializare1,:SfarsitDataComercializare1)";
            this.AUD(query, 0);
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update Produs set IDProdus =:IDProdus1, Nume =:Nume1, CostProductie =:CostProductie1, PretVanzare =:PretVanzare1, IDCategorieProdus =:IDCategorieProdus1, InceputDataComercializare =:InceputDataComercializare1, SfarsitDataComercializare=:SfarsitDataComercializare1  where IDProdus =:IDProdus1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from Produs where IDProdus =:IDProdus1";
            this.AUD(query, 2);
        }

        
        private void AUD(String sql_stm, int stare)
        {
            c1.Open();
            String mesaj = " ";
            OracleCommand command = c1.CreateCommand();
            command.CommandText = sql_stm;
            command.CommandType = CommandType.Text;

            switch (stare)
            {
                case 0:
                    mesaj = "Rand inserat cu succes!";
                    command.Parameters.Add("IDProdus1", text_IDProd.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    command.Parameters.Add("CostProductie1", textCostProd.Text);
                    command.Parameters.Add("PretVanzare1", textCostProd.Text);
                    command.Parameters.Add("IDCategorieProdus1", textBox1.Text);
                    command.Parameters.Add("InceputDataComercializare1", Convert.ToDateTime(textDataComerci.Text));
                    if(textDataFinal.Text=="")
                    command.Parameters.Add("SfarsitDataComercializare1","");
                    else
                    command.Parameters.Add("SfarsitDataComercializare1", Convert.ToDateTime(textDataFinal.Text));
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDProdus1", text_IDProd.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    command.Parameters.Add("CostProductie1", textCostProd.Text);
                    command.Parameters.Add("PretVanzare1", textCostProd.Text);
                    command.Parameters.Add("IDCategorieProdus1", textBox1.Text);
                    command.Parameters.Add("InceputDataComercializare1", Convert.ToDateTime(textDataComerci.Text));
                    if (textDataFinal.Text == "")
                        command.Parameters.Add("SfarsitDataComercializare1", "");
                    else
                        command.Parameters.Add("SfarsitDataComercializare1", Convert.ToDateTime(textDataFinal.Text));
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDProdus1", text_IDProd.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Produs", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }
        

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_IDProd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_IDProd.ReadOnly = true;
            text_Nume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textCostProd.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPretVanzare.Text=dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker2.Text=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textDataComerci.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textDataFinal.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textDataComerci.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            textDataFinal.Text = dateTimePicker2.Value.ToString();
        }
        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            text_IDProd.Text = "";
            text_Nume.Text = "";
            text_Nume.Text = "";
            textCostProd.Text = "";
            textPretVanzare.Text = "";
            textBox1.Text = "";
            textDataComerci.Text = "";
            textDataFinal.Text = "";
            text_IDProd.ReadOnly = false;
            button1.Enabled = true;
            Update_Ingredient.Enabled = false;
            delete_Ingredient.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDataFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
