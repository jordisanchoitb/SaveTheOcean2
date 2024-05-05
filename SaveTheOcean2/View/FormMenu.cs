namespace SaveTheOcean2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void butt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_start_Click(object sender, EventArgs e)
        {
            FormRol formGame = new FormRol(this);
            formGame.Show();
            this.Hide();
        }

        private void butt_rescued_Click(object sender, EventArgs e)
        {
            FormRescued formRescued = new FormRescued(this);
            formRescued.Show();
            this.Hide();
        }

        private void butt_species_Click(object sender, EventArgs e)
        {
            FormSpecies formSpecies = new FormSpecies(this);
            formSpecies.Show();
            this.Hide();
        }
    }
}
