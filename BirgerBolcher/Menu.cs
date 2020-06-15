using System;
using System.Windows.Forms;

namespace BirgerBolcher
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void VisAltBolcheInfo_Click(object sender, EventArgs e)
        {
            var nextform = new VisAlt();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void RanCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RandomCandy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void NameRedBlueBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RedBlueCanndy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void NameRedCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RedCandy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void NotRedBtn_Click(object sender, EventArgs e)
        {
            var nextform = new NotRedCandy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void CandyBStartBtn_Click(object sender, EventArgs e)
        {
            var nextform = new BStartCandy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void CandyWithEBtn_Click(object sender, EventArgs e)
        {
            var nextform = new CandyWithE();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void MinTenBtn_Click(object sender, EventArgs e)
        {
            var nextform = new MinTen();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void CandyTenToTwelveBtn_Click(object sender, EventArgs e)
        {
            var nextform = new TenTwelveCandy();
            nextform.ShowDialog();
            nextform.Close();
        }

        private void HeavyCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new HeavyCandy();
            nextform.ShowDialog();
            nextform.Close();
        }
    }
}
