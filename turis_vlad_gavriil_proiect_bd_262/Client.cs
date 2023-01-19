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
    public partial class IDOnline : Form
    {
       
        OracleConnection c1 = Class1.GetDBConnection();
        public IDOnline()
        {
            InitializeComponent();
            Update_Client.Visible=true;
            delete_Client.Visible = true;
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Client", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();

        }


        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Client(IDClient,Nume,Prenume,ID_Online,DataNastere,Adresa) " + "VALUES(:IDClient1, :Nume1, :Prenume1, :ID_Online1, :DataNastere1, :Adresa1)";
            this.AUD(query,0);
            INSERT_CLIENT.Enabled = false;
            Update_Client.Enabled = true;
            delete_Client.Enabled = true;
        }

        private void Update_Client_Click(object sender, EventArgs e)
        {
            string query = "Update Client set IDClient =:IdClient1, Nume =:Nume1, Prenume =:Prenume1, ID_Online=:IdOnline1, DataNastere =:DataNastere1," +
 "Adresa =:Adresa where IDClient =:IdClient1";
            this.AUD(query, 1);
        }


        private void delete_Client_Click(object sender, EventArgs e)
        {
            string query = "Delete from Client Where IDClient =: IDClient1";
            this.AUD(query, 2);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Client", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
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
                    command.Parameters.Add("IDClient1", text_ClientID.Text);
                    command.Parameters.Add("Nume1", text_Client_Nume.Text);
                    command.Parameters.Add("Prenume1", text_Client_Prenume.Text);
                    command.Parameters.Add("Id_Online1", text_Client_IDOnline.Text);
                    command.Parameters.Add("DataNastere1", Convert.ToDateTime(text_Data_nastere.Text));
                    command.Parameters.Add("Adresa1", text_Client_Adresa.Text);
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IdClient1", text_ClientID.Text);
                    command.Parameters.Add("Nume1", text_Client_Nume.Text);
                    command.Parameters.Add("Prenume1", text_Client_Prenume.Text);
                    command.Parameters.Add("IdOnline1", text_Client_IDOnline.Text);
                    command.Parameters.Add("DataNastere1", Convert.ToDateTime(text_Data_nastere.Text));
                    command.Parameters.Add("Adresa1", text_Client_Adresa.Text);

                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDClient1", text_ClientID.Text);
                    break;
            }



            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Client", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            text_ClientID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_ClientID.ReadOnly = true;
            text_Client_Nume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_Client_Prenume.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_Client_IDOnline.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            picket_Client_datanastere.Text =dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            text_Data_nastere.Text= Convert.ToString(picket_Client_datanastere.Value);
            text_Client_Adresa.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            INSERT_CLIENT.Enabled = false;
            Update_Client.Enabled = true;
            delete_Client.Enabled = true;

        }

        private void text_ClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Data_nastere_TextChanged(object sender, EventArgs e)
        {
            //text_Data_nastere.Text = Convert.ToString(picket_Client_datanastere.Value);
        }

        private void picket_Client_datanastere_ValueChanged(object sender, EventArgs e)
        {
            text_Data_nastere.Text = picket_Client_datanastere.Value.ToString();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            text_ClientID.Text = "";
            text_Client_Nume.Text = "";
            text_Client_Prenume.Text = "";
            text_Client_IDOnline.Text = "";
            picket_Client_datanastere.Text = "";
            text_Data_nastere.Text = "";
            text_Client_Adresa.Text = "";
            text_ClientID.ReadOnly = false;
            INSERT_CLIENT.Enabled = true;
            Update_Client.Enabled = false;
            delete_Client.Enabled = false;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {
           

        }
    }

    }

