using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercice_fromulaire_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        private bool ajouterBTNwasClicked = false;
        private bool modifierBTNwasClicked = false;
        private bool supprimerBTNwasClicked = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.select_Combobox(idCombobox);

            ajouterBTN.Enabled = true;
            modifierBTN.Enabled = false;
            supprimerBTN.Enabled = false;
            confirmerBTN.Enabled = false;
            annulerBTN.Enabled = false;
            nomTextbox.Enabled = false;
            prenomTextBox.Enabled = false;
            idCombobox.Enabled = true;
            villeTextBox.Enabled = false;

        }

        private void ajouterBTN_Click(object sender, EventArgs e)
        {
            ajouterBTNwasClicked = true;

            modifierBTN.Enabled = false;
            supprimerBTN.Enabled = false;
            ajouterBTN.Enabled = false;
            nomTextbox.Enabled = true;
            prenomTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            idCombobox.Enabled = true;

        }

        private void nomTextbox_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void villeTextBox_TextChanged(object sender, EventArgs e)
        {
            setButton();
        }

        private void setButton()
        {
            confirmerBTN.Enabled = (nomTextbox.Text != "") && (prenomTextBox.Text != "") && (villeTextBox.Text != "");
            annulerBTN.Enabled = (nomTextbox.Text != "") && (prenomTextBox.Text != "") && (villeTextBox.Text != "");
        }

        private void confirmerBTN_Click(object sender, EventArgs e)
        {
            if (ajouterBTNwasClicked == true)
            {
                client c = new client();
                c.id = Int32.Parse(idCombobox.Text);
                c.nom = nomTextbox.Text;
                c.prenom = prenomTextBox.Text;
                c.ville = villeTextBox.Text;
                connection.ajouter(c);
                nomTextbox.Text = c.nom;
                prenomTextBox.Text = c.prenom;
                villeTextBox.Text = c.ville;
                idCombobox.Items.Add(c.id);
                ajouterBTNwasClicked = false;
            }
            else if (modifierBTNwasClicked == true)
            {
                idCombobox.Items.Remove(idCombobox.SelectedItem);
                client c = new client();
                c.id = Int32.Parse(idCombobox.Text);
                c.nom = nomTextbox.Text;
                c.ville = villeTextBox.Text;
                c.prenom = prenomTextBox.Text;
                connection.modifier(c);
                modifierBTNwasClicked = false;
            }
            else if (supprimerBTNwasClicked == true)
            {
                connection.supprimer(idCombobox.Text);
                supprimerBTNwasClicked = false;
            }
        }

        private void annulerBTN_Click(object sender, EventArgs e)
        {

                idCombobox.Text = "";
                nomTextbox.Text = "";
                prenomTextBox.Text = "";
                villeTextBox.Text = "";
            
        }

        private void idCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifierBTN.Enabled = true;
            supprimerBTN.Enabled = true;
            nomTextbox.Enabled = true;
            prenomTextBox.Enabled = true;
            villeTextBox.Enabled = true;
        }

        private void modifierBTN_Click(object sender, EventArgs e)
        {
            nomTextbox.Enabled = true;
            prenomTextBox.Enabled = true;
            villeTextBox.Enabled = true;
            confirmerBTN.Enabled = true;
            annulerBTN.Enabled = true;
        }

        private void supprimerBTN_Click(object sender, EventArgs e)
        {
            supprimerBTNwasClicked = true;
            confirmerBTN.Enabled = true;
            annulerBTN.Enabled = true;
        }
    }
}
