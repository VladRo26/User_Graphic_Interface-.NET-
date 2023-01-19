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
    
    public partial class Comanda : Form
    {
        public static class var
        {
            public static int parcom = 0;
            public static int c_parcom
            {
                get { return parcom; }
                set { parcom = value; }
            }
        }
        OracleConnection c1 = Class1.GetDBConnection();
        public Comanda()
        {
            InitializeComponent();
            dataGridView2.Hide();
            button1.Visible = false;
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Comanda", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
            comboBox1.Items.Add("DA");
            comboBox1.Items.Add("NU");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void INSERT_CLIENT_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Comanda(IDComanda,IDClient,IDVanzator,DataComanda,DataLivrare,Status,Total,Taxe,CostLivrare,EsteOnline) " + "VALUES(:IDComanda1,:IDClient1,:IDVanzator1,:DataComanda1,:DataLivrare1,:Status1,:Total1,:Taxe1,:CostLivrare1,:EsteOnline1)";
            this.AUD(query, 0);
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void Update_Ingredient_Click(object sender, EventArgs e)
        {
            string query = "Update Comanda set IDComanda =:IDComanda1, IDClient =:IDClient1, IDVanzator =:IDVanzator1, DataComanda=:DataComanda1, DataLivrare=:DataLivrare1, Status=:Status1, Total=:Total1, Taxe=:Taxe1, CostLivrare=:CostLivrare1, EsteOnline=:EsteOnline1 where IDComanda =:IDComanda1";
            this.AUD(query, 1);
        }

        private void delete_Ingredient_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            OracleDataAdapter odp = new OracleDataAdapter("Select * from DetaliiComanda where IDComanda=" + var.parcom, c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView2.DataSource = dt;
            MessageBox.Show("Atentie stergerea acestei inregistari va duce si la stergerea urmatoarelor inregistari", "CONSTRANGERE ON DELETE CASCADE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            button1.Visible = true;
            button1.Enabled = true;
           
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
            button1.Enabled = false;
            button1.Visible = false;
            dataGridView2.Hide();
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
                    command.Parameters.Add("IDComanda1", textBox1.Text);
                    command.Parameters.Add("IDClient1", textBox2.Text);
                    command.Parameters.Add("IDVanzator1", textBox3.Text);
                    command.Parameters.Add("DataComanda1", Convert.ToDateTime(textBox4.Text));
                    if(textBox5.Text=="")
                    command.Parameters.Add("DataLivrare1", "");
                    else
                    command.Parameters.Add("DataLivrare1", Convert.ToDateTime(textBox5.Text));
                    command.Parameters.Add("Status1", textBox6.Text);
                    command.Parameters.Add("Total1", textBox7.Text);
                    command.Parameters.Add("Taxe1", textBox8.Text);
                    command.Parameters.Add("CostLivrare1", textBox9.Text);
                    if (comboBox1.Text == "DA")
                        command.Parameters.Add("EsteOnline1", "DA");
                    else
                        command.Parameters.Add("EsteOnline1", "NU");
                    break;
                case 1:
                    mesaj = "Rand modificat cu succes!";
                    command.Parameters.Add("IDComanda1", textBox1.Text);
                    command.Parameters.Add("IDClient1", textBox2.Text);
                    command.Parameters.Add("IDVanzator1", textBox3.Text);
                    command.Parameters.Add("DataComanda1", Convert.ToDateTime(textBox4.Text));
                    if (textBox5.Text == "")
                        command.Parameters.Add("DataLivrare1", "");
                    else
                        command.Parameters.Add("DataLivrare1", Convert.ToDateTime(textBox5.Text));
                    command.Parameters.Add("Status1", textBox6.Text);
                    command.Parameters.Add("Total1", textBox7.Text);
                    command.Parameters.Add("Taxe1", textBox8.Text);
                    command.Parameters.Add("CostLivrare1", textBox9.Text);
                    if (comboBox1.Text == "DA")
                        command.Parameters.Add("EsteOnline1", "DA");
                    else
                        command.Parameters.Add("EsteOnline1", "NU");
                    break;
                case 2:
                    mesaj = "Rand sters cu succes!";
                    command.Parameters.Add("IDComanda1", textBox1.Text);
                    break;
            }
            OracleDataReader r = command.ExecuteReader();
            c1.Close();
            c1.Open();
            MessageBox.Show(mesaj);
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Comanda", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            c1.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        
            var.parcom = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() == "DA")
                comboBox1.Text = "DA";
            else
                comboBox1.Text = "NU";
            INSERT_CLIENT.Enabled = false;
            Update_Ingredient.Enabled = true;
            delete_Ingredient.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker1.Value.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox5.Text = dateTimePicker1.Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmati stergerea ambelor seturi de inregistari?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                string query = "Delete from Comanda where IDComanda =:IDComanda1";
                dataGridView2.Hide();
                button1.Enabled = false;
                button1.Visible = false;
                this.AUD(query, 2);
            }

        }
    }
}
