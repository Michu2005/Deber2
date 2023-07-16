using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber2Michelle
{
    public class Vehiculo
    {
        private string? _marca;
        private string? _modelo;
        private int _year;

        public string Marca
        {
            get => _marca;
            set => _marca = ValidateString("Marca", value);
        }
        public string Modelo
        {
            get => _modelo;
            set => _modelo = ValidateString("Modelo",value);
        }
        public int Year
        {
            get => _year;
            set => _year = ValidateYear(value);
        }

        public Vehiculo()
        {

        }

        public Vehiculo(string? marca, string? modelo, int year)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Year = year;
        }

        public virtual string getInformation()
        {
            return $"Marca\t\t: {Marca,20}\n" +
                   $"Modelo\t\t:{Modelo,20}\n" +
                   $"Year\t\t:{Year,20}";
        }

        public virtual string runAction()
        {
            return "Mensaje generico runAction";
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new ArgumentException("Año no valido");
        }

        private string ValidateString(string nombre,string dato)
        {
            if (!string.IsNullOrEmpty(dato))
            {
                return dato;
            }
            throw new ArgumentException($"{nombre} no es valido");
        }
    }
}
