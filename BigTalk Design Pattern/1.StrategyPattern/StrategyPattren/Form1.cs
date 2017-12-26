using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;

        private void ok_button_Click(object sender, EventArgs e)
        {
            double unitPrice = double.Parse(unitPrice_textBox.Text);
            int amount = int.Parse(amount_textBox.Text);
            double totalPrice = unitPrice * amount;

            CashContext cc = new CashContext(typecomboBox.Text.ToString());
            totalPrice = cc.getTotalPrice(totalPrice);
            total += totalPrice;
            listBox1.Items.Add("unitPice:" + unitPrice.ToString() + " amount:" + amount.ToString() + " totalPrice:" + totalPrice.ToString());
            resultLabel.Text = total.ToString();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

        }
    }
}
