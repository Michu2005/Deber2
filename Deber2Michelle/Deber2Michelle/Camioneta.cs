using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Deber2Michelle
{
    public class Camioneta : Vehiculo
    {
        private float _capCarga;

        public float CapacidadCarga
        {
            get => _capCarga;
            set => _capCarga = ValidateCapCarag(value);
        }

        public Camioneta():base() { 
        }

        public Camioneta(string marca, string modelo, int year, float capCarga) : base(marca, modelo, year)
        {
            this.CapacidadCarga = capCarga;
        }

        public override string runAction()
        {
            return "Cargar camioneta";
        }

        public override string getInformation()
        {
            return $"Marca\t\t: {Marca,20}\n" +
                   $"Modelo\t\t:{Modelo,20}\n" +
                   $"Year\t\t:{Year,20}\n" +
                   $"Capacidad\t:{CapacidadCarga,20}";
        }

        private float ValidateCapCarag(float value)
        {
            if (value > 0 && value <= 2.5f)
            {
                return value;
            }
            throw new ArgumentException("La capacidad no es permitida");
        }
    }
}
