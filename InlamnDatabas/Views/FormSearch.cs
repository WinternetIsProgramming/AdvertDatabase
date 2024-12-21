using InlamnDatabas.Entities;
using InlamnDatabas.Repository;
using InlamnDatabas.Views;

namespace InlamnDatabas
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();

            ShowButtons("no");
            LoadComboBox();
        }

        int userid;

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();

            listBoxAds.DisplayMember = "AdvertTitle";
            listBoxAds.ValueMember = "AdvertId";
            listBoxAds.DataSource = repo.SearchAdverts(textBoxSearchCondition.Text, comboBoxCategories.Text, comboBoxSorting.Text);
        }

        private void listBoxAds_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvertRepo repo = new AdvertRepo();
            List<Advert> advert = repo.GetAdvertDesc((int)listBoxAds.SelectedValue);

            textBoxPrice.Text = advert[0].AdvertPrice.ToString();
            richTextBoxDescription.Text = advert[0].AdvertDescription.ToString();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserRepo repo = new();

            List<User> user = repo.GetUser(textBoxUsername.Text, textBoxPassword.Text);

            if (user.Count > 0)
            {
                userid = user[0].UserId;
                ShowButtons("yes");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Felaktig inloggning");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            ShowButtons("no");
        }

        private void buttonViewAdverts_Click(object sender, EventArgs e)
        {
            FormUserAdverts frmUsAds = new FormUserAdverts(userid);
            frmUsAds.Show();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            FormCreateUser frmUser = new FormCreateUser();
            frmUser.Show();
        }

        private void LoadComboBox()
        {
            CategoryRepo repo = new CategoryRepo();
            comboBoxCategories.DisplayMember = "CategoryName";
            comboBoxCategories.ValueMember = "CategoryID";
            comboBoxCategories.DataSource = repo.GetCategories();

            comboBoxSorting.Items.Add("Price (lowest first)");
            comboBoxSorting.Items.Add("Price (highest first)");
            comboBoxSorting.Items.Add("Date (oldest first)");
            comboBoxSorting.Items.Add("Date (newest first)");
        }

        private void ShowButtons(string loggedin)
        {
            if (loggedin == "yes")
            {
                buttonViewAdverts.Visible = true;
                buttonLogout.Visible = true;

                textBoxUsername.Visible = false;
                textBoxPassword.Visible = false;
                buttonLogin.Visible = false;
                labelUsername.Visible = false;
                labelPassword.Visible = false;
                buttonNewUser.Visible = false;
            }
            else
            {
                buttonViewAdverts.Visible = false;
                buttonLogout.Visible = false;

                textBoxUsername.Visible = true;
                textBoxPassword.Visible = true;
                buttonLogin.Visible = true;
                labelUsername.Visible = true;
                labelPassword.Visible = true;
                buttonNewUser.Visible = true;
            }
        }
    }
}
