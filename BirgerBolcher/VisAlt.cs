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
    public partial class VisAlt : Form
    {
        public VisAlt()
        {
            InitializeComponent();
        }

        private void VisAlt_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\math864n\source\repos\BirgerBolcher\BirgerBolcher\BirgerBolcherDB.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter(

                //Vælger alle de kollonner der skal bruges
                "SELECT Bolcher.Navn, FarveTBL.Farve, Bolcher.Vaegt, SmagsSurhed.Surhed, SmagsStyrke.Styrke, SmagsType.Smag, Bolcher.Raavarepris " +
                "FROM Bolcher " +

                "INNER JOIN FarveTBL " +
                "ON Bolcher.FarveID = FarveTBL.FarveID " +

                "INNER JOIN SmagsSurhed " +
                "ON Bolcher.SurhedsID = SmagsSurhed.SurhedsID " +

                "INNER JOIN SmagsStyrke " +
                "ON Bolcher.StyrkeID = SmagsStyrke.StyrkeID " +

                "INNER JOIN SmagsType " +
                "ON Bolcher.SmagsID = SmagsType.SmagsID ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVVisAlt.DataSource = sqltbl;




            cnn.Close();
        }

        private void ShowAllBackBtn_Click(object sender, EventArgs e)
        {
            var nextform = new Menu();
            nextform.Show();
            Hide();
        }
    }
}
