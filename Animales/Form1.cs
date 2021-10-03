using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Leon leon = new Leon();
            Tigre tigre = new Tigre();
            Gato gato = new Gato();

            Lobo lobo = new Lobo();
            Perro perro = new Perro();


            MessageBox.Show("FELINOS");

            //Leon
            leon.setcomer("El leon casa animales para comer.");
            leon.sethacerRuido("Un Leon de gran tamaño le hace guarrrr");

            MessageBox.Show(leon.getcomer());
            MessageBox.Show(leon.gethacerRuido());

            //Tigre
            tigre.setcomer("El tigre casa animales pequeños para comer carne.");
            tigre.sethacerRuido("Un tigre muy pequeño ruge en la selva");

            MessageBox.Show(tigre.getcomer());
            MessageBox.Show(tigre.gethacerRuido());

            //Gato
            gato.setcomer("El gato come comida Gati, para gatitos.");
            gato.sethacerRuido("Un gatito pequeño y adorale le hace meooowwwww");
            gato.setVacunar("Al gatito le pusieron la primera vacuna de los 2 meses la parvo-virus");

            MessageBox.Show(gato.getcomer());
            MessageBox.Show(gato.gethacerRuido());
            MessageBox.Show(gato.getVacunar());


            MessageBox.Show("CANINOS");

            //Lobo
            lobo.setcomer("Los lobos casan en grupos grandes para comida grande como ciervos, alces, ovejas, cabras, caribúes, bisontes, y muskox.");
            lobo.sethacerRuido("El lobo aullaaa muy fuerte a pesar de ser un lobito chiquito");

            MessageBox.Show(lobo.getcomer());
            MessageBox.Show(lobo.gethacerRuido());

            //Perro
            perro.setcomer("El cachorro come perigri");
            perro.sethacerRuido("El perro grande ladra mucho por las noches");
            perro.setVacunar("Al perrito le pusieron la vacuna de la rabia.");
            perro.setVacunar("Al perri lo sacan a pasear para que haga popo");

            MessageBox.Show(perro.getcomer());
            MessageBox.Show(perro.gethacerRuido());
            MessageBox.Show(perro.getVacunar());
            MessageBox.Show(perro.getsacarPaseo());

        }
    }
}   