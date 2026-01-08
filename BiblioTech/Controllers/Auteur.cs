using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BiblioTech.Models;
using static System.Net.Mime.MediaTypeNames;

namespace BiblioTech.Controllers
{

    internal class Auteur

    {
        private static BiblioTechEntities1 db = new BiblioTechEntities1();

        public  static bool AjoutAuteur( String nom, String bio)
        {
            Models.Auteur a1 = new Models.Auteur() { nom = nom, bio = bio};
            db.Auteur.Add(a1);
            return db.SaveChanges() == 0;
        }

        public Boolean RecupAuteur(String nom)
        {
            string connectionBd =
     @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BiblioTech;Integrated Security=True;";
            string queryGetAuteur = @"SELECT (nom) FROM Auteur";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionBd))
                {
                    using (SqlCommand cmd = new SqlCommand(queryGetAuteur, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public static Models.Auteur RecupAuteurProf(string nom)
        {
            return db.Auteur.SingleOrDefault(x => x.nom == nom);
        }
    }
}

