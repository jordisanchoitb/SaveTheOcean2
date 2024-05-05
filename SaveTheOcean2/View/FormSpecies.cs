using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOcean2
{
    public partial class FormSpecies : Form
    {
        private FormMenu fromMenu;
        public FormSpecies(FormMenu fromMenu)
        {
            InitializeComponent();
            this.fromMenu = fromMenu;
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.fromMenu.Show();
            this.Close();
        }
    }
}
