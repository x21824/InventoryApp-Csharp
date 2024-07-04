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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormLoad();
        }

        public void MainFormLoad()
        {
            
            Inventory.PopulateLists();


            DataGridViewSelectionMode Row = DataGridViewSelectionMode.FullRowSelect;
            
            var Products = new BindingSource();
            Products.DataSource = Inventory.Products;
            ProductsGrid.DataSource = Products;
            ProductsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            var Parts = new BindingSource();
            Parts.DataSource = Inventory.AllParts;
            PartGrid.DataSource = Parts;
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPart f2 = new AddPart();
            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            if (PartGrid.CurrentRow.DataBoundItem.GetType() == typeof(IA.Inhouse))
            {
                Inhouse InPart = (Inhouse)PartGrid.CurrentRow.DataBoundItem;
                new ModifyPart(InPart).ShowDialog();
            }
            else
            {
                Outsourced OutPart = (Outsourced)PartGrid.CurrentRow.DataBoundItem;
                new ModifyPart(OutPart).ShowDialog();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PartGrid.CurrentRow == null || !PartGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Select a part to delete");

            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.OKCancel);
                {
                    if (confirm == DialogResult.OK)
                    {
                        foreach (DataGridViewRow row in PartGrid.SelectedRows)
                        {

                            PartGrid.Rows.RemoveAt(row.Index);
                        }
                    }
                    else return;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool match = false;
            ProductsGrid.ClearSelection();

            if (ProductsSearch.TextLength < 0)
            {
                return;
            }

            else
            {
                try
                {
                    foreach (DataGridViewRow row in ProductsGrid.Rows)
                    {
                        Product prod = (Product)row.DataBoundItem;
                        Product search = Inventory.LookupProduct(Convert.ToInt32(ProductsSearch.Text));

                        if (search.ID == prod?.ID)
                        {
                            row.Selected = true;
                            ProductsGrid.CurrentCell = row.Cells[0];
                            match = true;
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                            match = false;
                        }

                    }

                }
                catch
                {

                }
                if (match == false)
                {
                    MessageBox.Show("No match found");
                }
            }



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ProductsGrid.CurrentRow == null || !ProductsGrid.CurrentRow.Selected)
            {
                MessageBox.Show("Select a product to modify");
                return;
            }
            if (ProductsGrid.CurrentRow.DataBoundItem is Product)
            {
                Product SelectedProd = ProductsGrid.CurrentRow.DataBoundItem as Product;
                new ModifyProduct(SelectedProd).ShowDialog();
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct f3 = new AddProduct();
            f3.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {

                    Product prod = (Product)ProductsGrid.CurrentRow.DataBoundItem;
                    if (prod.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("Remove the associated parts with this product before deleting");
                        return;
                    }

                    foreach (DataGridViewRow row in ProductsGrid.SelectedRows)
                    {
                        ProductsGrid.Rows.RemoveAt(row.Index);
                    }
                }
                else return;
            }
        }

        private void SearchParts_Click(object sender, EventArgs e)
        {
            PartGrid.ClearSelection();

            if (!string.IsNullOrEmpty(PartsSearch.Text) && PartGrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in PartGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(PartsSearch.Text) || row.Cells[1].Value.ToString().Contains(PartsSearch.Text))
                    {

                        PartGrid.CurrentCell = row.Cells[0];
                        row.Selected = true;
                    }
                    if (row.Selected)
                    {
                        break;
                    }

                }
                if (PartGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No match found");
                }
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
