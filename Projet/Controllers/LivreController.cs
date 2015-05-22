using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projet.Models;

namespace Projet.Controllers
{
    public class LivreController : Controller
    {
        // GET: Livre
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cat(string id)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Roman policier"},
                new Genre { Name = "Histoire"},
                new Genre { Name = "Informatique"},
                new Genre { Name = "Géographie"},
                new Genre { Name = "Philosophie"}
            };
            return View(genres);
        }
        public ActionResult Rea(Genre idcat)
        {
            List<Livres> livres = null;
            string nomcat = idcat.Name;
            switch (nomcat)
            {
                case "Roman policier":
                    livres = new List<Livres>
                    {
                    new Livres {Auteur = "Fred Vargas", Titre ="Temps glaciaires", Annee = "2015", Maison = "Flammarion", cat = idcat},
                    new Livres {Auteur = "Harry Bosch", Titre ="Dans la ville en feu", Annee = "2015", Maison = "Calmann-Levy", cat = idcat},
                    new Livres {Auteur = "Camilla Läckberg", Titre ="La sirène", Annee = "2015", Maison = "Actes Sud", cat = idcat},
                    new Livres {Auteur = "Bernard Minier", Titre ="N'éteins pas la lumière", Annee = "2015", Maison = "Pocket", cat = idcat},
                    new Livres {Auteur = "Arnaldur Indridason", Titre ="Le duel", Annee = "2015", Maison = "Points", cat = idcat}
                    };
                    break;
                case "Histoire":
                    livres = new List<Livres>
                    {
                    new Livres {Auteur = "Mireille Calmel", Titre ="Rihard Coeur de Lion", Annee = "2015", Maison = "Pocket", cat = idcat},
                    new Livres {Auteur = "Françoise Chandernagor", Titre ="Vie de Jude frère de Jésus", Annee = "2015", Maison = "Albin Michel", cat = idcat},
                    new Livres {Auteur = "Marek Halter", Titre ="Fatima", Annee = "2015", Maison = "Robert Laffont", cat = idcat},
                    new Livres {Auteur = "Marek Halter", Titre ="Khadija", Annee = "2014", Maison = "Robert Laffont", cat = idcat},
                    new Livres {Auteur = "Christian Carayon", Titre ="Le diable sur les épaules", Annee = "2013", Maison = "Pocket", cat = idcat}
                    };
                    break;

                case "Geographie":
                    livres = new List<Livres>
                    {
                    new Livres {Auteur = "Gérard Labrune", Titre ="La géographie de la France", Annee = "2014", Maison = "Nathan", cat = idcat},
                    new Livres {Auteur = "Philippe Piercy", Titre ="La France, le fait régional", Annee = "2014", Maison = "Hachette Education", cat = idcat},
                    new Livres {Auteur = "Yannick Clavé", Titre ="Géographie de la France : cours, méthodes, sujets", Annee = "2014", Maison = "Ellipses", cat = idcat},
                    new Livres {Auteur = "Jean-Robert Pitte", Titre ="Histoire du paysage français", Annee = "2014", Maison = "Tallandier", cat = idcat},
                    new Livres {Auteur = "Pierre Merlin", Titre ="L'aménagement du territoire en France", Annee = "2015", Maison = "Documentation Française", cat = idcat}
                    };
                    break;

                case "Philosophie":
                     livres = new List<Livres>
                    {
                    new Livres {Auteur = "Platon", Titre ="La République", Annee = "2014", Maison = "Flammarion", cat = idcat},
                    new Livres {Auteur = "René Descartes", Titre ="Discours de la méthode", Annee = "2014", Maison = "Librio", cat = idcat},
                    new Livres {Auteur = "Aristote", Titre ="Ethique à Nicomaque", Annee = "2014", Maison = "Vrin", cat = idcat},
                    new Livres {Auteur = "T. Hobbes", Titre ="Léviathan", Annee = "2014", Maison = "Folio", cat = idcat},
                    new Livres {Auteur = "Blaise Pascal", Titre ="Pensées", Annee = "2014", Maison = "Seuil", cat = idcat}
                    };
                    break;

                case "Informatique":
                    livres = new List<Livres>
                    {
                    new Livres {Auteur = "Michaël Moritz", Titre ="Le jeu de la pomme", Annee = "1987", Maison = "Denoël", cat = idcat},
                    new Livres {Auteur = "Andy Rathbone", Titre ="Windows 8.1 Pour les nuls", Annee = "2014", Maison = "Nuls en poche", cat = idcat},
                    new Livres {Auteur = "Olivier Le Frapper", Titre ="AutoCAD LT 2015", Annee = "2015", Maison = "Ressources Informatiques", cat = idcat},
                    new Livres {Auteur = "JR Briggs", Titre ="Python pour les kids", Annee = "2015", Maison = "Eyrolles", cat = idcat},
                    new Livres {Auteur = "Olivier Andrieu", Titre ="Réussir son référencement web", Annee = "2015", Maison = "Eyrolles", cat = idcat}
                    };
                    break;

                default:
                    livres = null;
                    break;
            }
            return View(livres);
        }
    }
    
}