using PPE3.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using System.Security.Cryptography.X509Certificates;
using iText.Layout.Properties;

namespace PPE3
{
    public partial class OrdonnanceView : Form
    {
        string genre = "";
        Ordonnance ordonnance;
        internal OrdonnanceView(Ordonnance ordonnance)
        {
            InitializeComponent();
            this.ordonnance = ordonnance;
            NomMedecinLabel.Text = "Docteur " + ordonnance.Medecin.Nom;

            if (ordonnance.Patient.Sexe == "h")
            {
                genre = "Monsieur";
            }
            else if (ordonnance.Patient.Sexe == "f")
            {
                genre = "Madame";
            }
            PatientLabel.Text = genre + " " + ordonnance.Patient.Nom + " " + ordonnance.Patient.Prenom;

            DateLabel.Text = "Le " + ordonnance.Date_creation.Day + " " + ordonnance.Date_creation.Month + " " + ordonnance.Date_creation.Year;

            MedicamentLabel.Text = ordonnance.Medicament.Libelle + ", " + ordonnance.Posologie + " - " + ordonnance.Instruction + " " + ordonnance.Duree + " jours";
        }
        // Permet d'enregistrer l'ordonnance au format PDF
        private void print_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // Donne un nom par défaut au fichier qui sera enregistrer
            saveFileDialog.FileName = "Ordonnance_" + ordonnance.Patient.Nom + "_" + ordonnance.Patient.Prenom + "_" + ordonnance.Date_creation.Year.ToString() + "_" + ordonnance.Date_creation.Month.ToString() + "_" + ordonnance.Date_creation.Day.ToString();
            // Permet d'afficher seulement les fichiers pdf lors de l'enregistrement
            saveFileDialog.Filter = "PDF Files|*.pdf";
            // Le fichier sera enristrer au format pdf par défaut
            saveFileDialog.DefaultExt = "pdf";
            // l'emplacement par défaut sera le dossier téléchargement de l'utilisateur
            saveFileDialog.InitialDirectory = @"%Download%";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // enregistre dans une variable l'emplacement et le nom du fichier à enregistrer
                string fileName = Path.GetFullPath(saveFileDialog.FileName);

                using (PdfWriter writer = new PdfWriter(fileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Création d'objet Paragraph destiné à etre ajouté dans l'ordonnance
                        Paragraph medecinNom = new Paragraph("Docteur " + ordonnance.Medecin.Nom);
                        Paragraph patientNom = new Paragraph(genre + " " + ordonnance.Patient.Nom + " " + ordonnance.Patient.Prenom);
                        Paragraph date = new Paragraph("Le " + ordonnance.Date_creation.Day + " " + ordonnance.Date_creation.Month + " " + ordonnance.Date_creation.Year);
                        Paragraph medic = new Paragraph(ordonnance.Medicament.Libelle + ", " + ordonnance.Posologie + " - " + ordonnance.Instruction + " " + ordonnance.Duree + " jours");

                        // ajout des différents paragraphe dans l'ordonnance avec leurs emplacements
                        document.Add(medecinNom.SetTextAlignment(TextAlignment.LEFT));
                        document.Add(date.SetTextAlignment(TextAlignment.RIGHT));
                        document.Add(patientNom.SetTextAlignment(TextAlignment.LEFT));
                        document.Add(medic.SetTextAlignment(TextAlignment.LEFT));

                        // Enregistrement du PDF
                        document.Close();
                    }
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
