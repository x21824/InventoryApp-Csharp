
namespace IA
{
    partial class ModifyProduct
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
            label1 = new Label();
            IDTextM = new TextBox();
            SearchButtonM = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NameTextM = new TextBox();
            InvTextM = new TextBox();
            PriceTextM = new TextBox();
            MaxTextM = new TextBox();
            MinTextM = new TextBox();
            SearchTextM = new TextBox();
            AddButtonM = new Button();
            DeleteButtonM = new Button();
            Cancel = new Button();
            SaveButtonM = new Button();
            label8 = new Label();
            label9 = new Label();
            CandidatePM = new DataGridView();
            AssociatedPM = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CandidatePM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPM).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Modify Product";
            // 
            // IDTextM
            // 
            IDTextM.Location = new Point(94, 121);
            IDTextM.Name = "IDTextM";
            IDTextM.Size = new Size(88, 23);
            IDTextM.TabIndex = 1;
            // 
            // SearchButtonM
            // 
            SearchButtonM.Location = new Point(701, 32);
            SearchButtonM.Name = "SearchButtonM";
            SearchButtonM.Size = new Size(66, 22);
            SearchButtonM.TabIndex = 2;
            SearchButtonM.Text = "Search";
            SearchButtonM.UseVisualStyleBackColor = true;
            SearchButtonM.Click += SearchButtonM_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 126);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 173);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 230);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 284);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 333);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 7;
            label6.Text = "Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 371);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 8;
            label7.Text = "Max";
            // 
            // NameTextM
            // 
            NameTextM.Location = new Point(94, 169);
            NameTextM.Name = "NameTextM";
            NameTextM.Size = new Size(88, 23);
            NameTextM.TabIndex = 9;
            // 
            // InvTextM
            // 
            InvTextM.Location = new Point(94, 225);
            InvTextM.Name = "InvTextM";
            InvTextM.Size = new Size(88, 23);
            InvTextM.TabIndex = 10;
            // 
            // PriceTextM
            // 
            PriceTextM.Location = new Point(94, 279);
            PriceTextM.Name = "PriceTextM";
            PriceTextM.Size = new Size(88, 23);
            PriceTextM.TabIndex = 11;
            PriceTextM.TextChanged += textBox4_TextChanged;
            // 
            // MaxTextM
            // 
            MaxTextM.Location = new Point(94, 371);
            MaxTextM.Name = "MaxTextM";
            MaxTextM.Size = new Size(55, 23);
            MaxTextM.TabIndex = 12;
            // 
            // MinTextM
            // 
            MinTextM.Location = new Point(94, 330);
            MinTextM.Name = "MinTextM";
            MinTextM.Size = new Size(57, 23);
            MinTextM.TabIndex = 13;
            // 
            // SearchTextM
            // 
            SearchTextM.Location = new Point(773, 31);
            SearchTextM.Name = "SearchTextM";
            SearchTextM.Size = new Size(117, 23);
            SearchTextM.TabIndex = 14;
            // 
            // AddButtonM
            // 
            AddButtonM.Location = new Point(824, 207);
            AddButtonM.Name = "AddButtonM";
            AddButtonM.Size = new Size(66, 22);
            AddButtonM.TabIndex = 17;
            AddButtonM.Text = "Add";
            AddButtonM.UseVisualStyleBackColor = true;
            AddButtonM.Click += AddButtonM_Click;
            // 
            // DeleteButtonM
            // 
            DeleteButtonM.Location = new Point(824, 400);
            DeleteButtonM.Name = "DeleteButtonM";
            DeleteButtonM.Size = new Size(66, 22);
            DeleteButtonM.TabIndex = 18;
            DeleteButtonM.Text = "Delete";
            DeleteButtonM.UseVisualStyleBackColor = true;
            DeleteButtonM.Click += DeleteButtonM_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(824, 428);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(66, 22);
            Cancel.TabIndex = 19;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // SaveButtonM
            // 
            SaveButtonM.Location = new Point(752, 428);
            SaveButtonM.Name = "SaveButtonM";
            SaveButtonM.Size = new Size(66, 22);
            SaveButtonM.TabIndex = 20;
            SaveButtonM.Text = "Save";
            SaveButtonM.UseVisualStyleBackColor = true;
            SaveButtonM.Click += SaveButtonM_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(308, 40);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 21;
            label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 225);
            label9.Name = "label9";
            label9.Size = new Size(184, 15);
            label9.TabIndex = 22;
            label9.Text = "Parts Associated with the Product";
            // 
            // CandidatePM
            // 
            CandidatePM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CandidatePM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CandidatePM.Location = new Point(311, 60);
            CandidatePM.Name = "CandidatePM";
            CandidatePM.RowHeadersWidth = 51;
            CandidatePM.RowTemplate.Height = 24;
            CandidatePM.Size = new Size(579, 141);
            CandidatePM.TabIndex = 23;
            // 
            // AssociatedPM
            // 
            AssociatedPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AssociatedPM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedPM.Location = new Point(311, 245);
            AssociatedPM.Name = "AssociatedPM";
            AssociatedPM.RowHeadersWidth = 51;
            AssociatedPM.RowTemplate.Height = 24;
            AssociatedPM.Size = new Size(579, 141);
            AssociatedPM.TabIndex = 24;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 462);
            Controls.Add(AssociatedPM);
            Controls.Add(CandidatePM);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(SaveButtonM);
            Controls.Add(Cancel);
            Controls.Add(DeleteButtonM);
            Controls.Add(AddButtonM);
            Controls.Add(SearchTextM);
            Controls.Add(MinTextM);
            Controls.Add(MaxTextM);
            Controls.Add(PriceTextM);
            Controls.Add(InvTextM);
            Controls.Add(NameTextM);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SearchButtonM);
            Controls.Add(IDTextM);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "Inventory Management";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)CandidatePM).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedPM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextM;
        private System.Windows.Forms.Button SearchButtonM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameTextM;
        private System.Windows.Forms.TextBox InvTextM;
        private System.Windows.Forms.TextBox PriceTextM;
        private System.Windows.Forms.TextBox MaxTextM;
        private System.Windows.Forms.TextBox MinTextM;
        private System.Windows.Forms.TextBox SearchTextM;
        private System.Windows.Forms.Button AddButtonM;
        private System.Windows.Forms.Button DeleteButtonM;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SaveButtonM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView CandidatePM;
        private System.Windows.Forms.DataGridView AssociatedPM;
    }
}