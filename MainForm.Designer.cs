
namespace IA
{
    partial class MainForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            AddParts = new Button();
            ModifyParts = new Button();
            DeleteParts = new Button();
            AddProduct = new Button();
            ModifyProduct = new Button();
            DeleteProduct = new Button();
            Exit = new Button();
            PartsSearch = new TextBox();
            ProductsSearch = new TextBox();
            SearchProducts = new Button();
            SearchParts = new Button();
            label1 = new Label();
            PartGrid = new DataGridView();
            partIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            partBindingSource = new BindingSource(components);
            ProductsGrid = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            Parts = new Label();
            label2 = new Label();
            inhouseBindingSource = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PartGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inhouseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddParts
            // 
            AddParts.Location = new Point(893, 358);
            AddParts.Name = "AddParts";
            AddParts.Size = new Size(66, 22);
            AddParts.TabIndex = 0;
            AddParts.Text = "Add";
            AddParts.UseVisualStyleBackColor = true;
            AddParts.Click += button1_Click;
            // 
            // ModifyParts
            // 
            ModifyParts.Location = new Point(964, 358);
            ModifyParts.Name = "ModifyParts";
            ModifyParts.Size = new Size(66, 22);
            ModifyParts.TabIndex = 3;
            ModifyParts.Text = "Modify";
            ModifyParts.UseVisualStyleBackColor = true;
            ModifyParts.Click += button2_Click;
            // 
            // DeleteParts
            // 
            DeleteParts.Location = new Point(1035, 358);
            DeleteParts.Name = "DeleteParts";
            DeleteParts.Size = new Size(66, 22);
            DeleteParts.TabIndex = 4;
            DeleteParts.Text = "Delete";
            DeleteParts.UseVisualStyleBackColor = true;
            DeleteParts.Click += button3_Click;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(893, 746);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(66, 22);
            AddProduct.TabIndex = 5;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // ModifyProduct
            // 
            ModifyProduct.Location = new Point(964, 746);
            ModifyProduct.Name = "ModifyProduct";
            ModifyProduct.Size = new Size(66, 22);
            ModifyProduct.TabIndex = 6;
            ModifyProduct.Text = "Modify";
            ModifyProduct.UseVisualStyleBackColor = true;
            ModifyProduct.Click += button5_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(1035, 746);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(66, 22);
            DeleteProduct.TabIndex = 7;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(1035, 812);
            Exit.Name = "Exit";
            Exit.Size = new Size(66, 22);
            Exit.TabIndex = 8;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // PartsSearch
            // 
            PartsSearch.Location = new Point(964, 77);
            PartsSearch.Name = "PartsSearch";
            PartsSearch.Size = new Size(124, 23);
            PartsSearch.TabIndex = 9;
            // 
            // ProductsSearch
            // 
            ProductsSearch.Location = new Point(964, 469);
            ProductsSearch.Name = "ProductsSearch";
            ProductsSearch.Size = new Size(123, 23);
            ProductsSearch.TabIndex = 10;
            // 
            // SearchProducts
            // 
            SearchProducts.Location = new Point(893, 469);
            SearchProducts.Name = "SearchProducts";
            SearchProducts.Size = new Size(66, 22);
            SearchProducts.TabIndex = 11;
            SearchProducts.Text = "Search";
            SearchProducts.UseVisualStyleBackColor = true;
            SearchProducts.Click += button1_Click_1;
            // 
            // SearchParts
            // 
            SearchParts.Location = new Point(893, 77);
            SearchParts.Name = "SearchParts";
            SearchParts.Size = new Size(66, 22);
            SearchParts.TabIndex = 12;
            SearchParts.Text = "Search";
            SearchParts.UseVisualStyleBackColor = true;
            SearchParts.Click += SearchParts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 13;
            label1.Text = "All Records";
            label1.Click += label1_Click;
            // 
            // PartGrid
            // 
            PartGrid.AutoGenerateColumns = false;
            PartGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartGrid.BackgroundColor = Color.DarkCyan;
            PartGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartGrid.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, inStockDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            PartGrid.DataSource = partBindingSource;
            PartGrid.Location = new Point(36, 109);
            PartGrid.Name = "PartGrid";
            PartGrid.RowHeadersWidth = 51;
            PartGrid.RowTemplate.Height = 24;
            PartGrid.Size = new Size(1075, 243);
            PartGrid.TabIndex = 15;
            PartGrid.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // partIDDataGridViewTextBoxColumn1
            // 
            partIDDataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn1.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn1.Name = "partIDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // inStockDataGridViewTextBoxColumn1
            // 
            inStockDataGridViewTextBoxColumn1.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn1.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn1.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn1.Name = "inStockDataGridViewTextBoxColumn1";
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            // 
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Part);
            // 
            // ProductsGrid
            // 
            ProductsGrid.AllowUserToAddRows = false;
            ProductsGrid.AutoGenerateColumns = false;
            ProductsGrid.BackgroundColor = Color.DarkCyan;
            ProductsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGrid.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            ProductsGrid.DataSource = productBindingSource;
            ProductsGrid.Location = new Point(36, 497);
            ProductsGrid.Name = "ProductsGrid";
            ProductsGrid.RowHeadersWidth = 51;
            ProductsGrid.RowTemplate.Height = 24;
            ProductsGrid.Size = new Size(1075, 243);
            ProductsGrid.TabIndex = 15;
            ProductsGrid.CellContentClick += dataGridView2_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn1.HeaderText = "name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            priceDataGridViewTextBoxColumn1.HeaderText = "price";
            priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.Width = 50;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            minDataGridViewTextBoxColumn1.DataPropertyName = "min";
            minDataGridViewTextBoxColumn1.HeaderText = "min";
            minDataGridViewTextBoxColumn1.MinimumWidth = 6;
            minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            minDataGridViewTextBoxColumn1.Width = 50;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            maxDataGridViewTextBoxColumn1.DataPropertyName = "max";
            maxDataGridViewTextBoxColumn1.HeaderText = "max";
            maxDataGridViewTextBoxColumn1.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            maxDataGridViewTextBoxColumn1.Width = 50;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // Parts
            // 
            Parts.AutoSize = true;
            Parts.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Parts.Location = new Point(36, 82);
            Parts.Name = "Parts";
            Parts.Size = new Size(41, 17);
            Parts.TabIndex = 16;
            Parts.Text = "Parts";
            Parts.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 475);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 17;
            label2.Text = "Products";
            // 
            // inhouseBindingSource
            // 
            inhouseBindingSource.DataSource = typeof(Inhouse);
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 846);
            Controls.Add(label2);
            Controls.Add(Parts);
            Controls.Add(ProductsGrid);
            Controls.Add(PartGrid);
            Controls.Add(label1);
            Controls.Add(SearchParts);
            Controls.Add(SearchProducts);
            Controls.Add(ProductsSearch);
            Controls.Add(PartsSearch);
            Controls.Add(Exit);
            Controls.Add(DeleteProduct);
            Controls.Add(ModifyProduct);
            Controls.Add(AddProduct);
            Controls.Add(DeleteParts);
            Controls.Add(ModifyParts);
            Controls.Add(AddParts);
            Name = "MainForm";
            Text = "Inventory Management";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)PartGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inhouseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button ModifyParts;
        private System.Windows.Forms.Button DeleteParts;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox PartsSearch;
        private System.Windows.Forms.TextBox ProductsSearch;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PartGrid;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource inhouseBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
    }
}

