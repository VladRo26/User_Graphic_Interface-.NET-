using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
    

namespace turis_vlad_gavriil_proiect_bd_262
{
    
    public partial class Interfata : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Interfata() 
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Client",c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                IDOnline form2 = new IDOnline();
                form2.Show();
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void Afisare_Cat_Produs_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from CategorieProdus", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                CategorieProdus formCat = new CategorieProdus();
                formCat.Show();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Furnizor", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Furnizor formf = new Furnizor();
                formf.Show();
            }
            
        }

        private void Afisare_Ingredient_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Ingredient", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Ingredient formi = new Ingredient();
                formi.Show();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from UnitateMasura", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                UnitateMasura formU = new UnitateMasura();
                formU.Show();
            }
            

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Produs", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Produs formP = new Produs();
                formP.Show();
            }
            
        }

        private void Afisare_Reteta_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Reteta", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Reteta formR = new Reteta();
                formR.Show();
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from DetaliuReteta", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                DetaliuReteta formDR = new DetaliuReteta();
                formDR.Show();
            }
        }

        private void Afisare_Departament_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Departament", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Departament formD = new Departament();
                formD.Show();
            }
        }

        private void Afisare_Angajat_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Angajat", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Angajat FormA = new Angajat();
                FormA.Show();
            }
            
        }

        private void Afisare_Istoric_Sal_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from IstoricSalarizare", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                IstoricSalarizare FormIS = new IstoricSalarizare();
                FormIS.Show();
            }
        }

        private void Afisare_Comanda_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Comanda", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                Comanda FormCo = new Comanda();
                FormCo.Show();
            }
        }

        private void Afisare_Detaliu_Comanda_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from DetaliiComanda", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Show();
            if (MessageBox.Show("Doriti sa modificati tabelul?", "Modificare tabel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Hide();
                DetaliiComanda FormDC = new DetaliiComanda();
                FormDC.Show();
            }
          
        }

        private void Afisare_Querry1_Click(object sender, EventArgs e)
        {
            Querry1 querry1 = new Querry1();
            querry1.Show();
        }

        private void Afisare_Querry2_Click(object sender, EventArgs e)
        {
            Querry2 querry2 = new Querry2();
            querry2.Show();
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }
    }
}
