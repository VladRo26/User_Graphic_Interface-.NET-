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
    public partial class Angajat : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Angajat()
        {
            InitializeComponent();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Angajat", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Angajat(IDAngajat,Post,Nume,Prenume,IDDepartament,Salariu,DataAngajare,DataPlecare,Bonus) " + "VALUES(:IDAngajat1,:Post1,:Nume1,:Prenume1,:IDDepartament1,:Salariu1,:DataAngajare1,:DataPlecare1,:Bonus1)";
            this.AUD(query, 0);
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;

        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update Angajat set IDAngajat =:IDAngajat1, Post =:Post1, Nume =:Nume1, Prenume=:Prenume1, IDDepartament=:IDDepartament1, Salariu=:Salariu1, DataAngajare=:DataAngajare1, DataPlecare=:DataPlecare1, Bonus=:Bonus1 where IDAngajat =:IDAngajat1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Delete from Angajat where IDAngajat =:IDAngajat1";
            this.AUD(query, 2);
        }

        private void RESET_Ingredient_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox1.ReadOnly = false;
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
                    command.Parameters.Add("Post1", textBox2.Text);
                    command.Parameters.Add("Nume1", textBox3.Text);
                    command.Parameters.Add("Prenume1", textBox4.Text);
                    command.Parameters.Add("IDDepartament1", textBox5.Text);
                    command.Parameters.Add("Salariu1", textBox6.Text);
                    command.Parameters.Add("DataAngajare1", Convert.ToDateTime(textBox7.Text));
                    if (textBox8.Text == "")
                        command.Parameters.Add("DataPlecare1", "");
                    else
                        command.Parameters.Add("DataPlecare1", Convert.ToDateTime(textBox8.Text));
                    command.Parameters.Add("Bonus1", textBox9.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDAngajat1", textBox1.Text);
                    command.Parameters.Add("Post1", textBox2.Text);
                    command.Parameters.Add("Nume1", textBox3.Text);
                    command.Parameters.Add("Prenume1", textBox4.Text);
                    command.Parameters.Add("IDDepartament1", textBox5.Text);
                    command.Parameters.Add("Salariu1", textBox6.Text);
                    command.Parameters.Add("DataAngajare1", Convert.ToDateTime(textBox7.Text));
                    if (textBox8.Text == "")
                        command.Parameters.Add("DataPlecare1", "");
                    else
                        command.Parameters.Add("DataPlecare1", Convert.ToDateTime(textBox8.Text));
                    command.Parameters.Add("Bonus1", textBox9.Text);
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDAngajat1", textBox1.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Angajat", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox8.Text = dateTimePicker2.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox7.Text = dateTimePicker1.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.ReadOnly = true;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker2.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text=  dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }
    }
}
