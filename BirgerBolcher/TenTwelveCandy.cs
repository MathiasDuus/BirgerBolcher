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
    public partial class TenTwelveCandy : Form
    {
        public TenTwelveCandy()
        {
            InitializeComponent();
        }

        private void TenTwelveCandyBackBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TenTwelveCandy_Load(object sender, EventArgs e)
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
                "WHERE Bolcher.Vaegt >= 10 " +
                "AND Bolcher.Vaegt <= 12 " +
                "ORDER BY Navn ASC, " +
                "Vaegt ASC", cnn);
            DataTable sqltbl = new DataTable();
            sqlDa.Fill(sqltbl);

            DGVTenTwelveCandy.DataSource = sqltbl;
            cnn.Close();
        }        
    }
}
