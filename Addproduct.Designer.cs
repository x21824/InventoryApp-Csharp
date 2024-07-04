
namespace IA
{
    partial class AddProduct
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            IDText = new TextBox();
            NameText = new TextBox();
            InvText = new TextBox();
            PriceText = new TextBox();
            MaxText = new TextBox();
            minText = new TextBox();
            PartSearchButton = new Button();
            PartSearchBox = new TextBox();
            AddPartButton = new Button();
            DeleteButton = new Button();
            CancelButton = new Button();
            SaveButton = new Button();
            label8 = new Label();
            label9 = new Label();
            CandidateP = new DataGridView();
            AssociatedP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CandidateP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedP).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 128);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 172);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 215);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 253);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 291);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 291);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // IDText
            // 
            IDText.Location = new Point(74, 123);
            IDText.Name = "IDText";
            IDText.Size = new Size(88, 23);
            IDText.TabIndex = 7;
            // 
            // NameText
            // 
            NameText.Location = new Point(74, 168);
            NameText.Name = "NameText";
            NameText.Size = new Size(88, 23);
            NameText.TabIndex = 8;
            // 
            // InvText
            // 
            InvText.Location = new Point(74, 210);
            InvText.Name = "InvText";
            InvText.Size = new Size(88, 23);
            InvText.TabIndex = 9;
            InvText.TextChanged += textBox3_TextChanged;
            // 
            // PriceText
            // 
            PriceText.Location = new Point(74, 248);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(88, 23);
            PriceText.TabIndex = 10;
            // 
            // MaxText
            // 
            MaxText.Location = new Point(231, 286);
            MaxText.Name = "MaxText";
            MaxText.Size = new Size(88, 23);
            MaxText.TabIndex = 11;
            // 
            // minText
            // 
            minText.Location = new Point(74, 286);
            minText.Name = "minText";
            minText.Size = new Size(88, 23);
            minText.TabIndex = 12;
            // 
            // PartSearchButton
            // 
            PartSearchButton.Location = new Point(486, 12);
            PartSearchButton.Name = "PartSearchButton";
            PartSearchButton.Size = new Size(66, 22);
            PartSearchButton.TabIndex = 13;
            PartSearchButton.Text = "Search";
            PartSearchButton.UseVisualStyleBackColor = true;
            PartSearchButton.Click += PartSearchButton_Click;
            // 
            // PartSearchBox
            // 
            PartSearchBox.Location = new Point(558, 12);
            PartSearchBox.Name = "PartSearchBox";
            PartSearchBox.Size = new Size(138, 23);
            PartSearchBox.TabIndex = 14;
            // 
            // AddPartButton
            // 
            AddPartButton.Location = new Point(923, 229);
            AddPartButton.Name = "AddPartButton";
            AddPartButton.Size = new Size(66, 22);
            AddPartButton.TabIndex = 17;
            AddPartButton.Text = "Add";
            AddPartButton.UseVisualStyleBackColor = true;
            AddPartButton.Click += AddPartButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(923, 433);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(66, 22);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(923, 460);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(66, 22);
            CancelButton.TabIndex = 19;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button4_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(852, 460);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(66, 22);
            SaveButton.TabIndex = 20;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 13);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 21;
            label8.Text = "Candidate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 248);
            label9.Name = "label9";
            label9.Size = new Size(186, 15);
            label9.TabIndex = 22;
            label9.Text = "Parts Associated with this Product";
            // 
            // CandidateP
            // 
            CandidateP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CandidateP.Location = new Point(341, 39);
            CandidateP.Name = "CandidateP";
            CandidateP.RowHeadersWidth = 51;
            CandidateP.RowTemplate.Height = 24;
            CandidateP.Size = new Size(648, 184);
            CandidateP.TabIndex = 23;
            CandidateP.CellContentClick += CandidateP_CellContentClick;
            // 
            // AssociatedP
            // 
            AssociatedP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssociatedP.Location = new Point(341, 270);
            AssociatedP.Name = "AssociatedP";
            AssociatedP.RowHeadersWidth = 51;
            AssociatedP.RowTemplate.Height = 24;
            AssociatedP.Size = new Size(648, 158);
            AssociatedP.TabIndex = 24;
            AssociatedP.CellContentClick += AssociatedP_CellContentClick;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 493);
            Controls.Add(AssociatedP);
            Controls.Add(CandidateP);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(DeleteButton);
            Controls.Add(AddPartButton);
            Controls.Add(PartSearchBox);
            Controls.Add(PartSearchButton);
            Controls.Add(minText);
            Controls.Add(MaxText);
            Controls.Add(PriceText);
            Controls.Add(InvText);
            Controls.Add(NameText);
            Controls.Add(IDText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)CandidateP).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssociatedP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox InvText;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox MaxText;
        private System.Windows.Forms.TextBox minText;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.TextBox PartSearchBox;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView CandidateP;
        private System.Windows.Forms.DataGridView AssociatedP;
    }
}