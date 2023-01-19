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
    public partial class UnitateMasura : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public UnitateMasura()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from UnitateMasura", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO UnitateMasura(IDUnitateMasura,Nume) " + "VALUES(:IDUnitateMasura1,:Nume1)";
            this.AUD(query, 0);
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update UnitateMasura set IDUnitateMasura =:IDUnitateMasura1, Nume =:Nume1 where IDUnitateMasura =:IDUnitateMasura1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from UnitateMasura where IDUnitateMasura =:IDUnitateMasura1";
            this.AUD(query, 2);
        }

        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            textIDNume.Text = "";
            text_IDunitate.Text = "";
            text_IDunitate.ReadOnly = false;
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
                    command.Parameters.Add("IDUnitateMasura1", text_IDunitate.Text);
                    command.Parameters.Add("Nume1", textIDNume.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDUnitateMasura1", text_IDunitate.Text);
                    command.Parameters.Add("Nume1", textIDNume.Text);
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDUnitateMasura1", text_IDunitate.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from UnitateMasura", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            text_IDunitate.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_IDunitate.ReadOnly = true;
            textIDNume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            button1.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }
    }
}
