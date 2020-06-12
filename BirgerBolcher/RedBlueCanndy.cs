using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirgerBolcher
{
    public partial class RedBlueCanndy : Form
    {
        public RedBlueCanndy()
        {
            InitializeComponent();
        }

        private void RedBlueCandyBackBtn_Click(object sender, EventArgs e)
        {
            var nextform = new Menu();
            nextform.Show();
            Hide();
        }

        private void RedBlueCanndy_Load(object sender, EventArgs e)
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
                "WHERE FarveID = 1 OR FarveID = 6 ", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVRedBlueCandy.DataSource = sqltbl;
            cnn.Close();
        }
    }
}
