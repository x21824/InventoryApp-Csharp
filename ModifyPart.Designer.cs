
namespace IA
{
    partial class ModifyPart
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
            InHouseButton = new RadioButton();
            OutsourcedButton = new RadioButton();
            IDTextM = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NametextM = new TextBox();
            InvTextM = new TextBox();
            PriceTextM = new TextBox();
            MaxTextM = new TextBox();
            minTextM = new TextBox();
            label8textM = new TextBox();
            SaveButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // InHouseButton
            // 
            InHouseButton.AutoSize = true;
            InHouseButton.Location = new Point(10, 49);
            InHouseButton.Name = "InHouseButton";
            InHouseButton.Size = new Size(74, 19);
            InHouseButton.TabIndex = 1;
            InHouseButton.TabStop = true;
            InHouseButton.Text = "In-House";
            InHouseButton.UseVisualStyleBackColor = true;
            InHouseButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // OutsourcedButton
            // 
            OutsourcedButton.AutoSize = true;
            OutsourcedButton.Location = new Point(237, 49);
            OutsourcedButton.Name = "OutsourcedButton";
            OutsourcedButton.Size = new Size(90, 19);
            OutsourcedButton.TabIndex = 2;
            OutsourcedButton.TabStop = true;
            OutsourcedButton.Text = "Outsourced ";
            OutsourcedButton.UseVisualStyleBackColor = true;
            OutsourcedButton.CheckedChanged += OutsourcedButton_CheckedChanged;
            // 
            // IDTextM
            // 
            IDTextM.Location = new Point(111, 99);
            IDTextM.Name = "IDTextM";
            IDTextM.Size = new Size(88, 23);
            IDTextM.TabIndex = 3;
            IDTextM.TextChanged += IDTextM_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 104);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 147);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 191);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 237);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Price";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 287);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 8;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 290);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 9;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 337);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 10;
            // 
            // NametextM
            // 
            NametextM.Location = new Point(111, 142);
            NametextM.Name = "NametextM";
            NametextM.Size = new Size(88, 23);
            NametextM.TabIndex = 11;
            NametextM.TextChanged += NametextM_TextChanged;
            // 
            // InvTextM
            // 
            InvTextM.Location = new Point(111, 188);
            InvTextM.Name = "InvTextM";
            InvTextM.Size = new Size(88, 23);
            InvTextM.TabIndex = 12;
            InvTextM.TextChanged += InvTextM_TextChanged;
            // 
            // PriceTextM
            // 
            PriceTextM.Location = new Point(111, 234);
            PriceTextM.Name = "PriceTextM";
            PriceTextM.Size = new Size(88, 23);
            PriceTextM.TabIndex = 13;
            PriceTextM.TextChanged += PriceTextM_TextChanged;
            // 
            // MaxTextM
            // 
            MaxTextM.Location = new Point(214, 287);
            MaxTextM.Name = "MaxTextM";
            MaxTextM.Size = new Size(88, 23);
            MaxTextM.TabIndex = 14;
            MaxTextM.TextChanged += MaxTextM_TextChanged;
            // 
            // minTextM
            // 
            minTextM.Location = new Point(54, 290);
            minTextM.Name = "minTextM";
            minTextM.Size = new Size(88, 23);
            minTextM.TabIndex = 15;
            minTextM.TextChanged += minTextM_TextChanged;
            // 
            // label8textM
            // 
            label8textM.Location = new Point(135, 332);
            label8textM.Name = "label8textM";
            label8textM.Size = new Size(88, 23);
            label8textM.TabIndex = 16;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(262, 366);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(66, 22);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(334, 366);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(66, 22);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 422);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(label8textM);
            Controls.Add(minTextM);
            Controls.Add(MaxTextM);
            Controls.Add(PriceTextM);
            Controls.Add(InvTextM);
            Controls.Add(NametextM);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(IDTextM);
            Controls.Add(OutsourcedButton);
            Controls.Add(InHouseButton);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Inventory Management";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.TextBox IDTextM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NametextM;
        private System.Windows.Forms.TextBox InvTextM;
        private System.Windows.Forms.TextBox PriceTextM;
        private System.Windows.Forms.TextBox MaxTextM;
        private System.Windows.Forms.TextBox minTextM;
        private System.Windows.Forms.TextBox label8textM;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}