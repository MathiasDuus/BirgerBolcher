using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirgerBolcher
{
    public partial class RandomCandy : Form
    {
        public RandomCandy()
        {
            InitializeComponent();
        }

        private void RandomCandyBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RanSearchBtn_Click(object sender, EventArgs e)
        {
            string s = RanSearchTxtbox.Text;

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\math864n\source\repos\BirgerBolcher\BirgerBolcher\BirgerBolcherDB.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(

                //Vælger alle de kollonner der skal bruges
                "SELECT TOP 1 Bolcher.Navn, FarveTBL.Farve, Bolcher.Vaegt, SmagsSurhed.Surhed, SmagsStyrke.Styrke, SmagsType.Smag, Bolcher.Raavarepris " +
                "FROM Bolcher " +

                "INNER JOIN FarveTBL " +
                "ON Bolcher.FarveID = FarveTBL.FarveID " +

                "INNER JOIN SmagsSurhed " +
                "ON Bolcher.SurhedsID = SmagsSurhed.SurhedsID " +

                "INNER JOIN SmagsStyrke " +
                "ON Bolcher.StyrkeID = SmagsStyrke.StyrkeID " +

                "INNER JOIN SmagsType " +
                "ON Bolcher.SmagsID = SmagsType.SmagsID " +

                "WHERE Bolcher.Navn LIKE '%" + s + "%' " +
                "ORDER BY NEWID() ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVRanCandy.DataSource = sqltbl;

            cnn.Close();
        }
    }
}
