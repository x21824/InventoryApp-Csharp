
namespace IA
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            InHouseButton = new RadioButton();
            OutsourcedButton = new RadioButton();
            IDtext = new TextBox();
            label2 = new Label();
            Nametext = new TextBox();
            label3 = new Label();
            InvText = new TextBox();
            Pricetext = new TextBox();
            Maxtext = new TextBox();
            Mintext = new TextBox();
            label8text = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SavePartBtn = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // InHouseButton
            // 
            InHouseButton.AutoSize = true;
            InHouseButton.Location = new Point(167, 8);
            InHouseButton.Name = "InHouseButton";
            InHouseButton.Size = new Size(74, 19);
            InHouseButton.TabIndex = 1;
            InHouseButton.TabStop = true;
            InHouseButton.Text = "In-House";
            InHouseButton.UseVisualStyleBackColor = true;
            InHouseButton.CheckedChanged += InHouseButton_CheckedChanged;
            // 
            // OutsourcedButton
            // 
            OutsourcedButton.AutoSize = true;
            OutsourcedButton.Location = new Point(282, 8);
            OutsourcedButton.Name = "OutsourcedButton";
            OutsourcedButton.Size = new Size(87, 19);
            OutsourcedButton.TabIndex = 2;
            OutsourcedButton.TabStop = true;
            OutsourcedButton.Text = "Outsourced";
            OutsourcedButton.UseVisualStyleBackColor = true;
            OutsourcedButton.CheckedChanged += OutsourcedButton_CheckedChanged;
            // 
            // IDtext
            // 
            IDtext.Location = new Point(113, 58);
            IDtext.Name = "IDtext";
            IDtext.Size = new Size(88, 23);
            IDtext.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 63);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 4;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // Nametext
            // 
            Nametext.Location = new Point(113, 103);
            Nametext.Name = "Nametext";
            Nametext.Size = new Size(88, 23);
            Nametext.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 108);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // InvText
            // 
            InvText.Location = new Point(113, 148);
            InvText.Name = "InvText";
            InvText.Size = new Size(88, 23);
            InvText.TabIndex = 7;
            // 
            // Pricetext
            // 
            Pricetext.Location = new Point(113, 199);
            Pricetext.Name = "Pricetext";
            Pricetext.Size = new Size(88, 23);
            Pricetext.TabIndex = 8;
            // 
            // Maxtext
            // 
            Maxtext.Location = new Point(255, 243);
            Maxtext.Name = "Maxtext";
            Maxtext.Size = new Size(88, 23);
            Maxtext.TabIndex = 9;
            // 
            // Mintext
            // 
            Mintext.Location = new Point(113, 243);
            Mintext.Name = "Mintext";
            Mintext.Size = new Size(88, 23);
            Mintext.TabIndex = 10;
            // 
            // label8text
            // 
            label8text.Location = new Point(167, 295);
            label8text.Name = "label8text";
            label8text.Size = new Size(88, 23);
            label8text.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 153);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 207);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 13;
            label5.Text = "Price";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(219, 248);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 14;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 246);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 15;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 300);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 16;
            // 
            // SavePartBtn
            // 
            SavePartBtn.Location = new Point(200, 370);
            SavePartBtn.Name = "SavePartBtn";
            SavePartBtn.Size = new Size(66, 22);
            SavePartBtn.TabIndex = 17;
            SavePartBtn.Text = "Save";
            SavePartBtn.UseVisualStyleBackColor = true;
            SavePartBtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(306, 370);
            button2.Name = "button2";
            button2.Size = new Size(66, 22);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 422);
            Controls.Add(button2);
            Controls.Add(SavePartBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8text);
            Controls.Add(Mintext);
            Controls.Add(Maxtext);
            Controls.Add(Pricetext);
            Controls.Add(InvText);
            Controls.Add(label3);
            Controls.Add(Nametext);
            Controls.Add(label2);
            Controls.Add(IDtext);
            Controls.Add(OutsourcedButton);
            Controls.Add(InHouseButton);
            Controls.Add(label1);
            Name = "AddPart";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseButton;
        private System.Windows.Forms.RadioButton OutsourcedButton;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InvText;
        private System.Windows.Forms.TextBox Pricetext;
        private System.Windows.Forms.TextBox Maxtext;
        private System.Windows.Forms.TextBox Mintext;
        private System.Windows.Forms.TextBox label8text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SavePartBtn;
        private System.Windows.Forms.Button button2;
    }
}