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
    public partial class Ingredient : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Ingredient()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Ingredient", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Ingredient(IDIngredient,Nume,FurnizorID) " + "VALUES(:IDIngredient1,:Nume1,:FurnizorID1)";
            this.AUD(query, 0);
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update Ingredient set IDIngredient =:IDIngredient1, Nume =:Nume1, FurnizorID =:FurnizorID1 where IDIngredient =:IDIngredient1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from Ingredient where IDIngredient =:IDIngredient1";
            this.AUD(query, 2);
        }

        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            text_IDIngredient.Text = "";
            text_Nume.Text = "";
            text_FurnizorID.Text = "";
            text_IDIngredient.ReadOnly = false;
            INSERT_CLIENT.Enabled = true;
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
                    command.Parameters.Add("IDIngredient1", text_IDIngredient.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    command.Parameters.Add("FurnizorID1", text_FurnizorID.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDIngredient1", text_IDIngredient.Text);
                    command.Parameters.Add("Nume1", text_Nume.Text);
                    command.Parameters.Add("FurnizorID1", text_FurnizorID.Text);
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDIngredient1", text_IDIngredient.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Ingredient", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_IDIngredient.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_IDIngredient.ReadOnly = true;
            text_Nume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_FurnizorID.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }
    }
}
