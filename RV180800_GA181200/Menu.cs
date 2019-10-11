using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RV180800_GA181200
{
    public partial class Menu : Form
    {
        Bomba bomba = new Bomba();
        private List<Bomba> bombas = new List<Bomba>();
        private int edit_indice = -1;
        public Menu()
        {
            InitializeComponent();
            int numero = 1;
            for (int i = 0; i <= 6; i++)
            {
                Bomba bomba = new Bomba();
                bomba.ID = numero;
                bomba.Nombre = "Bomba " + numero;
                bomba.Saldo = 0;
                bomba.Especial = 600;
                bomba.Regular = 800;
                bomba.Disel = 800;
                bomba.MontoEspecial = 0;
                bomba.MontoRegular = 0;
                bomba.MontoDisel = 0;
                numero++;
                if (edit_indice > -1)
                {
                    bombas[edit_indice] = bomba;
                    edit_indice = -1;
                }
                else
                {
                    bombas.Add(bomba);

                }

            }
           


        }
       
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     
             void bomba1()
            {
                var result = bombas.Where(x => x.ID == 1).ToList();
                foreach (var item in result)
                {
                    txt1b1.Text = item.Especial.ToString();
                    txt2b1.Text = item.Regular.ToString();
                    txt3b1.Text = item.Disel.ToString();

                }
            }
             void bomba2()
            {
                var result = bombas.Where(x => x.ID == 2).ToList();
                foreach (var item in result)
                {
                    txt1b2.Text = item.Especial.ToString();
                    txt2b2.Text = item.Regular.ToString();
                    txt3b2.Text = item.Disel.ToString();

                }
            }
             void bomba3()
            {
                var result = bombas.Where(x => x.ID == 3).ToList();
                foreach (var item in result)
                {
                    txt1b3.Text = item.Especial.ToString();
                    txt2b3.Text = item.Regular.ToString();
                    txt3b3.Text = item.Disel.ToString();

                }
            }
             void bomba4()
            {
                var result = bombas.Where(x => x.ID == 4).ToList();
                foreach (var item in result)
                {
                    txt1b4.Text = item.Especial.ToString();
                    txt2b4.Text = item.Regular.ToString();
                    txt3b4.Text = item.Disel.ToString();

                }
            }
            void bomba5()
            {
                var result = bombas.Where(x => x.ID == 5).ToList();
                foreach (var item in result)
                {
                    txt1b5.Text = item.Especial.ToString();
                    txt2b5.Text = item.Regular.ToString();
                    txt3b5.Text = item.Disel.ToString();

                }
            }
             void bomba6()
            {
                var result = bombas.Where(x => x.ID == 6).ToList();
                foreach (var item in result)
                {
                    txt1b6.Text = item.Especial.ToString();
                    txt2b6.Text = item.Regular.ToString();
                    txt3b6.Text = item.Disel.ToString();

                }
            }
        
        private void Menu_Load(object sender, EventArgs e)
        {

            bomba1();
            bomba2();
            bomba3();
            bomba4();
            bomba5();
            bomba6();
        }
        
        










}
}
