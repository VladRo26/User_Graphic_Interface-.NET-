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
    public partial class CategorieProdus : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public CategorieProdus()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from CategorieProdus", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CategorieProdus(IDCategorieProdus,Nume) " + "VALUES(:IDCategorieProdus1,:Nume1)";
            this.AUD(query, 0);
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update CategorieProdus set IDCategorieProdus =:IDCategorieProdus1, Nume =:Nume1 where IDCategorieProdus =:IDCategorieProdus1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from CategorieProdus where IDCategorieProdus =:IDCategorieProdus1";
            this.AUD(query, 2);
        }

        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            text_IDCategorie.Text = "";
            text_Nume.Text = "";
            text_IDCategorie.ReadOnly = false;
            button1.Enabled = true;
            Update_Ingredient.Enabled = false;
            delete_Ingredient.Enabled = false;
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
                    command.Parameters.Add("IDCategorieProdus1", text_IDCategorie.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDCategorieProdus1", text_IDCategorie.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDCategorieProdus1", text_IDCategorie.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from CategorieProdus", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_IDCategorie.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_IDCategorie.ReadOnly = true;
            text_Nume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }
    }
}
