using SaveTheOcean2.View;
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
    public partial class FormRol : Form
    {
        private FormMenu formMenu;
        private string rol;
        private string playername;
        public FormRol(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;
        }

        private void butt_tecnic_Click(object sender, EventArgs e)
        {
            rol = "Tecnic";
            playername = txtBoxName.Text;
            FormGame formGame = new FormGame(formMenu, playername, rol);
            formGame.Show();
            this.Close();
        }

        private void butt_veterinari_Click(object sender, EventArgs e)
        {
            rol = "Veterinari";
            playername = txtBoxName.Text;
            FormGame formGame = new FormGame(formMenu, playername, rol);
            formGame.Show();
            this.Close();
        }

        private void txtBoxName_Validating(object sender, CancelEventArgs e)
        {
            string text = txtBoxName.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                NameProvider.SetError(txtBoxName, "El nom no pot estar buit");
                e.Cancel = true;
            }
            else if (MethodsUtilities.StartWithNumbers(text))
            {
                NameProvider.SetError(txtBoxName, "El nom no pot començar amb números");
                e.Cancel = true;
            }
            else if (text.Length < 3)
            {
                NameProvider.SetError(txtBoxName, "El nom ha de tenir més de 3 caràcters");
                e.Cancel = true;
            }
            else
            {
                NameProvider.SetError(txtBoxName, "");
                e.Cancel = false;
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                butt_tecnic.Enabled = false;
                butt_veterinari.Enabled = false;
            }
            else
            {
                butt_tecnic.Enabled = true;
                butt_veterinari.Enabled = true;
            }
        }
    }
}
