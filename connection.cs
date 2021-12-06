using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercice_fromulaire_DB
{
    class connection
    {
        static string chaine = "Data Source=DESKTOP-GISQPTU;Initial Catalog=form;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //methode d'ajout
        public static void ajouter(client c)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into dbo.personne_table values('" + c.id + "','" + c.nom + "','" + c.prenom + "','" + c.ville + "') ";
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("insertion done");
            }
            else
            {
                MessageBox.Show("erreur", "aucune ligne n'est insere", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //methode de modification 

        public static void modifier(client c)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update dbo.personne_table set nom = '" + c.nom + "',prenom='" + c.prenom + "',adresse='" + c.ville + "' where id = '" + c.id + "' ";
            int queryResult = cmd.ExecuteNonQuery();
            if (queryResult == 1)
            {
                MessageBox.Show("modification bien effectue");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("erreur ", "aucune ligne n'est modifiee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
            }

        }

        ////
        public static void supprimer(string id)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from dbo.personne_table where id = '" + id + "' ";
            int queryResult = cmd.ExecuteNonQuery();
            if (queryResult == 1)
            {
                MessageBox.Show("suppression bien effectue");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("erreur ", "aucune ligne n'est supprimee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
            }

        }

        //

        public static void select_Combobox(ComboBox idCombobox)
        {
            client c = new client();
            cnx.Open();
            try
            {
                string query = "select id,nom,prenom,ville from dbo.personne_table";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    c.id = Int32.Parse(myreader[0].ToString());
                    idCombobox.Items.Add(c.id);
                }

                myreader.Close();

            }

            catch (SqlException err)
            {
                MessageBox.Show(err.Message);
            }

            finally
            {
                cnx.Close();
            }
        }

    }
}
