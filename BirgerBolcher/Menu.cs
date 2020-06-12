using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            nextform.Show();
            Hide();
        }

        private void RanCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RandomCandy();
            nextform.Show();
            Hide();
        }

        private void NameRedBlueBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RedBlueCanndy();
            nextform.Show();
            Hide();
        }

        private void NameRedCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new RedCandy();
            nextform.Show();
            Hide();
        }

        private void NotRedBtn_Click(object sender, EventArgs e)
        {
            var nextform = new NotRedCandy();
            nextform.Show();
            Hide();
        }

        private void CandyBStartBtn_Click(object sender, EventArgs e)
        {
            var nextform = new BStartCandy();
            nextform.Show();
            Hide();
        }

        private void CandyWithEBtn_Click(object sender, EventArgs e)
        {
            var nextform = new CandyWithE();
            nextform.Show();
            Hide();
        }

        private void MinTenBtn_Click(object sender, EventArgs e)
        {
            var nextform = new MinTen();
            nextform.Show();
            Hide();
        }

        private void CandyTenToTwelveBtn_Click(object sender, EventArgs e)
        {
            var nextform = new TenTwelveCandy();
            nextform.Show();
            Hide();
        }

        private void HeavyCandyBtn_Click(object sender, EventArgs e)
        {
            var nextform = new HeavyCandy();
            nextform.Show();
            Hide();
        }
    }
}
