using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    //Class child to Felino
    class Gato : Felino 
    {

        private string _vacuna { get; set; }

        public string getVacunar()
        {
            return _vacuna;
        }

        public void setVacunar(string Vacuna)
        {
            _vacuna = Vacuna;
        }
    }
}
