using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{

    // Class Father
    class Animal
    {
        // Create Properties

        private string _foto { get; set; }
        private string _comida { get; set; }
        private string _localizacion { get; set; }
        private string _tamano { get; set; }


        // Create Methods

        public string gethacerRuido()
        {
            return _tamano;
        }
        public void sethacerRuido(string Tamano)
        {
            _tamano = Tamano;
        }

        public string getcomer()
        {
            return _comida;
        }
        public void setcomer(string Comida)
        {
            _comida = Comida;
        }

        public string getdormir()
        {
            return _foto;
        }

        public void setdormir(string Foto)
        {
            _foto = Foto;
        }

        public string getrugir()
        {
            return _localizacion;
        }

        public void setrugir(string Localizacion)
        {
            _localizacion = Localizacion;
        }
    }
}
