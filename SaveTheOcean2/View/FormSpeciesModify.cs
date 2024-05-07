using SaveTheOcean2.Persistence.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveTheOcean2.Persistence.Utils;
using SaveTheOcean2.DTOs;

namespace SaveTheOcean2.View
{
    public partial class FormSpeciesModify : Form
    {
        FormSpecies formSpecies;
        public FormSpeciesModify(FormSpecies formSpecies)
        {
            InitializeComponent();
            this.formSpecies = formSpecies;
        }
        private void FormSpeciesModify_Load(object sender, EventArgs e)
        {
            AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());
            List<Animal> animals = animalDAO.GetAllAnimals().ToList();
            dtvw_animals.DataSource = animals;
            dtvw_animals.Columns[5].Visible = false;

            List<int> animalsIds = animals.Select(a => a.Id).ToList();
            cmbBox_Ids.DataSource = animalsIds;
            cmbBox_Ids.SelectedIndex = -1;

            cmbBox_SuperFamily.DataSource = new List<string> { "Tortuga marina", "Au marina", "Cetáceo" };
            cmbBox_SuperFamily.SelectedIndex = -1;
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formSpecies.Show();
            this.Close();
        }

        private void butt_Modify_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                AnimalDAO animalDAO = new AnimalDAO(NpgsqlUtils.OpenConnection());

                Animal animal = new Animal
                {
                    Id = (int)cmbBox_Ids.SelectedItem,
                    Name = txtBox_Name.Text,
                    Specie = txtBox_Specie.Text,
                    Superfamily = cmbBox_SuperFamily.Text,
                    WeightAprox = double.Parse(txtBox_WeightAprox.Text.Replace('.', ','))
                };

                animalDAO.UpdateAnimal(animal);
                txtBox_Name.Text = "";
                txtBox_Specie.Text = "";
                cmbBox_SuperFamily.SelectedIndex = -1;
                txtBox_WeightAprox.Text = "";
                cmbBox_Ids.SelectedIndex = -1;

                MessageBox.Show("Espècie modificada correctament", "Modificar espècie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Animal> animals = animalDAO.GetAllAnimals().ToList();
                dtvw_animals.DataSource = animals;
                dtvw_animals.Columns[5].Visible = false;

                List<int> animalsIds = animals.Select(a => a.Id).ToList();
                cmbBox_Ids.DataSource = animalsIds;
                cmbBox_Ids.SelectedIndex = -1;
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

        private void cmbBox_Ids_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBox_Ids.SelectedIndex == -1)
            {
                IdProvider.SetError(cmbBox_Ids, "Has de seleccionar un id");
                e.Cancel = true;
            }
            else
            {
                IdProvider.SetError(cmbBox_Ids, "");
                e.Cancel = false;
            }
        }

        private void dtvw_animals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                DataGridViewRow row = dtvw_animals.Rows[n];
                cmbBox_Ids.SelectedItem = row.Cells[0].Value;
                txtBox_Name.Text = row.Cells[1].Value.ToString();
                txtBox_Specie.Text = row.Cells[2].Value.ToString();
                cmbBox_SuperFamily.SelectedItem = row.Cells[3].Value;
                txtBox_WeightAprox.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
