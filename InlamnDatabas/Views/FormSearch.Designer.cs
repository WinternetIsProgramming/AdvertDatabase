namespace InlamnDatabas
{
    partial class FormSearch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            listBoxAds = new ListBox();
            textBoxSearchCondition = new TextBox();
            buttonSearch = new Button();
            textBoxPrice = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            labelPrice = new Label();
            comboBoxCategories = new ComboBox();
            richTextBoxDescription = new RichTextBox();
            comboBoxSorting = new ComboBox();
            buttonViewAdverts = new Button();
            buttonLogout = new Button();
            buttonNewUser = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(271, 24);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(93, 23);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(380, 24);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(99, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(499, 23);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(78, 24);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // listBoxAds
            // 
            listBoxAds.FormattingEnabled = true;
            listBoxAds.ItemHeight = 15;
            listBoxAds.Location = new Point(12, 134);
            listBoxAds.Name = "listBoxAds";
            listBoxAds.Size = new Size(119, 244);
            listBoxAds.TabIndex = 3;
            listBoxAds.SelectedIndexChanged += listBoxAds_SelectedIndexChanged;
            // 
            // textBoxSearchCondition
            // 
            textBoxSearchCondition.Location = new Point(179, 63);
            textBoxSearchCondition.Name = "textBoxSearchCondition";
            textBoxSearchCondition.Size = new Size(308, 23);
            textBoxSearchCondition.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(493, 63);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(443, 105);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(131, 23);
            textBoxPrice.TabIndex = 7;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(271, 6);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 8;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(380, 6);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 9;
            labelPassword.Text = "Password";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(401, 108);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "Price";
            // 
            // comboBoxCategories
            // 
            comboBoxCategories.FormattingEnabled = true;
            comboBoxCategories.Location = new Point(88, 64);
            comboBoxCategories.Name = "comboBoxCategories";
            comboBoxCategories.Size = new Size(85, 23);
            comboBoxCategories.TabIndex = 11;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(156, 134);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(418, 244);
            richTextBoxDescription.TabIndex = 12;
            richTextBoxDescription.Text = "";
            // 
            // comboBoxSorting
            // 
            comboBoxSorting.FormattingEnabled = true;
            comboBoxSorting.Location = new Point(12, 105);
            comboBoxSorting.Name = "comboBoxSorting";
            comboBoxSorting.Size = new Size(121, 23);
            comboBoxSorting.TabIndex = 13;
            // 
            // buttonViewAdverts
            // 
            buttonViewAdverts.Location = new Point(179, 23);
            buttonViewAdverts.Name = "buttonViewAdverts";
            buttonViewAdverts.Size = new Size(75, 23);
            buttonViewAdverts.TabIndex = 14;
            buttonViewAdverts.Text = "My Adverts";
            buttonViewAdverts.UseVisualStyleBackColor = true;
            buttonViewAdverts.Click += buttonViewAdverts_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(499, 24);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 15;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonNewUser
            // 
            buttonNewUser.Location = new Point(12, 12);
            buttonNewUser.Name = "buttonNewUser";
            buttonNewUser.Size = new Size(107, 41);
            buttonNewUser.TabIndex = 16;
            buttonNewUser.Text = "Create Account";
            buttonNewUser.UseVisualStyleBackColor = true;
            buttonNewUser.Click += buttonNewUser_Click;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 396);
            Controls.Add(buttonNewUser);
            Controls.Add(buttonLogout);
            Controls.Add(buttonViewAdverts);
            Controls.Add(comboBoxSorting);
            Controls.Add(richTextBoxDescription);
            Controls.Add(comboBoxCategories);
            Controls.Add(labelPrice);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPrice);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchCondition);
            Controls.Add(listBoxAds);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "FormSearch";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private ListBox listBoxAds;
        private TextBox textBoxSearchCondition;
        private Button buttonSearch;
        private TextBox textBoxPrice;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelPrice;
        private ComboBox comboBoxCategories;
        private RichTextBox richTextBoxDescription;
        private ComboBox comboBoxSorting;
        private Button buttonViewAdverts;
        private Button buttonLogout;
        private Button buttonNewUser;
    }
}
