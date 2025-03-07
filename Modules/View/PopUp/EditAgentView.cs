using ArchiveManagerApp.Model;
using ArchiveManagerApp.Tools;
using ArchiveManagerApp.View.Contract;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class EditAgentView: Form
    {
        string path;
        ICallerView callerView;
      
        public EditAgentView(ICallerView callerView)
        {
            this.callerView = callerView;
            InitializeComponent();
        }
 
        private void btn_nettoyer_Click(object sender, EventArgs e)
        {
            ViewDesign.ControlsClear(pnl_body);
            txtNom.Focus();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (ViewDesign.TextBoxIsNullOrEmpty(this))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbxService.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez selectionner un service", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var agent = new Agent();
                agent.Nom = txtNom.Text;
                agent.PostNom = txtPostnom.Text;
                agent.Prenom = txtPrenom.Text;
                agent.Sexe = cbxSexe.SelectedItem.ToString();
                agent.Phone = txtPhone.Text;
                agent.Email = txtEmail.Text;
                agent.Grade = txtGrade.Text;
                agent.Fonction = txtFonction.Text;
                agent.Photo = Model.Helper.ImageUtil.BitmapToByte(picProfile.Image);
                agent.CurrentAffectation.Service = (Service)cbxService.SelectedItem;
                agent.CurrentAffectation.Date = DateTime.Now;
                agent.CurrentAffectation.IsEnd = false;              

                if (new Dao.AgentDao().Add(agent) > 0)
                {
                    MessageBox.Show("Enregistrement effectué avec succès", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewDesign.ControlsClear(pnl_body);
                    callerView.AddObject(agent);
                }
                else
                {
                    MessageBox.Show("Une Erreur est survenue lors de l'enregistrement.\n" +
                                    " Rassurez-vous d'avoir rempli tous les champs !!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
        }

        private void EditAgentView_Load(object sender, EventArgs e)
        {
            btnEnregistrer.Enabled = !ViewDesign.TextBoxIsNullOrEmpty(this);
            LoadServices();
        }

        async Task LoadServices()
        {
            cbxService.Items.Clear();
            var list = await Task.Run(() => new Dao.ServiceDao().GetAllAsync());

            foreach (var row in list)
                cbxService.Items.Add(row);

            cbxService.SelectedIndex = list != null ? 0 : -1;
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {
            ViewDesign.ControlsClear(pnl_body);
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (op.ShowDialog() == DialogResult.OK)
            {
                path = op.FileName;
                picProfile.Image = Image.FromFile(op.FileName); // Charger l'image
            }
        }
    }
}
