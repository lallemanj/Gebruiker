using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericStapelOef1
{
    public partial class Form1 : Form
    {

        Stapel<int> intStapel = new Stapel<int>();
        Stapel<string> StringStapel = new Stapel<string>();
        Stapel<KleineKlasse> KlasseStapel = new Stapel<KleineKlasse>();




        public Form1()
        {
            InitializeComponent();
        }

        // ------------------------------------ Integer ---------------------------------

        private void btn_Int_Toevoegen_Click(object sender, EventArgs e)
        {
            intStapel.toevoegenStapel(int.Parse(tbInt.Text));
        }

        private void btn_Int_Verwijderen_Click(object sender, EventArgs e)
        {
            int? uitkomst = intStapel.verwijderenStapel();
            tbInt.Text = uitkomst.HasValue ? uitkomst.Value.ToString() : "Lege Rij";
        }

        private void btn_Int_Leegmaken_Click(object sender, EventArgs e)
        {
            intStapel.leegmakenStapel();
        }

        private void btn_Int_ToStr_Click(object sender, EventArgs e)
        {
            tbStack.Text = intStapel.ToString();
    }

        private void btn_Int_Aanwezig_Click(object sender, EventArgs e)
        {
            
            int check = int.Parse(tbInt.Text);
            if (intStapel.IsAanwezig(check) == true)
            {
                MessageBox.Show(check.ToString() + " is aanwezig");
            }
            else
            {
                MessageBox.Show(check.ToString() + " is niet aanwezig");

            }
        }

        private void btn_Int_Copy_Click(object sender, EventArgs e)
        {
            //intStapel.CopyTo(int[] intS, 0);
            //Stapel<T> stepel = intStapel.Copy(intStapel, stepel);
        }


        // ------------------------------- String -----------------------------------

        private void btn_String_Toevoegen_Click(object sender, EventArgs e)
        {
            StringStapel.toevoegenStapel(tbStr.Text);

        }

        private void btn_String_Verwijderen_Click(object sender, EventArgs e)
        {
            string? uitkomst = StringStapel.verwijderenStapel();
            tbStr.Text = uitkomst.ToString();
        }

        private void btn_String_Leegmaken_Click(object sender, EventArgs e)
        {
            StringStapel.leegmakenStapel();
        }

        private void btn_String_ToStr_Click(object sender, EventArgs e)
        {
            tbStack.Text = StringStapel.ToString();

        }

        private void btn_String_Aanwezig_Click(object sender, EventArgs e)
        {
            string check = tbStr.Text;
            if(StringStapel.IsAanwezig(check) == true)
            {
                MessageBox.Show(check + " is aanwezig");
            } else
            {
                MessageBox.Show(check + " is niet aanwezig");

            }

        }

        private void btn_String_Copy_Click(object sender, EventArgs e)
        {

        }

        // ---------------------------------- KleineKlasse --------------------------

        private void btn_Klasse_Toevoegen_Click(object sender, EventArgs e)
        {
            
            
            KlasseStapel.toevoegenStapel(new KleineKlasse(KleineKlasse.Id, tbKlasse.Text));

        }

        private void btn_Klasse_Verwijderen_Click(object sender, EventArgs e)
        {
            KleineKlasse? uitkomst = KlasseStapel.verwijderenStapel();
            tbKlasse.Text = uitkomst.ToString();
        }

        private void btn_Klasse_Leegmaken_Click(object sender, EventArgs e)
        {
            KlasseStapel.leegmakenStapel();
        }

        private void btn_Klasse_ToStr_Click(object sender, EventArgs e)
        {
            tbStack.Text = KlasseStapel.ToString();

        }

        private void btn_Klasse_Aanwezig_Click(object sender, EventArgs e)
        {
          
            KleineKlasse? check = (new KleineKlasse (KleineKlasse.Id, tbKlasse.Text));
            if (KlasseStapel.IsAanwezig(check) == true)
            {
                MessageBox.Show(check + " is aanwezig");
            }
            else
            {
                MessageBox.Show(check + " is niet aanwezig");

            }

        }

        private void btn_Klasse_Copy_Click(object sender, EventArgs e)
        {

        }
    }
}
