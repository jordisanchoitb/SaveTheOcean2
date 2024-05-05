using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveTheOcean2.View
{
    public partial class FormGame : Form
    {
        const string Msg112Rescued = "Hola, {0}! El 112 ha rebut una trucada d'avís d'un exemplar a rescatar.";
        const string MsgTreatment = "{0} té un grau d'afectació (GA) del {1}%. Vols curar-lo o traslladar-lo al centre?";
        const string MsgXpAugment = " La teva experiència ha augmentat en +{0}XP.";
        const string MsgXpDecrease = " La teva experiència s’ha reduït en -{0}XP.";
        const string MsgTreatmentExit = "El tractament aplicat ha reduït el GA fins al {0}%. Rescat èxit! {1}, de la espècie {2} ha estat reintroduït al medi natural.";
        const string MsgTreatmentNotExit = "El tractament aplicat ha reduït el GA fins al {0}%. L'exemplar {1}, de la espècie {2} requereix més atenció. Traslladant al CRAM.";
        const int FORTUFIVE = 45, EIGHTING = 80, THIRTY = 30, FIFTY = 50, TWENTY = 20;

        private FormMenu formMenu;
        private AAnimal animal;
        private Player player;
        private Rescued rescued;
        private string superFamily;
        private int newGradeAfectation;
        public FormGame(FormMenu formMenu, string playername, string role)
        {
            InitializeComponent();
            this.formMenu = formMenu;
            // Agafem un super família aleatòria a partir del mètode GetRandomSuperfamily
            superFamily = MethodsUtilities.GetRandomSuperfamily();

            // Instanciem un animal a rescata de la super família obtinguda anteriorment
            animal = MethodsUtilities.GetAnimalBySuperfamily(superFamily) ?? new SeaTurtle();

            // Instanciem un rescat amb la super família obtinguda anteriorment
            rescued = new Rescued(animal);

            // Instanciem un jugador amb el nom i la experiència a partir del rol escollit
            player = new Player(playername, role == "Tecnic" ? FORTUFIVE : EIGHTING);

            lbl_playerInfo.Text = $"{player}";

            lbl_msgRescat.Text = string.Format(Msg112Rescued, playername);
            lbl_TableRescat.Text = MethodsUtilities.PrintInfoData(rescued);
            lbl_FitxaRescat.Text = MethodsUtilities.PrintInfoDataSheet(rescued);
            lbl_choose.Text = string.Format(MsgTreatment, rescued.Animal.Name, rescued.Animal.GradeAfectation);
        }

        private void butt_heal_Click(object sender, EventArgs e)
        {
            newGradeAfectation = animal.CalculateNewGradeAfectation(true);
            lbl_playerInfo.Hide();
            lbl_msgRescat.Hide();
            lbl_TableRescat.Hide();
            lbl_FitxaRescat.Hide();
            lbl_choose.Hide();
            butt_heal.Hide();
            butt_move.Hide();
            if (newGradeAfectation <= THIRTY)
            {
                lbl_msgtreatment.Text = string.Format(MsgTreatmentExit, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(MsgXpAugment, FIFTY);
                lbl_msgxp.Show();
                player.AddExperience(FIFTY);
            }
            else
            {
                lbl_msgtreatment.Text = string.Format(MsgTreatmentNotExit, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(MsgXpDecrease, TWENTY);
                lbl_msgxp.Show();
                player.RemoveExperience(TWENTY);
            }
            butt_gomenu.Show();
        }

        private void butt_move_Click(object sender, EventArgs e)
        {
            newGradeAfectation = animal.CalculateNewGradeAfectation(false);
            lbl_playerInfo.Hide();
            lbl_msgRescat.Hide();
            lbl_TableRescat.Hide();
            lbl_FitxaRescat.Hide();
            lbl_choose.Hide();
            butt_heal.Hide();
            butt_move.Hide();
            if (newGradeAfectation <= THIRTY)
            {
                lbl_msgtreatment.Text = string.Format(MsgTreatmentExit, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(MsgXpAugment, FIFTY);
                lbl_msgxp.Show();
                player.AddExperience(FIFTY);
            }
            else
            {
                lbl_msgtreatment.Text = string.Format(MsgTreatmentNotExit, newGradeAfectation, rescued.Animal.Name, rescued.Animal.Specie);
                lbl_msgtreatment.Show();
                lbl_msgxp.Text = string.Format(MsgXpDecrease, TWENTY);
                lbl_msgxp.Show();
                player.RemoveExperience(TWENTY);
            }
            butt_gomenu.Show();
        }

        private void butt_gomenu_Click(object sender, EventArgs e)
        {
            formMenu.Show();
            this.Close();
        }
    }
}
