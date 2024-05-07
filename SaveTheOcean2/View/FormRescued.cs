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

namespace SaveTheOcean2
{
    public partial class FormRescued : Form
    {
        private FormMenu formMenu;
        private List<RescuedBBDD> rescuedBBDDs;
        public FormRescued(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;

            try
            {
                lbl_error.Text = "";
                RescuedBBDDDAO rescuedBBDDDAO = new RescuedBBDDDAO(NpgsqlUtils.OpenConnection());
                rescuedBBDDs = rescuedBBDDDAO.GetAllRescuedsBBDD().ToList();
                if (rescuedBBDDs.Count == 0)
                {
                    lbl_error.Text = "No hi han dades a la Base de dades, juga alguna partida perquè hi hagin dades";
                    butt_filter.Enabled = false;
                    butt_Clear.Enabled = false;
                    lbl_error.Show();
                }
                else
                {
                    butt_filter.Enabled = true;
                    butt_Clear.Enabled = true;
                    dtvw_rescued.DataSource = rescuedBBDDs;
                    dtvw_rescued.Columns[0].Visible = false;
                    lbl_error.Hide();

                    List<string> idrescueds = rescuedBBDDs.Select(x => x.IdRescured).ToList();
                    cmbBox_idrescured.DataSource = idrescueds;
                    cmbBox_idrescured.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                lbl_error.Text = "Error en connectar-se a la BBDD";
                lbl_error.Show();
                butt_filter.Enabled = false;
                butt_Clear.Enabled = false;
            }
        }

        private void butt_back_Click(object sender, EventArgs e)
        {
            this.formMenu.Show();
            this.Close();
        }

        private void butt_filter_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string idRescured = cmbBox_idrescured.Text;
                List<RescuedBBDD> filter_rescuedBBDDs = rescuedBBDDs.Where(x => x.IdRescured == idRescured).ToList();
                dtvw_rescued.DataSource = filter_rescuedBBDDs;
            }
        }

        private void cmbBox_idrescured_Validating(object sender, CancelEventArgs e)
        {
            if (cmbBox_idrescured.SelectedIndex == -1)
            {
                e.Cancel = true;
                IdRescuedProvider.SetError(cmbBox_idrescured, "Has de seleccionar un id de rescat");
            }
            else
            {
                e.Cancel = false;
                IdRescuedProvider.SetError(cmbBox_idrescured, "");
            }
        }

        private void butt_Clear_Click(object sender, EventArgs e)
        {
            dtvw_rescued.DataSource = rescuedBBDDs;
            cmbBox_idrescured.SelectedIndex = -1;
        }
    }
}
