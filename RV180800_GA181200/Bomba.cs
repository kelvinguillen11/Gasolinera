using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RV180800_GA181200
{
    class Bomba
    {
        private string nombre; 
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private decimal saldo; 
        public decimal Saldo 
        {
            get { return saldo; }
            set { saldo = value; }
        }        private double especial;
        public double Especial
        {
            get { return especial; }
            set { especial = value; }
        }
        private double regular;
        public double Regular
        {
            get { return regular; }
            set { regular = value; }
        }
        private double disel;
        public double Disel
        {
            get { return disel; }
            set { disel = value; }
        }
        private decimal montoEspecial;
        public decimal MontoEspecial
        {
            get { return montoEspecial; }
            set { montoEspecial = value; }
        }
        private decimal montoRegular;
        public decimal MontoRegular
        {
            get { return montoRegular; }
            set { montoRegular = value; }
        }
        private decimal montoDisel;
        public decimal MontoDisel
        {
            get { return montoDisel; }
            set { montoDisel = value; }
        }
    }
}
