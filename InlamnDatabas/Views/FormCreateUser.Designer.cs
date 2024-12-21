namespace InlamnDatabas.Views
{
    partial class FormCreateUser
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
            buttonSaveUser = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // buttonSaveUser
            // 
            buttonSaveUser.Location = new Point(145, 123);
            buttonSaveUser.Name = "buttonSaveUser";
            buttonSaveUser.Size = new Size(75, 23);
            buttonSaveUser.TabIndex = 0;
            buttonSaveUser.Text = "Save user";
            buttonSaveUser.UseVisualStyleBackColor = true;
            buttonSaveUser.Click += buttonSaveUser_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(30, 28);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(190, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(30, 78);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(190, 23);
            textBoxPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(30, 9);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(60, 15);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(30, 60);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // FormCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 167);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonSaveUser);
            Name = "FormCreateUser";
            Text = "FormCreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveUser;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
    }
}