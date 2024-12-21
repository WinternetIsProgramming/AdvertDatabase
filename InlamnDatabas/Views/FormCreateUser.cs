using InlamnDatabas.Repository;

namespace InlamnDatabas.Views
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            UserRepo repo = new();

            repo.SaveUser(textBoxUsername.Text, textBoxPassword.Text);

            MessageBox.Show("New user created");
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
