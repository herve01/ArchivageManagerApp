using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArchiveManagerApp.Model;
using Microsoft.Office.Interop.Word;
using ArchiveManagerApp.Modules.Extension;
using ArchiveManagerApp.Util;
using Guna.UI2.WinForms;
using ArchiveManagerApp.Tools;

namespace ArchiveManagerApp.Modules.View
{
    public partial class ServiceView: UserControl
    {
        //Declaration variable
        Service service;
        List<Service> services;

        public ServiceView()
        {
            services = new List<Service>();
            InitializeComponent();
        }

        void DrawListView()
        {
            lstServices.View = System.Windows.Forms.View.Details;
            lstServices.GridLines = true;
            lstServices.FullRowSelect = true;

            var sizeColumn = (lstServices.Width - 50); // pour fixer la taille dynamique de colonne, nous envlevons la taille de la 1ere colonne

            //Ajouter les noms des entetes de la liste
            lstServices.Columns.Add("#", 50);
            lstServices.Columns.Add("Description", sizeColumn);       
        }

        void AddItemInListView(Service instance = null)
        {
            if(instance == null)
                foreach (var row in services)
                {
                    lstServices.Items.Add(new ListViewItem(row.data));
                }
            else
            {
                instance.NumberRow = services.Count == 0 ? 1 : services.FindLast(s => s.NumberRow > 0).NumberRow + 1;
                lstServices.Items.Add(new ListViewItem(instance.data));

                services.Add(instance);
            }

            lblNombreService.Text = services.Count.ToString();
        }

        async System.Threading.Tasks.Task LoadServices()
        {
            lstServices.Items.Clear();

            services = await System.Threading.Tasks.Task.Run(() => new Dao.ServiceDao().GetAllAsync());

            AddItemInListView();
        }

        private void txtService_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtService.Text))
            {
                btnAjouter.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = true;
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (ViewDesign.TextBoxIsNullOrEmpty(pnlControls))
                MessageBox.Show("Une Erreur est survenue lors de l'enregistrement.\n Rassurez-vous d'avoir rempli tous les champs !!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                service = new Model.Service();

                service.Designation = txtService.Text;
           

                if (new Dao.ServiceDao().Add(service) > 0)
                {
                    AddItemInListView(service); //Ajouter dans la liste
                    ViewDesign.TextBoxIsNullOrEmpty(pnlControls); //Nettoyer les champs
                }
                else
                {
                    MessageBox.Show("Une Erreur est survenue lors de l'enregistrement.\n" +
                                    " Rassurez-vous d'avoir rempli tous les champs !!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnAjouter.Enabled = false;
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            var motif = ((Guna2TextBox)sender).Text.Trim().ToLower().NoAccent();

            if (motif == null)
                return;

            lstServices.Items.Clear();

            lstServices.Items.AddRange(services.Where(i => string.IsNullOrEmpty(motif) || 
            i.Designation.ToLower().Trim().NoAccent().StartsWith(motif) || 
            i.Designation.ToLower().Trim().NoAccent().Contains(motif))
            .Select(c => new ListViewItem(c.data)).ToArray());
        }

        private void ServiceView_Load(object sender, EventArgs e)
        {
            DrawListView();
            LoadServices();
        }
    }
}
