using ArchiveManagerApp.Model;
using ArchiveManagerApp.Tools;
using ArchiveManagerApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveManagerApp.Modules.View.Pop
{
    public partial class EditAgentView: Form
    {
        string path;
        public Agent Agent { get; set; }
        public EditAgentView()
        {
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
                Agent = new Agent();
                Agent.Nom = txtNom.Text;
                Agent.PostNom = txtPostnom.Text;
                Agent.Prenom = txtPrenom.Text;
                Agent.Sexe = cbxSexe.SelectedItem.ToString();
                Agent.Phone = txtPhone.Text;
                Agent.Email = txtEmail.Text;
                Agent.Grade = txtGrade.Text;
                Agent.Fonction = txtFonction.Text;
                Agent.Photo = Model.Helper.ImageUtil.BitmapToByte(picProfile.Image);
                Agent.CurrentAffectation.Service = (Service)cbxService.SelectedItem;
                Agent.CurrentAffectation.Date = DateTime.Now;
                Agent.CurrentAffectation.IsEnd = false;              

                if (new Dao.AgentDao().Add(Agent) > 0)
                {
                    MessageBox.Show("Enregistrement effectué avec succès", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewDesign.ControlsClear(pnl_body);
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

            //cbxService.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            foreach (var row in list)
            {
                //cbxService.AutoCompleteCustomSource.Add(row.ToString());
                cbxService.Items.Add(row);
            }

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
