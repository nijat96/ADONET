namespace TapAz.Forms
{
    partial class UpdateProductForm
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
            textBoxEmail = new TextBox();
            textBoxFullname = new TextBox();
            labelMobilePhone = new Label();
            labelContact = new Label();
            labelFullname = new Label();
            numericUpDownPrice = new NumericUpDown();
            labelRemainingSymbol = new Label();
            richTextBoxContent = new RichTextBox();
            comboBoxCity = new ComboBox();
            comboBoxCategory = new ComboBox();
            labelContent = new Label();
            maskedTextBoxMobile = new MaskedTextBox();
            buttonUpdate = new Button();
            comboBoxContact = new ComboBox();
            labelPrice = new Label();
            labelCity = new Label();
            labelCategory = new Label();
            labelEmail = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(169, 102);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(330, 31);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxFullname
            // 
            textBoxFullname.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullname.Location = new Point(169, 42);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(330, 31);
            textBoxFullname.TabIndex = 7;
            // 
            // labelMobilePhone
            // 
            labelMobilePhone.AutoSize = true;
            labelMobilePhone.Font = new Font("Segoe UI", 10.8F);
            labelMobilePhone.Location = new Point(27, 209);
            labelMobilePhone.Name = "labelMobilePhone";
            labelMobilePhone.Size = new Size(134, 25);
            labelMobilePhone.TabIndex = 4;
            labelMobilePhone.Text = "Mobile number";
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Font = new Font("Segoe UI", 10.8F);
            labelContact.Location = new Point(27, 158);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(73, 25);
            labelContact.TabIndex = 3;
            labelContact.Text = "Contact";
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Font = new Font("Segoe UI", 10.8F);
            labelFullname.Location = new Point(27, 45);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(83, 25);
            labelFullname.TabIndex = 1;
            labelFullname.Text = "Fullname";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownPrice.Location = new Point(158, 156);
            numericUpDownPrice.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(330, 31);
            numericUpDownPrice.TabIndex = 9;
            // 
            // labelRemainingSymbol
            // 
            labelRemainingSymbol.AutoSize = true;
            labelRemainingSymbol.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRemainingSymbol.Location = new Point(158, 435);
            labelRemainingSymbol.Name = "labelRemainingSymbol";
            labelRemainingSymbol.Size = new Size(111, 17);
            labelRemainingSymbol.TabIndex = 8;
            labelRemainingSymbol.Text = "Max Lenght 3,000";
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxContent.Location = new Point(158, 206);
            richTextBoxContent.MaxLength = 3000;
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(330, 226);
            richTextBoxContent.TabIndex = 7;
            richTextBoxContent.Text = "";
            richTextBoxContent.KeyPress += richTextBoxContent_KeyPress;
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(158, 102);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(330, 33);
            comboBoxCity.TabIndex = 5;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(158, 46);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(330, 33);
            comboBoxCategory.TabIndex = 4;
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Font = new Font("Segoe UI", 10.8F);
            labelContent.Location = new Point(19, 209);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(75, 25);
            labelContent.TabIndex = 3;
            labelContent.Text = "Content";
            // 
            // maskedTextBoxMobile
            // 
            maskedTextBoxMobile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxMobile.Location = new Point(167, 206);
            maskedTextBoxMobile.Mask = "(000) 000-0000";
            maskedTextBoxMobile.Name = "maskedTextBoxMobile";
            maskedTextBoxMobile.Size = new Size(330, 31);
            maskedTextBoxMobile.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.FromArgb(255, 102, 23);
            buttonUpdate.Location = new Point(167, 332);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(330, 61);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxContact
            // 
            comboBoxContact.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxContact.FormattingEnabled = true;
            comboBoxContact.Location = new Point(169, 155);
            comboBoxContact.Name = "comboBoxContact";
            comboBoxContact.Size = new Size(330, 33);
            comboBoxContact.TabIndex = 9;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10.8F);
            labelPrice.Location = new Point(19, 158);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(49, 25);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.Location = new Point(19, 105);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(42, 25);
            labelCity.TabIndex = 1;
            labelCity.Text = "City";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(19, 45);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(84, 25);
            labelCategory.TabIndex = 0;
            labelCategory.Text = "Category";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F);
            labelEmail.Location = new Point(27, 105);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPrice);
            groupBox1.Controls.Add(labelRemainingSymbol);
            groupBox1.Controls.Add(richTextBoxContent);
            groupBox1.Controls.Add(comboBoxCity);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(labelContent);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(labelCity);
            groupBox1.Controls.Add(labelCategory);
            groupBox1.Location = new Point(63, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 475);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 28);
            label1.Name = "label1";
            label1.Size = new Size(99, 38);
            label1.TabIndex = 0;
            label1.Text = "Tap.az";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 102, 23);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(1282, 86);
            panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maskedTextBoxMobile);
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(comboBoxContact);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxFullname);
            groupBox2.Controls.Add(labelMobilePhone);
            groupBox2.Controls.Add(labelContact);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(labelFullname);
            groupBox2.Location = new Point(688, 240);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 475);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 44);
            panel1.TabIndex = 4;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            Load += UpdateProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox textBoxEmail;
        public TextBox textBoxFullname;
        private Label labelMobilePhone;
        private Label labelContact;
        private Label labelFullname;
        public NumericUpDown numericUpDownPrice;
        private Label labelRemainingSymbol;
        public RichTextBox richTextBoxContent;
        public ComboBox comboBoxCity;
        public ComboBox comboBoxCategory;
        private Label labelContent;
        public MaskedTextBox maskedTextBoxMobile;
        private Button buttonUpdate;
        public ComboBox comboBoxContact;
        private Label labelPrice;
        private Label labelCity;
        private Label labelCategory;
        private Label labelEmail;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Panel panel1;
    }
}