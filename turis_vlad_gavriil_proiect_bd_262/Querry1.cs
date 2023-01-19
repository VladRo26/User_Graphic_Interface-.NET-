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
    public partial class Querry1 : Form
    {

        OracleConnection c1 = Class1.GetDBConnection();
        public Querry1()
        {
            InitializeComponent();
            c1.Open();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
           
             OracleCommand command = c1.CreateCommand();
            command.BindByName = true;
            double par1;
            par1 = Convert.ToDouble(textBox2.Text);
            int par2;
            par2 = Convert.ToInt32(textBox1.Text);
            command.CommandText = "select C.IDClient as IDCLIENT,C2.nume as NUMECLIENT , P.Nume as NUMEPRODUS from COMANDA C " +
    "JOIN CLIENT C2 on C.IDClient = C2.IDCLIENT " +
    "JOIN DETALIICOMANDA D on C.IDComanda = D.IDCOMANDA " +
    "JOIN PRODUS P on D.IDProdus = P.IDPRODUS " +
    "WHERE p.PretVanzare >=" + par1 + " AND D.Cantitate >=" + par2 +  "" +
    "Group by C.IDClient, C2.Nume, P.Nume";
                command.CommandType = CommandType.Text;
                OracleDataAdapter adp = new OracleDataAdapter(command.CommandText, c1);
                DataTable d = new DataTable();
                adp.Fill(d);
                dataGridView1.DataSource = d;
            dataGridView1.Refresh();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
    }
