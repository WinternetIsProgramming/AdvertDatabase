namespace InlamnDatabas.Views
{
    partial class FormUserAdverts
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
            textBoxTitle = new TextBox();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            listBoxTitles = new ListBox();
            richTextBoxDescription = new RichTextBox();
            textBoxPrice = new TextBox();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            labelTitle = new Label();
            labelPrice = new Label();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(164, 60);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(183, 23);
            textBoxTitle.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(261, 321);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(353, 321);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(447, 321);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBoxTitles
            // 
            listBoxTitles.FormattingEnabled = true;
            listBoxTitles.ItemHeight = 15;
            listBoxTitles.Location = new Point(12, 89);
            listBoxTitles.Name = "listBoxTitles";
            listBoxTitles.Size = new Size(118, 214);
            listBoxTitles.TabIndex = 4;
            listBoxTitles.SelectedIndexChanged += listBoxTitles_SelectedIndexChanged;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(147, 89);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(375, 226);
            richTextBoxDescription.TabIndex = 5;
            richTextBoxDescription.Text = "";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(423, 60);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(99, 23);
            textBoxPrice.TabIndex = 6;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(164, 31);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 7;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(103, 34);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(55, 15);
            labelCategory.TabIndex = 8;
            labelCategory.Text = "Category";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(120, 63);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(29, 15);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Title";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(379, 63);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 10;
            labelPrice.Text = "Price";
            // 
            // FormUserAdverts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 373);
            Controls.Add(labelPrice);
            Controls.Add(labelTitle);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxPrice);
            Controls.Add(richTextBoxDescription);
            Controls.Add(listBoxTitles);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTitle);
            Name = "FormUserAdverts";
            Text = "FormUserAdverts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonDelete;
        private ListBox listBoxTitles;
        private RichTextBox richTextBoxDescription;
        private TextBox textBoxPrice;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private Label labelTitle;
        private Label labelPrice;
    }
}