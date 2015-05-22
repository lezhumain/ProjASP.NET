using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet.Models
{
    public class Livres
    {
        public string Auteur { get; set; }
        public string Titre { get; set; }
        public string Annee { get; set; }
        public string Maison { get; set; }
        public Genre cat { get; set; }
    }
}