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
    public partial class FormRescued : Form
    {
        private FormMenu formMenu;
        public FormRescued(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }
    }
}
