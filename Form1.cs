using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._9Calculator
{
    public partial class FoeCalculator : Form
    {
        public FoeCalculator()
        {
            InitializeComponent();
        }

        private void getResult_Click(object sender, EventArgs e)
        {
            if (maxPR.Text == "" || currentOnPlace.Text == "" || currentPR.Text == "" || prBack.Text == "")
            {
                resultDisplay.Text = "Nie możliwe do policzenia!\r\nPuste pola!";
                return;
            }

            decimal max, curOnPlace, curOnLVL, pointsBack;

            if (!decimal.TryParse(maxPR.Text, out max) || !decimal.TryParse(currentPR.Text, out curOnLVL) || !decimal.TryParse(currentOnPlace.Text, out curOnPlace) || !decimal.TryParse(prBack.Text, out pointsBack))
            {
                resultDisplay.Text = "Podano nieodpowiednie dane!";
                return;
            }    

            decimal blockCost = Math.Ceiling((max - curOnLVL + curOnPlace) / 2.0M);

            if (curOnLVL + blockCost >= max)
            {
                resultDisplay.Text = "Blok niemożliwy do osiągnięcia!";
                return;
            }

            int profit = Convert.ToInt32(Math.Ceiling(1.9M * pointsBack - blockCost));

            StringBuilder sb = new StringBuilder();
            sb.Append("Koszt bloku: ")
                .Append(blockCost.ToString())
                .Append("\r\nZysk z 1.9: ");

            if (profit > 0)
                sb.Append(profit.ToString());
            else
                sb.Append("Brak");

            resultDisplay.Text = sb.ToString();
        }

        private void txtBoxClick(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
        }
    }
}
