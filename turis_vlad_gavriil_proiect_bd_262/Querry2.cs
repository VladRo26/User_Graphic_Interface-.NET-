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
    public partial class Querry2 : Form
    {
        OracleConnection c1 = Class1.GetDBConnection();
        public Querry2()
        {
            InitializeComponent();
            c1.Open(); 
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Produs", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["IDProdus"].ToString());
            }
        }

        private void Querry2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand command = c1.CreateCommand();
            command.BindByName = true;
            command.CommandText = "select P.IDProdus,P.Nume,SUM((P.PretVanzare - P.PretVanzare * D.DiscountPerUnitate / 100) * D.Cantitate) - SUM(P.CostProductie * D.Cantitate) as PROFITPRODUS from COMANDA C " +
            "JOIN DETALIICOMANDA D on C.IDComanda = D.IDCOMANDA " +
            "JOIN PRODUS P on D.IDProdus = P.IDPRODUS " +
            "GROUP BY P.IDProdus,P.NUME ";
            command.CommandType = CommandType.Text;
            OracleDataAdapter adp = new OracleDataAdapter(command.CommandText, c1);
            DataTable d = new DataTable();
            adp.Fill(d);
            dataGridView1.DataSource = d;
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand command = c1.CreateCommand();
            command.BindByName = true;
            int par1;
            par1 = Convert.ToInt32(comboBox1.Text);
            command.CommandText = "select P.IDProdus,P.Nume,SUM((P.PretVanzare - P.PretVanzare * D.DiscountPerUnitate / 100) * D.Cantitate) - SUM(P.CostProductie * D.Cantitate) as PROFITPRODUS from COMANDA C " +
            "JOIN DETALIICOMANDA D on C.IDComanda = D.IDCOMANDA " +
            "JOIN PRODUS P on D.IDProdus = P.IDPRODUS " +
            "GROUP BY P.IDProdus,P.NUME " +
            "HAVING P.IDProdus=" + par1;
            command.CommandType = CommandType.Text;
            OracleDataAdapter adp = new OracleDataAdapter(command.CommandText, c1);
            DataTable d = new DataTable();
            adp.Fill(d);
            dataGridView1.DataSource = d;
            dataGridView1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleDataAdapter odp = new OracleDataAdapter("Select * from Produs", c1);
            DataTable dt = new DataTable();
            odp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
