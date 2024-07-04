using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IA
{
    public partial class AddProduct : Form
    {
        public BindingList<Part> tempPart = new BindingList<Part>();
        Inventory inventory = new Inventory();
        Product product = new Product();

        public AddProduct()
        {
            InitializeComponent();
            CandidateP.DataSource = Inventory.AllParts;
            AssociatedP.DataSource = product.AssociatedParts;
            InvText.KeyPress += new KeyPressEventHandler(InvText_KeyPress);
            PriceText.KeyPress += new KeyPressEventHandler(PriceText_KeyPress);
            minText.KeyPress += new KeyPressEventHandler(minText_KeyPress);
            MaxText.KeyPress += new KeyPressEventHandler(MaxText_KeyPress);

            AddProductLoad();
        }

        public void AddProductLoad()
        {


            var CanPartLoad = new BindingSource();
            CanPartLoad.DataSource = Inventory.AllParts;
            CandidateP.DataSource = CanPartLoad;
            CandidateP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            IDText.Text = Convert.ToString(Inventory.Products.Count + 1);
            IDText.Enabled = false;



            var ALoad = new BindingSource();
            ALoad.DataSource = tempPart;
            AssociatedP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssociatedP.DataSource = product.AssociatedParts;

            foreach (Part part in product.AssociatedParts)
            {
                tempPart.Add(part);
            }


        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CandidateP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssociatedP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in AssociatedP.SelectedRows)
                    {
                        AssociatedP.Rows.RemoveAt(row.Index);
                    }
                }
                else return;

            }

        }

        private void PartSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int SearchID = int.Parse(PartSearchBox.Text);
                Part found = Inventory.LookupPart(SearchID);

                foreach (DataGridViewRow row in CandidateP.Rows)
                {
                    Part P = (Part)row.DataBoundItem;

                    if (P.PartID == found.PartID)
                    {
                        row.Selected = true;
                        CandidateP.CurrentCell = row.Cells[0];
                        break;
                    }
                    else
                    {
                        row.Selected = false;

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Part not found");
            }
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part p = (Part)CandidateP.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(p);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameText.Text) || string.IsNullOrWhiteSpace(PriceText.Text) || string.IsNullOrWhiteSpace(InvText.Text) || string.IsNullOrWhiteSpace(minText.Text) || string.IsNullOrWhiteSpace(MaxText.Text))
            {
                MessageBox.Show("Fields can't be empty");
                return;
            }
            if (int.Parse(minText.Text) > int.Parse(MaxText.Text))
            {
                MessageBox.Show("Min must be less than Max");
                return;
            }
            if (int.Parse(InvText.Text) > int.Parse(MaxText.Text) || int.Parse(InvText.Text) < int.Parse(minText.Text))
            {
                MessageBox.Show("Inventory must be between Min and Max");
                return;
            }
            else
            {
                try
                {
                    Product product = new Product(int.Parse(IDText.Text), NameText.Text, decimal.Parse(PriceText.Text), int.Parse(InvText.Text), int.Parse(minText.Text), int.Parse(MaxText.Text));
                    try
                    {
                        foreach (DataGridViewRow row in AssociatedP.Rows)
                        {
                            Part aPart = (Part)row.DataBoundItem;
                            product.AssociatedParts.Add(aPart);
                        }
                    }
                    catch { throw; }
                    Inventory.AddProduct(product);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                    throw;
                }


                this.Close();
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

        private void InvText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
