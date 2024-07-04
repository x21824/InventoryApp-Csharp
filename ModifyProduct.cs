using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA
{
    public partial class ModifyProduct : Form
    {
        Inventory inventory = new Inventory();
        Product product = new Product();
        public BindingList<Part> tempPart = new BindingList<Part>();

        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            ModifyProductLoad(prod);



        }

        public void ModifyProductLoad(Product product)
        {
            IDTextM.Enabled = false;
            InvTextM.KeyPress += new KeyPressEventHandler(InvTextM_KeyPress);
            PriceTextM.KeyPress += new KeyPressEventHandler(PriceTextM_KeyPress);
            MaxTextM.KeyPress += new KeyPressEventHandler(MaxTextM_KeyPress);
            MinTextM.KeyPress += new KeyPressEventHandler(minTextM_KeyPress);
            var CandidateP = new BindingSource();
            CandidateP.DataSource = Inventory.AllParts;
            CandidatePM.DataSource = CandidateP;
            CandidatePM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (Part part in product.AssociatedParts)
            {
                tempPart.Add(part);
            }


            var AssociatedP = new BindingSource();
            AssociatedP.DataSource = tempPart;
            AssociatedPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssociatedPM.DataSource = AssociatedP;


            IDTextM.Text = Convert.ToString(product.ID);
            NameTextM.Text = product.name;
            InvTextM.Text = Convert.ToString(product.Quantity);
            PriceTextM.Text = Convert.ToString(product.price);
            MaxTextM.Text = Convert.ToString(product.max);
            MinTextM.Text = Convert.ToString(product.min);




        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButtonM_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to delete this record?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in AssociatedPM.SelectedRows)
                    {
                        AssociatedPM.Rows.RemoveAt(row.Index);
                    }
                }
                else return;

            }

        }

        private void SaveButtonM_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(IDTextM.Text))
            {
                MessageBox.Show("Missing ID");
                return;
            }
            if (string.IsNullOrWhiteSpace(NameTextM.Text))
            {
                MessageBox.Show("Missing Name");
                return;

            }
            if (string.IsNullOrWhiteSpace(InvTextM.Text) || string.IsNullOrWhiteSpace(PriceTextM.Text) || string.IsNullOrWhiteSpace(MinTextM.Text) || string.IsNullOrWhiteSpace(MaxTextM.Text))
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            if (int.Parse(MinTextM.Text) > int.Parse(MaxTextM.Text))
            {
                MessageBox.Show("Minimum must be less than Max");
                return;

            }
            if (int.Parse(InvTextM.Text) > int.Parse(MaxTextM.Text) || int.Parse(InvTextM.Text) < int.Parse(MinTextM.Text))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }
            else
            {
                try
                {
                    Product prod = new Product(int.Parse(IDTextM.Text), NameTextM.Text, decimal.Parse(PriceTextM.Text), int.Parse(InvTextM.Text), int.Parse(MinTextM.Text), int.Parse(MaxTextM.Text));
                    try
                    {
                        foreach (Part aPart in tempPart)
                        {
                            prod.AddAssociatedPart(aPart);
                        }
                        Inventory.UpdateProduct(int.Parse(IDTextM.Text), prod);

                    }
                    catch { throw; }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                    throw;
                }
                this.Close();
            }

        }

        private void AddButtonM_Click(object sender, EventArgs e)
        {
            if (CandidatePM.CurrentRow == null || !CandidatePM.CurrentRow.Selected)
            {
                MessageBox.Show("Pleae select a part to add");
            }
            else
            {
                Part aPart = (Part)CandidatePM.CurrentRow.DataBoundItem;
                tempPart.Add(aPart);



            }
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

        private void SearchButtonM_Click(object sender, EventArgs e)
        {

            try
            {
                int SearchID = int.Parse(IDTextM.Text);
                Part found = Inventory.LookupPart(SearchID);

                foreach (DataGridViewRow row in CandidatePM.Rows)
                {
                    Part P = (Part)row.DataBoundItem;

                    if (P.PartID == found.PartID)
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please enter a proper search value");
            }
        }
    }
}
