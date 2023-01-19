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
   
    public partial class Furnizor : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Furnizor()
        {
            InitializeComponent();
            Update_Client.Visible = true;
            delete_Client.Visible = true;
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Furnizor", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Furnizor(IDFurnizor,NumeFurnizor,AdresaFurnizor,DataIncepereColaborare) " + "VALUES(:IDFurnizor1, :NumeFurnizor1, :AdresaFurnizor1, :DataIncepereColaboare1)";
            this.AUD(query, 0);
            INSERT_CLIENT.Enabled = false;
            Update_Client.Enabled = true;
            delete_Client.Enabled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDFurnizor_Click(object sender, EventArgs e)
        {

        }

        private void NumeFurnizor_Click(object sender, EventArgs e)
        {

        }

        private void AdresaFurnizor_Click(object sender, EventArgs e)
        {

        }

        private void Update_Client_Click(object sender, EventArgs e)
        {
            string query = "Update Furnizor set IDFurnizor =:IDFurnizor1, NumeFurnizor =:NumeFurnizor1, AdresaFurnizor =:AdresaFurnizor1, DataIncepereColaborare=:DataIncepereColaboare1 where IDFurnizor =:IDFurnizor1";
            this.AUD(query, 1);

        }

        private void delete_Client_Click(object sender, EventArgs e)
        {
            string query = "Delete from Furnizor Where IDFurnizor=:IDFurnizor1";
            this.AUD(query, 2);
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            text_Nume_furn.Text = "";
            text_adresa_furn.Text = "";
            text_data_incepere.Text = "";
            textBox1.ReadOnly = false;
            INSERT_CLIENT.Enabled = true;
            Update_Client.Enabled = false;
            delete_Client.Enabled = false;

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
                    command.Parameters.Add("IDFurnizor1",textBox1.Text);
                    command.Parameters.Add("NumeFurnizor1",text_Nume_furn.Text);
                    command.Parameters.Add("AdresaFurnizor1",text_adresa_furn.Text);
                    if(text_data_incepere.Text=="")
                    command.Parameters.Add("DataIncepereColaboare1", "");
                    else
                    command.Parameters.Add("DataIncepereColaboare1", Convert.ToDateTime(text_data_incepere.Text));
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDFurnizor1", textBox1.Text);
                    command.Parameters.Add("NumeFurnizor1", text_Nume_furn.Text);
                    command.Parameters.Add("AdresaFurnizor1", text_adresa_furn.Text);
                    if (text_data_incepere.Text == "")
                        command.Parameters.Add("DataIncepereColaboare1", "");
                    else
                        command.Parameters.Add("DataIncepereColaboare1", Convert.ToDateTime(text_data_incepere.Text));
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDFurnizor1", textBox1.Text);
                    break;
            }

            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Furnizor", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.ReadOnly = true;
            text_Nume_furn.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_adresa_furn.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            text_data_incepere.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            INSERT_CLIENT.Enabled = false;
            Update_Client.Enabled = true;
            delete_Client.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            text_data_incepere.Text = dateTimePicker1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
