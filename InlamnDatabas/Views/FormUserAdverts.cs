using InlamnDatabas.Entities;
using InlamnDatabas.Repository;

namespace InlamnDatabas.Views
{
    public partial class FormUserAdverts : Form
    {
        private int activeUser;

        public FormUserAdverts(int userid)
        {
            InitializeComponent();

            LoadComboBox();

            this.activeUser = userid;
            LoadAdverts(userid);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new();
            repo.SaveAdvert(textBoxTitle.Text, richTextBoxDescription.Text, comboBoxCategory.Text, double.Parse(textBoxPrice.Text), activeUser);
            LoadAdverts(activeUser);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new();
            repo.UpdateAdvert(textBoxTitle.Text, richTextBoxDescription.Text, comboBoxCategory.Text, double.Parse(textBoxPrice.Text), (int)listBoxTitles.SelectedValue);
            LoadAdverts(activeUser);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AdvertRepo repo = new();
            repo.DeleteAdvert((int)listBoxTitles.SelectedValue);
            LoadAdverts(activeUser);
        }

        private void LoadAdverts(int userid)
        {
            AdvertRepo repo = new();

            listBoxTitles.DisplayMember = "AdvertTitle";
            listBoxTitles.ValueMember = "AdvertId";
            listBoxTitles.DataSource = repo.GetUserAdverts(userid);
        }

        private void listBoxTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvertRepo repo = new();

            List<Advert> advert = repo.GetAdvertDesc((int)listBoxTitles.SelectedValue);

            comboBoxCategory.Text = advert[0].Category.CategoryName;
            textBoxTitle.Text = advert[0].AdvertTitle;
            textBoxPrice.Text = advert[0].AdvertPrice.ToString();
            richTextBoxDescription.Text = advert[0].AdvertDescription;
        }

        private void LoadComboBox()
        {
            CategoryRepo repo = new CategoryRepo();
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryID";
            comboBoxCategory.DataSource = repo.GetCategories();
        }
    }
}
