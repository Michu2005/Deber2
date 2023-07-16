using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber2Michelle
{
    internal class Automovil : Vehiculo
    {
        private int _numPuertas;

        public int NumPuertas
        { 
            get => _numPuertas;
            set => _numPuertas = ValidatePuertas(value);
        }
        public Automovil():base()
        {

        }
        public Automovil(string marca, string modelo, int year, int numPuertas) : base(marca, modelo, year)
        {
            this.NumPuertas = numPuertas;
        }
        public override string runAction()
        {
            return "Conducir automovil";
        }

        public override string getInformation()
        {
            return $"Marca\t\t: {Marca,20}\n" +
                   $"Modelo\t\t:{Modelo,20}\n" +
                   $"Year\t\t:{Year,20}\n" +
                   $"# Puertas\t:{NumPuertas,20}";
        }

        private int ValidatePuertas(int value)
        {
            if (value > 0 && value <= 5)
            {
                return value;
            }
            throw new ArgumentException($"El número de puertas {value} no es válido");
        }
    }
}
