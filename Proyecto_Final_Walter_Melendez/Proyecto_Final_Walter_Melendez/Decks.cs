using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Walter_Melendez
{
    internal class Decks
    {
        public Cartas carta1_1 = new Cartas();
        public Cartas carta1_2 = new Cartas();
        public Cartas carta1_3 = new Cartas();
        public Cartas carta1_4 = new Cartas();
        public Cartas carta1_5 = new Cartas();
        public Cartas carta1_6 = new Cartas();
        public Cartas carta1_7 = new Cartas();
        public Cartas carta1_8 = new Cartas();



        public int Danio_Mazo1_1;
        public int Danio_Mazo1_2;
        public int Danio_Mazo3;
        public int Danio_Mazo1_4;

        public int Vida_mazo1;
        public int Vida_mazo2;
        public int Vida_mazo3;
        public int Vida_mazo4;

        public String nombreMazo;
        public String nombreMazo2;
        public String nombreMazo3;
        public String nombreMazo4;

        public double CostoMazo1;
        public double CostoMazo2;
        public double CostoMazo3;
        public double CostoMazo4;

        public double AlcanceMazo1;
        public double AlcanceMazo2;
        public double AlcanceMazo3;
        public double AlcanceMazo4;
        public int Get_Danio()
        {
            Danio_Mazo1_1 = carta1_1.GetDanio() + carta1_2.GetDanio() + carta1_3.GetDanio() + carta1_4.GetDanio() + carta1_5.GetDanio() + carta1_6.GetDanio() + carta1_7.GetDanio() + carta1_8.GetDanio();
            return Danio_Mazo1_1;
        }
        public int Get_Vida()
        {
            Vida_mazo1 = carta1_1.GetVida() + carta1_2.GetVida() + carta1_3.GetVida() + carta1_4.GetVida() + carta1_5.GetVida() + carta1_6.GetVida() + carta1_7.GetVida() + carta1_8.GetVida();
            return Vida_mazo1;
        }
        public String Get_nombre()
        {
            nombreMazo = carta1_1.GetNombre() + carta1_2.GetNombre() + carta1_3.GetNombre() + carta1_4.GetNombre() + carta1_5.GetNombre() + carta1_6.GetNombre() + carta1_7.GetNombre() + carta1_8.GetNombre();
            return nombreMazo;
        }

        public double Get_Costo()
        {
            CostoMazo1 = (carta1_1.GetCosto() + carta1_2.GetCosto() + carta1_3.GetCosto() + carta1_4.GetCosto() + carta1_5.GetCosto() + carta1_6.GetCosto() + carta1_7.GetCosto() + carta1_8.GetCosto()) / 8;
            return CostoMazo1;
        }

        public double Get_Alcance()
        {
            AlcanceMazo1 = carta1_1.GetAlcance() + carta1_2.GetAlcance() + carta1_3.GetAlcance() + carta1_4.GetAlcance() + carta1_5.GetAlcance() + carta1_6.GetAlcance() + carta1_7.GetAlcance() + carta1_8.GetAlcance();
            return AlcanceMazo1;
        }

        public int Get_danio2()//INICIO DE MAZO 2
        {
            Danio_Mazo1_2 = carta1_1.GetDanio() + carta1_2.GetDanio() + carta1_3.GetDanio() + carta1_4.GetDanio() + carta1_5.GetDanio() + carta1_6.GetDanio() + carta1_7.GetDanio() + carta1_8.GetDanio();
            return Danio_Mazo1_2;
        }

        public int Get_Vida2()
        {
            Vida_mazo2 = carta1_1.GetVida() + carta1_2.GetVida() + carta1_3.GetVida() + carta1_4.GetVida() + carta1_5.GetVida() + carta1_6.GetVida() + carta1_7.GetVida() + carta1_8.GetVida();
            return Vida_mazo2;
        }

        public String Get_Nombre2()
        {
            nombreMazo2 = carta1_1.GetNombre() + carta1_2.GetNombre() + carta1_3.GetNombre() + carta1_4.GetNombre() + carta1_5.GetNombre() + carta1_6.GetNombre() + carta1_7.GetNombre() + carta1_8.GetNombre();
            return nombreMazo2;
        }

        public double Get_Costo2()
        {
            CostoMazo2 = (carta1_1.GetCosto() + carta1_2.GetCosto() + carta1_3.GetCosto() + carta1_4.GetCosto() + carta1_5.GetCosto() + carta1_6.GetCosto() + carta1_7.GetCosto() + carta1_8.GetCosto()) / 8;

            return CostoMazo2;
        }

        public double Get_Alcance2() //FIN MAZO 2
        {
            AlcanceMazo2 = carta1_1.GetAlcance() + carta1_2.GetAlcance() + carta1_3.GetAlcance() + carta1_4.GetAlcance() + carta1_5.GetAlcance() + carta1_6.GetAlcance() + carta1_7.GetAlcance() + carta1_8.GetAlcance();
            return AlcanceMazo2;
        }

        public int Get_Danio_Mazo3()
        {
            Danio_Mazo3 = carta1_1.GetDanio() + carta1_2.GetDanio() + carta1_3.GetDanio() + carta1_4.GetDanio() + carta1_5.GetDanio() + carta1_6.GetDanio() + carta1_7.GetDanio() + carta1_8.GetDanio();
            return Danio_Mazo3;
        }

        public int Get_Vida_Mazo3()
        {
            Vida_mazo3 = carta1_1.GetVida() + carta1_2.GetVida() + carta1_3.GetVida() + carta1_4.GetVida() + carta1_5.GetVida() + carta1_6.GetVida() + carta1_7.GetVida() + carta1_8.GetVida();
            return Vida_mazo3;
        }

        public String Get_Nombre()
        {
            nombreMazo3 = carta1_1.GetNombre() + carta1_2.GetNombre() + carta1_3.GetNombre() + carta1_4 + carta1_5.GetNombre() + carta1_6.GetNombre() + carta1_7 + carta1_8.GetNombre();
            return nombreMazo3;
        }
        public double Get_CostoMazo3()
        {
            CostoMazo3 = (carta1_1.GetCosto() + carta1_2.GetCosto() + carta1_3.GetCosto() + carta1_4.GetCosto() + carta1_5.GetCosto() + carta1_6.GetCosto() + carta1_7.GetCosto() + carta1_8.GetCosto()) / 8;
            return CostoMazo3;
        }

        public double Get_Alcance3()    //FIN MAZO 3
        {

            AlcanceMazo3 = carta1_1.GetAlcance() + carta1_2.GetAlcance() + carta1_3.GetAlcance() + carta1_4.GetAlcance() + carta1_5.GetAlcance() + carta1_6.GetAlcance() + carta1_7.GetAlcance() + carta1_8.GetAlcance();
            return AlcanceMazo3;
        }

        public int Get_Danio4()
        {
            Danio_Mazo1_4 = carta1_1.GetDanio() + carta1_2.GetDanio() + carta1_3.GetDanio() + carta1_4.GetDanio() + carta1_5.GetDanio() + carta1_6.GetDanio() + carta1_7.GetDanio() + carta1_8.GetDanio();
            return Danio_Mazo1_4;
        }

        public int Get_vida4()
        {
            Vida_mazo4 = carta1_1.GetVida() + carta1_2.GetVida() + carta1_3.GetVida() + carta1_4.GetVida() + carta1_5.GetVida() + carta1_6.GetVida() + carta1_7.GetVida() + carta1_8.GetVida();
            return Vida_mazo4;
        }

        public String Get_nombre4() {
            nombreMazo4 = carta1_1.GetNombre() + carta1_2.GetNombre() + carta1_3.GetNombre() + carta1_4.GetNombre() + carta1_5.GetNombre() + carta1_6.GetNombre() + carta1_7.GetNombre() + carta1_8.GetNombre();
            return nombreMazo4;
        }

        public double Get_costo4() {
            CostoMazo4 = (carta1_1.GetCosto() + carta1_2.GetCosto() + carta1_3.GetCosto() + carta1_4.GetCosto() + carta1_5.GetCosto() + carta1_6.GetCosto() + carta1_7.GetCosto() + carta1_8.GetCosto()) /8;
            return CostoMazo4;
        }

        public double Get_alcance4() {
            AlcanceMazo4 = carta1_1.GetAlcance() + carta1_2.GetAlcance() + carta1_3.GetAlcance() + carta1_4.GetAlcance() + carta1_5.GetAlcance() + carta1_6.GetAlcance() + carta1_7.GetAlcance() + carta1_8.GetAlcance();
            return AlcanceMazo4;
        }
    }

}
