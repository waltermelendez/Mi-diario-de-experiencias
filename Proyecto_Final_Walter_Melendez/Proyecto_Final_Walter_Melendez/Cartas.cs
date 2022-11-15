using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Walter_Melendez
{
    internal class Cartas
    {
        public int Danio;
        public int Vida;
        public string Nombre;
        public double Costo;
        public double Alcance;

        public void SetDanio(int danio)
        {
            this.Danio = danio;

        }
        public void SetVida(int vida)
        {
            this.Vida = vida;
        }
        public void SetNombre(string nombre)
        {
            this.Nombre = nombre;
        }
        public string GetNombre()
        {

            return this.Nombre;
        }
        public int GetDanio()
        {
            return this.Danio;
        }
        public int GetVida()
        {
            return this.Vida;
        }
        public void SetAlcance(double alcance)
        {
            this.Alcance = alcance;
        }

        public double GetAlcance()
        {
            return this.Alcance;
        }

        public void SetCosto(double costo) { 
        this.Costo = costo; 
        }

        public double GetCosto() { 
        
        return this.Costo;
        }

    }
}
