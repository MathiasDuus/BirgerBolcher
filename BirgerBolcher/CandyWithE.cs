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

namespace BirgerBolcher
{
    public partial class CandyWithE : Form
    {
        public CandyWithE()
        {
            InitializeComponent();
        }

        private void CandyWithE_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\math864n\source\repos\BirgerBolcher\BirgerBolcher\BirgerBolcherDB.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(

                //Vælger alle de kollonner der skal bruges
                "SELECT Bolcher.Navn " +
                "FROM Bolcher " +
                "WHERE Bolcher.Navn LIKE '%e%' ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVCandyWithE.DataSource = sqltbl;
            cnn.Close();
        }

        private void RedBlueCandyBackBtn_Click(object sender, EventArgs e)
        {
            var nextform = new Menu();
            nextform.Show();
            Hide();
        }
    }
}
