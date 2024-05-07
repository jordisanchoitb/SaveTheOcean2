using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean2.DTOs;
using SaveTheOcean2.Persistence.Mapping;
using SaveTheOcean2.Persistence.Utils;

namespace SaveTheOcean2.View
{
    public partial class FormSpeciesAdd : Form
    {
        private FormSpecies formSpecies;
        public FormSpeciesAdd(FormSpecies formSpecies)
        {
            InitializeComponent();
            this.formSpecies = formSpecies;
        }
        private void FormSpeciesAdd_Load(object sender, EventArgs e)
        {
            cmbBox_SuperFamily.DataSource = new List<string> { "Tortuga marina", "Au marina", "Cetáceo" };
            cmbBox_SuperFamily.SelectedIndex = -1;
        }
        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formSpecies.Show();
            this.Close();
        }

        private void butt_Add_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());

                Animal animal = new Animal
                {
                    Name = txtBox_Name.Text,
                    Specie = txtBox_Specie.Text,
                    Superfamily = cmbBox_SuperFamily.Text,
                    WeightAprox = double.Parse(txtBox_WeightAprox.Text.Replace('.', ','))
                };

                animalDAO.AddAnimal(animal);
                txtBox_Name.Text = "";
                txtBox_Specie.Text = "";
                cmbBox_SuperFamily.SelectedIndex = -1;
                txtBox_WeightAprox.Text = "";
                MessageBox.Show("Espècie afegida correctament", "Afegir espècie", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtBox_Name_Validating(object sender, CancelEventArgs e)
        {
            string text = txtBox_Name.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                NameProvider.SetError(txtBox_Name, "El nom no pot estar buit");
                e.Cancel = true;
            }
            else if (MethodsUtilities.StartWithNumbers(text))
            {
                NameProvider.SetError(txtBox_Name, "El nom no pot començar amb números");
                e.Cancel = true;
            }
            else if (text.Length < 3)
            {
                NameProvider.SetError(txtBox_Name, "El nom ha de tenir més de 3 caràcters");
                e.Cancel = true;
            }
            else
            {
                NameProvider.SetError(txtBox_Name, "");
                e.Cancel = false;
            }
        }

        private void txtBox_Specie_Validating(object sender, CancelEventArgs e)
        {
            string text = txtBox_Specie.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                SpecieProvider.SetError(txtBox_Specie, "La espècie no pot estar buida");
                e.Cancel = true;
            }
            else
            {
                SpecieProvider.SetError(txtBox_Specie, "");
                e.Cancel = false;
            }
        }

        private void cmbBox_SuperFamily_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBox_SuperFamily.SelectedIndex == -1)
            {
                SuperFamilyProvider.SetError(cmbBox_SuperFamily, "Has de seleccionar una super familia");
                e.Cancel = true;
            }
            else
            {
                SuperFamilyProvider.SetError(cmbBox_SuperFamily, "");
                e.Cancel = false;
            }
        }

        private void txtBox_WeightAprox_Validating(object sender, CancelEventArgs e)
        {
            string text = txtBox_WeightAprox.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                WeightAproxProvider.SetError(txtBox_WeightAprox, "El pes aproximat no pot estar buit");
                e.Cancel = true;
            }
            else if (!double.TryParse(text, out double result))
            {
                WeightAproxProvider.SetError(txtBox_WeightAprox, "El pes ha de ser un número");
                e.Cancel = true;
            }
            else
            {
                WeightAproxProvider.SetError(txtBox_WeightAprox, "");
                e.Cancel = false;
            }

        }
    }
}
