using FakultetBussinessLayer;
using FakultetDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class Form1 : Form
    {
        private readonly FakultetBussiness fakultetBussiness;
        public Form1()
        {
            this.fakultetBussiness = new FakultetBussiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxIme.Select();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
          
            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string lozinka = textBoxLozinka.Text;


            if (textBoxIme.Text != "" && textBoxPrezime.Text != "" && textBoxLozinka.Text != "" && textBoxLozinka.Text == "admin") 
            {
                List<Profesor> profesors = this.fakultetBussiness.GetProfesors();
                Profesor p = new Profesor();
                foreach (Profesor pr in profesors)
                {
                    if (ime != p.Ime && prezime != p.Prezime)
                    {
                        p.Ime = textBoxIme.Text;
                        p.Prezime = textBoxPrezime.Text;
                        bool result = this.fakultetBussiness.InsertProfesor(p);
                    }
                }
                MessageBox.Show("Uspesno ste se ulogovali!");
                Form2 frm = new Form2();
                frm.Show();
            }

            else
            {
                MessageBox.Show("Pokusajte ponovo!");
                textBoxIme.Clear();
                textBoxPrezime.Clear();
                textBoxLozinka.Clear();
            }


        }

        public class Form2 : Form
        {
            public Form2()
            {
                Text = "Form2";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
