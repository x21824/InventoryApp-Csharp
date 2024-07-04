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

namespace IA
{
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
            IDTextM.Enabled = false;
            InvTextM.KeyPress += new KeyPressEventHandler(InvTextM_KeyPress);
            PriceTextM.KeyPress += new KeyPressEventHandler(PriceTextM_KeyPress);
            MaxTextM.KeyPress += new KeyPressEventHandler(MaxTextM_KeyPress);
            minTextM.KeyPress += new KeyPressEventHandler(minTextM_KeyPress);

        }

        public ModifyPart(Inhouse InPart)
        {

            InitializeComponent();
            IDTextM.Enabled = false;
            InHouseButton.Checked = true;
            label8textM.Text = "Machine ID";
            InvTextM.KeyPress += new KeyPressEventHandler(InvTextM_KeyPress);
            PriceTextM.KeyPress += new KeyPressEventHandler(PriceTextM_KeyPress);
            MaxTextM.KeyPress += new KeyPressEventHandler(MaxTextM_KeyPress);
            minTextM.KeyPress += new KeyPressEventHandler(minTextM_KeyPress);

            IDTextM.Text = Convert.ToString(InPart.PartID);
            NametextM.Text = InPart.Name;
            InvTextM.Text = Convert.ToString(InPart.InStock);
            PriceTextM.Text = Convert.ToString(InPart.Price);
            MaxTextM.Text = Convert.ToString(InPart.Max);
            minTextM.Text = Convert.ToString(InPart.Min);
            label8textM.Text = Convert.ToString(InPart.MachineID);

            int PartIndex = InPart.PartID;




        }

        public ModifyPart(Outsourced OutPart)
        {
            InitializeComponent();
            IDTextM.Enabled = false;
            label8textM.Text = "Company Name";
            OutsourcedButton.Checked = true;

            InvTextM.KeyPress += new KeyPressEventHandler(InvTextM_KeyPress);
            PriceTextM.KeyPress += new KeyPressEventHandler(PriceTextM_KeyPress);
            MaxTextM.KeyPress += new KeyPressEventHandler(MaxTextM_KeyPress);
            minTextM.KeyPress += new KeyPressEventHandler(minTextM_KeyPress);


            IDTextM.Text = Convert.ToString(OutPart.PartID);
            NametextM.Text = OutPart.Name;
            InvTextM.Text = Convert.ToString(OutPart.InStock);
            PriceTextM.Text = Convert.ToString(OutPart.Price);
            MaxTextM.Text = Convert.ToString(OutPart.Max);
            minTextM.Text = Convert.ToString(OutPart.Min);
            label8textM.Text = Convert.ToString(OutPart.Companyname);

            int SelectedID = OutPart.PartID;
            int PartIndex = OutPart.PartID;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }





        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InHouseButton.Checked)
            {

                if (String.IsNullOrWhiteSpace(IDTextM.Text))
                {
                    MessageBox.Show("ID can't be blank");
                    return;
                }
                if (string.IsNullOrWhiteSpace(NametextM.Text))
                {
                    MessageBox.Show("Name can't be blank");
                    return;

                }
                if (string.IsNullOrWhiteSpace(InvTextM.Text) || string.IsNullOrWhiteSpace(PriceTextM.Text) || string.IsNullOrWhiteSpace(minTextM.Text) || string.IsNullOrWhiteSpace(MaxTextM.Text) || string.IsNullOrWhiteSpace(label8textM.Text))
                {
                    MessageBox.Show("Fields can't be blank");
                    return;
                }
                if (int.Parse(minTextM.Text) > int.Parse(MaxTextM.Text))
                {
                    MessageBox.Show("Minimum must be less than Max");
                    return;

                }
                if (int.Parse(InvTextM.Text) > int.Parse(MaxTextM.Text) || int.Parse(InvTextM.Text) < int.Parse(minTextM.Text))
                {
                    MessageBox.Show("Inventory must be between Min and Max");
                    return;
                }

                else
                {
                    Inhouse InPart = new Inhouse(int.Parse(IDTextM.Text), NametextM.Text, decimal.Parse(PriceTextM.Text), int.Parse(InvTextM.Text), int.Parse(minTextM.Text), int.Parse(MaxTextM.Text));
                    Inventory.UpdatePart(int.Parse(IDTextM.Text), InPart);

                }

            }
            else
            {
                OutsourcedButton.Checked = true;

                if (String.IsNullOrWhiteSpace(IDTextM.Text))
                {
                    MessageBox.Show("ID can't be blank");
                    return;
                }
                if (string.IsNullOrWhiteSpace(NametextM.Text))
                {
                    MessageBox.Show("Name can't be blank");
                    return;

                }
                if (string.IsNullOrWhiteSpace(InvTextM.Text) || string.IsNullOrWhiteSpace(PriceTextM.Text) || string.IsNullOrWhiteSpace(minTextM.Text) || string.IsNullOrWhiteSpace(MaxTextM.Text) || string.IsNullOrWhiteSpace(label8textM.Text))
                {
                    MessageBox.Show("Fields can't be blank");
                    return;
                }
                if (int.Parse(minTextM.Text) > int.Parse(MaxTextM.Text))
                {
                    MessageBox.Show("Minimum must be less than Max");
                    return;

                }
                if (int.Parse(InvTextM.Text) > int.Parse(MaxTextM.Text) || int.Parse(InvTextM.Text) < int.Parse(minTextM.Text))
                {
                    MessageBox.Show("Inventory must be between Min and Max");
                    return;
                }
                else
                {
                    Outsourced OutPart = new Outsourced(int.Parse(IDTextM.Text), NametextM.Text, decimal.Parse(PriceTextM.Text), int.Parse(InvTextM.Text), int.Parse(minTextM.Text), int.Parse(MaxTextM.Text));
                    Inventory.UpdatePart(int.Parse(IDTextM.Text), OutPart);
                }
            }
            this.Close();
        }

        private void NametextM_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvTextM_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvTextM_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }



        private void PriceTextM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MaxTextM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void minTextM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void IDTextM_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextM_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaxTextM_TextChanged(object sender, EventArgs e)
        {

        }

        private void minTextM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
