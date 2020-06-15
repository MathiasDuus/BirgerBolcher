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
    public partial class BStartCandy : Form
    {
        public BStartCandy()
        {
            InitializeComponent();
        }

        private void BStartCandyBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BStartCandy_Load(object sender, EventArgs e)
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
                "WHERE Bolcher.Navn LIKE 'b%' ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVBStartCandy.DataSource = sqltbl;
            cnn.Close();
        }
    }
}
