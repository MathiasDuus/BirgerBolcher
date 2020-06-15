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
    public partial class HeavyCandy : Form
    {
        public HeavyCandy()
        {
            InitializeComponent();
        }

        private void HeavyCandyBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HeavyCandy_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\math864n\source\repos\BirgerBolcher\BirgerBolcher\BirgerBolcherDB.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(

             //Vælger alle de kollonner der skal bruges
            "SELECT TOP 3 Bolcher.Navn, FarveTBL.Farve, Bolcher.Vaegt, SmagsSurhed.Surhed, SmagsStyrke.Styrke, SmagsType.Smag, Bolcher.Raavarepris " +
            "FROM Bolcher " +

            "INNER JOIN FarveTBL " +
            "ON Bolcher.FarveID = FarveTBL.FarveID " +

            "INNER JOIN SmagsSurhed " +
            "ON Bolcher.SurhedsID = SmagsSurhed.SurhedsID " +

            "INNER JOIN SmagsStyrke " +
            "ON Bolcher.StyrkeID = SmagsStyrke.StyrkeID " +

            "INNER JOIN SmagsType " +
            "ON Bolcher.SmagsID = SmagsType.SmagsID " +

            "ORDER BY Bolcher.Vaegt DESC ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVHeavyCandy.DataSource = sqltbl;
            cnn.Close();
        }

    }
}
