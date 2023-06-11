using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections;
using GesB.models;
using System.IO;


namespace GesB.models
{
    public class Comptes
    {
        public static List<CompteCourant> aComptes = new List<CompteCourant>();
        public static List<Client> aClients = new List<Client>();
        public static List<VirementsComptes> aVirements = new List<VirementsComptes>();

        // Méthode de chagement des données au démarrage de l'application

        public static void chargerDonnees()
        {
            try
            {
                if (File.Exists(@"GesB_clients.xml"))        //s'il existe un fichier un fichier de gestion de clients
                {
                    using (StreamReader reader = new StreamReader(@"GesB_clients.xml"))      //et on initie le flux de lecture pour lire le fichier
                    {
                        if (!reader.EndOfStream)                                                          //si on n'est pas en fin de fichier
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>));         //on instancie un objet de désérialisation
                            Comptes.aClients = (List<Client>) deserializer.Deserialize(reader);           //on désérialise les obets du fichier xml et on les cast en liste de client
                            reader.Close();                                                               //on ferme le flux de lecture de données
                            reader.Dispose();                                                             //et on le détruit.
                        }
                        else                                                //si on est en fin de fichier
                        {
                            reader.Close();                                 //on ferme le flux de lecture
                            reader.Dispose();                               //et on le détruit
                        }
                    }
                }
                if (File.Exists(@"GesB_comptes.xml"))                                                            //on répète exactement la même procédure 
                {                                                                                               //que pour les clients
                    using (StreamReader reader = new StreamReader(@"GesB_comptes.xml"))
                    {
                        if (!reader.EndOfStream)
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<CompteCourant>));
                            Comptes.aComptes = (List<CompteCourant>) deserializer.Deserialize(reader);
                            reader.Close();
                            reader.Dispose();
                        }
                        else
                        {
                            reader.Close();
                            reader.Dispose();
                        }
                    }
                }
                if (File.Exists(@"GesB_virements.xml"))
                {
                    using (StreamReader reader = new StreamReader(@"GesB_virements.xml"))
                    {
                        if (!reader.EndOfStream)
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<VirementsComptes>));
                            Comptes.aVirements = (List<VirementsComptes>) deserializer.Deserialize(reader);
                            reader.Close();
                            reader.Dispose();
                        }
                        else
                        {
                            reader.Close();
                            reader.Dispose();
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode de sauvegarde des données dans des fichiers xml

        public static void sauvegarderDonnees()
        {
            try
            {
                if (Comptes.aClients.Count != 0)
                {
                    if (!File.Exists(@"GesB_clients.xml"))
                    {
                        File.Create(@"GesB_clients.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_clients.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aClients);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_clients.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aClients);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                }

                if (Comptes.aComptes.Count != 0)
                {
                    if (!File.Exists(@"GesB_comptes.xml"))
                    {
                        File.Create(@"GesB_comptes.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_comptes.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aComptes);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_comptes.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aComptes);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                }

                if (Comptes.aVirements.Count != 0)
                {
                    if (!File.Exists(@"GesB_virements.xml"))
                    {
                        File.Create(@"GesB_virements.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<VirementsComptes>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_virements.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aVirements);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<VirementsComptes>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_virements.xml"))
                        {
                            serializer.Serialize(writer, Comptes.aVirements);
                            writer.Close();
                            writer.Dispose();
                        }
                    }
                }
                MessageBox.Show("Toutes les données ont été enregistrées avec succès!","Sauvegarde réussie",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
