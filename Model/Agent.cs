using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveManagerApp.Model
{
    public class Agent : ModelBase
    {
        public Agent()
        {
            CurrentAffectation = new Affectation() { Agent = this};
        }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string PostNom { get; set; }
        public string Sexe { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public byte[] Photo { get; set; }
        public string Fonction { get; set; }
        public string Grade { get; set; }

        public Affectation CurrentAffectation { get; set; }

        public string Name
        {
            get => Prenom + " " + Nom + " " + PostNom;
        }

        public override string ToString()
        {
            return Name;
        }

        public string[] data
        {
            get => new string[] { NumberRow.ToString(), Name, Sexe, Phone, Email, Grade + "" + Fonction  , CurrentAffectation.Service.ToString()};
        }
    }
}
