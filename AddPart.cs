using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IA
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
            InHouseButton.Checked = true;
            IDtext.Enabled = false;
            IDtext.Text = Convert.ToString(Inventory.AllParts.Count + 1);
            InvText.KeyPress += new KeyPressEventHandler(InvText_KeyPress);
            Pricetext.KeyPress += new KeyPressEventHandler(PriceText_KeyPress);
            Mintext.KeyPress += new KeyPressEventHandler(minText_KeyPress);
            Maxtext.KeyPress += new KeyPressEventHandler(MaxText_KeyPress);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InHouseButton.Checked)
            {
                if (String.IsNullOrWhiteSpace(Nametext.Text) || string.IsNullOrWhiteSpace(InvText.Text) || string.IsNullOrWhiteSpace(Mintext.Text) || string.IsNullOrWhiteSpace(Maxtext.Text) || string.IsNullOrWhiteSpace(Pricetext.Text))
                {
                    MessageBox.Show("Fields can't be empty");
                    return;
                }
                Inhouse InPart = new Inhouse(Inventory.AllParts.Count + 1, Nametext.Text, decimal.Parse(Pricetext.Text), int.Parse(InvText.Text), int.Parse(Mintext.Text), int.Parse(Maxtext.Text));

                if (String.IsNullOrWhiteSpace(Nametext.Text) || string.IsNullOrWhiteSpace(InvText.Text) || string.IsNullOrWhiteSpace(Mintext.Text) || string.IsNullOrWhiteSpace(Maxtext.Text) || string.IsNullOrWhiteSpace(Pricetext.Text))
                {
                    MessageBox.Show("Fields can't be empty");
                    return;
                }
                if (int.Parse(Mintext.Text) > int.Parse(Maxtext.Text))
                {
                    MessageBox.Show("Minimum must be less than Max");
                    return;
                }
                if (int.Parse(InvText.Text) > int.Parse(Maxtext.Text) || int.Parse(InvText.Text) < int.Parse(Mintext.Text))
                {
                    MessageBox.Show("Inventory Amount can't be greater than the Maximum or less than the Minimum");
                    return;
                }
                else
                {
                    Inventory.AddPart(InPart);
                    this.Close();
                }

            }
            else
            {
                Outsourced OutPart = new Outsourced(Inventory.AllParts.Count + 1, Nametext.Text, decimal.Parse(Pricetext.Text), int.Parse(InvText.Text), int.Parse(Mintext.Text), int.Parse(Maxtext.Text), label8text.Text);
                OutsourcedButton.Checked = true;

                if (int.Parse(Mintext.Text) > int.Parse(Maxtext.Text))
                {
                    MessageBox.Show("Minimum must be less than Max");
                    return;
                }
                if (int.Parse(InvText.Text) > int.Parse(Maxtext.Text) || int.Parse(InvText.Text) < int.Parse(Mintext.Text))
                {
                    MessageBox.Show("Inventory Amount can't be greater than the Maximum or less than the Minimum");
                    return;
                }
                if (String.IsNullOrWhiteSpace(Nametext.Text))
                {
                    MessageBox.Show("The Name Can't Be Empty");
                    return;
                }

                else
                {
                    Inventory.AddPart(OutPart);
                    this.Close();

                }

            }
        }

        private void InHouseButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void InvText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }



        private void PriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void MaxText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void minText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
