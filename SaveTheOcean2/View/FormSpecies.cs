using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean2.View;

namespace SaveTheOcean2
{
    public partial class FormSpecies : Form
    {
        private FormMenu formMenu;
        public FormSpecies(FormMenu fromMenu)
        {
            InitializeComponent();
            this.formMenu = fromMenu;
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }

        private void butt_modify_Click(object sender, EventArgs e)
        {
            FormSpeciesModify formSpeciesModify = new FormSpeciesModify(this);
            formSpeciesModify.Show();
            this.Hide();
        }

        private void butt_add_Click(object sender, EventArgs e)
        {
            FormSpeciesAdd formSpeciesAdd = new FormSpeciesAdd(this);
            formSpeciesAdd.Show();
            this.Hide();
        }
    }
}
