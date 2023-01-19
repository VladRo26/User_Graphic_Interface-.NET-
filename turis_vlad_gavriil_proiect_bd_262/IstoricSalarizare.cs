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
    public partial class IstoricSalarizare : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public IstoricSalarizare()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from IstoricSalarizare", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;

        }

        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO IstoricSalarizare(IDAngajat,DataSchimbareSalariu,SalariuVechi) " + "VALUES(:IDAngajat,:DataSchimbareSalariu1,:SalariuVechi1)";
            this.AUD(query, 0);
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;

        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update IstoricSalarizare set IDAngajat =:IDAngajat1, DataSchimbareSalariu =:DataSchimbareSalariu1, SalariuVechi =:SalariuVechi1 where IDAngajat =:IDAngajat1 and DataSchimbareSalariu =:DataSchimbareSalariu1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from IstoricSalarizare where IDAngajat =:IDAngajat1 and DataSchimbareSalariu =:DataSchimbareSalariu1";
            this.AUD(query, 2);
        }

        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
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
                    command.Parameters.Add("IDAngajat1", textBox1.Text);
                    command.Parameters.Add("DataSchimbareSalariu1", Convert.ToDateTime(textBox2.Text));
                    command.Parameters.Add("SalariuVechi1", textBox3.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDAngajat1", textBox1.Text);
                    command.Parameters.Add("DataSchimbareSalariu1", Convert.ToDateTime(textBox2.Text));
                    command.Parameters.Add("SalariuVechi1", textBox3.Text);
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDAngajat1", textBox1.Text);
                    command.Parameters.Add("DataSchimbareSalariu1", Convert.ToDateTime(textBox2.Text));
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from IstoricSalarizare", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToString();
        }
    }
}
