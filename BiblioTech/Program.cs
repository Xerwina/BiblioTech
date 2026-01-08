using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Controllers;
using BiblioTech.Models;

namespace BiblioTech
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String nom;
            // String bio;

            // Console.WriteLine("rentre un ptn d'auteur");
            // nom = Console.ReadLine();

            // Console.WriteLine("rentre une bio");
            // bio = Console.ReadLine();

            //Controllers.Auteur a1 = new Controllers.Auteur();
            //a1.AjoutAuteur(nom, bio);

            if(Controllers.Auteur.AjoutAuteur("titi", "tutu"))
                Console.WriteLine("Nouvel Auteur");
            else
                Console.WriteLine("Nop ! Pas envie");


            Console.WriteLine("Recherche un auteur");
            Console.Write("Nom de l'auteur : ");
            string auteurName = Console.ReadLine();
            Models.Auteur aut = Controllers.Auteur.RecupAuteurProf(auteurName);
            if (aut != null)
                Console.WriteLine("Auteur trouvé");
            else
                Console.WriteLine("Nop");
            //Controllers.Auteur getAuteur = new Controllers.Auteur();
            //getAuteur = Console.ReadLine();
            //Console.WriteLine(getAuteur.RecupAuteur());





        }
    }
}
