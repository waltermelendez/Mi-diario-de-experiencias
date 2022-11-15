using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Walter_Melendez
{
    public partial class Form1 : Form
    {


        Decks mazo1_P1 = new Decks();
        Decks mazo2_P1 = new Decks();
        Decks mazo1_P2 = new Decks();
        Decks mazo2_P2 = new Decks();

        public Form1()
        {
            InitializeComponent();

            mazo1_P1.carta1_1.SetDanio(74);//puercos
            mazo1_P1.carta1_2.SetDanio(120);//duendes
            mazo1_P1.carta1_3.SetDanio(207);//espiritu f
            mazo1_P1.carta1_4.SetDanio(212);//cañon
            mazo1_P1.carta1_5.SetDanio(218);//mosquetera
            mazo1_P1.carta1_6.SetDanio(689);//bola f
            mazo1_P1.carta1_7.SetDanio(477);//flechas
            mazo1_P1.carta1_8.SetDanio(261);//fantasma.
            //FIN DAÑO

            mazo1_P1.carta1_1.SetVida(837);//puercos
            mazo1_P1.carta1_2.SetVida(202);//duendes
            mazo1_P1.carta1_3.SetVida(230);//espiritu f
            mazo1_P1.carta1_4.SetVida(824);//cañon
            mazo1_P1.carta1_5.SetVida(720);// mosquetera
            mazo1_P1.carta1_6.SetVida(0);//bola f
            mazo1_P1.carta1_7.SetVida(0);//flechas
            mazo1_P1.carta1_8.SetVida(1210);  //fantasma
                                              //FIN VIDA

            mazo1_P1.carta1_1.SetNombre("Puercos Reales");
            mazo1_P1.carta1_2.SetNombre("Duendes");
            mazo1_P1.carta1_3.SetNombre("Espíritu de fuego");
            mazo1_P1.carta1_4.SetNombre("Cañon");
            mazo1_P1.carta1_5.SetNombre("Mosquetera");
            mazo1_P1.carta1_6.SetNombre("Bola de fuego");
            mazo1_P1.carta1_7.SetNombre("Flechas");
            mazo1_P1.carta1_8.SetNombre("Fantasma real");
            lbl_DT1_1.Text = mazo1_P1.Get_Danio().ToString();
            lbl_VTmazo1_1.Text = mazo1_P1.Get_Vida().ToString();

            mazo1_P1.carta1_1.SetCosto(5);
            mazo1_P1.carta1_2.SetCosto(2);
            mazo1_P1.carta1_3.SetCosto(1);
            mazo1_P1.carta1_4.SetCosto(3);
            mazo1_P1.carta1_5.SetCosto(4);
            mazo1_P1.carta1_6.SetCosto(4);
            mazo1_P1.carta1_7.SetCosto(3);
            mazo1_P1.carta1_8.SetAlcance(3);
            CP_1_1.Text = mazo1_P1.Get_Costo().ToString();

            mazo1_P1.carta1_1.SetAlcance(0);
            mazo1_P1.carta1_2.SetAlcance(0);
            mazo1_P1.carta1_3.SetAlcance(2);
            mazo1_P1.carta1_4.SetAlcance(5.5);
            mazo1_P1.carta1_5.SetAlcance(6);
            mazo1_P1.carta1_6.SetAlcance(2.5);
            mazo1_P1.carta1_7.SetAlcance(1.4);
            mazo1_P1.carta1_8.SetAlcance(0);
            lblalcance_mazo_1_1.Text = mazo1_P1.Get_Alcance().ToString(); // FIN MAZO 1

            mazo2_P1.carta1_1.SetNombre("Motapuercos");
            mazo2_P1.carta1_2.SetNombre("Duendes de lanza");
            mazo2_P1.carta1_3.SetNombre("Mini P.E.K.K.A");
            mazo2_P1.carta1_4.SetNombre("El tronco");
            mazo2_P1.carta1_5.SetNombre("Lanzafeugos");
            mazo2_P1.carta1_6.SetNombre("Terremoto");
            mazo2_P1.carta1_7.SetNombre("Esqueletos");
            mazo2_P1.carta1_8.SetNombre("Torre bombardera");

            mazo2_P1.carta1_1.SetDanio(1696);// monta
            mazo2_P1.carta1_2.SetDanio(81); //duende l
            mazo2_P1.carta1_3.SetDanio(720); //mini
            mazo2_P1.carta1_4.SetDanio(348); // tronco
            mazo2_P1.carta1_5.SetDanio(64); //lanza f
            mazo2_P1.carta1_6.SetDanio(423); //terremto
            mazo2_P1.carta1_7.SetDanio(81);// esquletos
            mazo2_P1.carta1_8.SetDanio(444); // torre b

            mazo2_P1.carta1_1.SetVida(1696);
            mazo2_P1.carta1_2.SetVida(133);
            mazo2_P1.carta1_3.SetVida(1361);
            mazo2_P1.carta1_4.SetVida(0);
            mazo2_P1.carta1_5.SetVida(304);
            mazo2_P1.carta1_6.SetVida(0);
            mazo2_P1.carta1_7.SetVida(81);
            mazo2_P1.carta1_8.SetVida(1356);

            mazo2_P1.carta1_1.SetAlcance(0);
            mazo2_P1.carta1_2.SetAlcance(5);
            mazo2_P1.carta1_3.SetAlcance(0);
            mazo2_P1.carta1_4.SetAlcance(10.1);
            mazo2_P1.carta1_5.SetAlcance(6);
            mazo2_P1.carta1_6.SetAlcance(3.5);
            mazo2_P1.carta1_7.SetAlcance(0);
            mazo2_P1.carta1_8.SetAlcance(6);

            mazo2_P1.carta1_1.SetCosto(4);
            mazo2_P1.carta1_2.SetCosto(2);
            mazo2_P1.carta1_3.SetCosto(4);
            mazo2_P1.carta1_4.SetCosto(2);
            mazo2_P1.carta1_5.SetCosto(3);
            mazo2_P1.carta1_6.SetCosto(3);
            mazo2_P1.carta1_7.SetCosto(1);
            mazo2_P1.carta1_8.SetCosto(4);
            lbl_VTMazo1_2.Text = mazo2_P1.Get_Vida2().ToString();
            lbl_DTMazo1_2.Text = mazo2_P1.Get_danio2().ToString();
            lbl_AlcanceMazo1_2.Text = mazo2_P1.Get_Alcance2().ToString();
            CP_1_2.Text = mazo2_P1.Get_Costo2().ToString(); //FIN MAZO 2
            CP_1_2.Text = mazo2_P1.Get_Costo2().ToString(); //FIN MAZO 2

            mazo2_P2.carta1_1.SetNombre("Globo bombastico");
            mazo2_P2.carta1_2.SetNombre("Cazador");
            mazo2_P2.carta1_3.SetNombre("Minero");
            mazo2_P2.carta1_4.SetNombre("Murciélago");
            mazo2_P2.carta1_5.SetNombre("Bola de nieve");
            mazo2_P2.carta1_6.SetNombre("Gólem de hielo");
            mazo2_P2.carta1_7.SetNombre("Paquete real");
            mazo2_P2.carta1_8.SetNombre("Barril de barbaro");

            mazo2_P2.carta1_1.SetDanio(880);
            mazo2_P2.carta1_2.SetDanio(112);
            mazo2_P2.carta1_3.SetDanio(251);
            mazo2_P2.carta1_4.SetDanio(81);
            mazo2_P2.carta1_5.SetDanio(250);
            mazo2_P2.carta1_6.SetDanio(168);
            mazo2_P2.carta1_7.SetDanio(570);
            mazo2_P2.carta1_8.SetDanio(433);

            mazo2_P2.carta1_1.SetVida(1680);
            mazo2_P2.carta1_2.SetVida(838);
            mazo2_P2.carta1_3.SetVida(1210);
            mazo2_P2.carta1_4.SetVida(81);
            mazo2_P2.carta1_5.SetVida(0);
            mazo2_P2.carta1_6.SetVida(1197);
            mazo2_P2.carta1_7.SetVida(772);
            mazo2_P2.carta1_8.SetVida(670);

            mazo2_P2.carta1_1.SetAlcance(0);
            mazo2_P2.carta1_2.SetAlcance(6.5);
            mazo2_P2.carta1_3.SetAlcance(0);
            mazo2_P2.carta1_4.SetAlcance(0);
            mazo2_P2.carta1_5.SetAlcance(2.5);
            mazo2_P2.carta1_6.SetAlcance(0);
            mazo2_P2.carta1_7.SetAlcance(3);
            mazo2_P2.carta1_8.SetAlcance(4.5);

            mazo2_P2.carta1_1.SetCosto(5);
            mazo2_P2.carta1_2.SetCosto(4);
            mazo2_P2.carta1_3.SetCosto(3);
            mazo2_P2.carta1_4.SetCosto(2);
            mazo2_P2.carta1_5.SetCosto(2);
            mazo2_P2.carta1_6.SetCosto(2);
            mazo2_P2.carta1_7.SetCosto(3);
            mazo2_P2.carta1_8.SetCosto(2);
            //   FIN MAZO 3
            lbl_alcancemazo2_1.Text = mazo2_P2.Get_Alcance3().ToString();
            CP_2_1.Text = mazo2_P2.Get_CostoMazo3().ToString();
            lbl_DTMazo2_1.Text = mazo2_P2.Get_Danio_Mazo3().ToString();
            Lbl_vidaMazo2_1.Text = mazo2_P2.Get_Vida_Mazo3().ToString();

            mazo1_P2.carta1_1.SetNombre("Cementerio");
            mazo1_P2.carta1_2.SetNombre("Tornado");
            mazo1_P2.carta1_3.SetNombre("Mago de hielo");
            mazo1_P2.carta1_4.SetNombre("Barril de esqueletos");
            mazo1_P2.carta1_5.SetNombre("Veneno");
            mazo1_P2.carta1_6.SetNombre("Caballero");
            mazo1_P2.carta1_7.SetNombre("Bebé dragon");
            mazo1_P2.carta1_8.SetNombre("Torre bombardera");

            mazo1_P2.carta1_1.SetDanio(81);
            mazo1_P2.carta1_2.SetDanio(394);
            mazo1_P2.carta1_3.SetDanio(174);
            mazo1_P2.carta1_4.SetDanio(214);
            mazo1_P2.carta1_5.SetDanio(119);
            mazo1_P2.carta1_6.SetDanio(202);
            mazo1_P2.carta1_7.SetDanio(160);
            mazo1_P2.carta1_8.SetDanio(444);

            mazo1_P2.carta1_1.SetVida(0);
            mazo1_P2.carta1_2.SetVida(0);
            mazo1_P2.carta1_3.SetVida(688);
            mazo1_P2.carta1_4.SetVida(613);
            mazo1_P2.carta1_5.SetVida(0);
            mazo1_P2.carta1_6.SetVida(1715);
            mazo1_P2.carta1_7.SetVida(1152);
            mazo1_P2.carta1_8.SetVida(1356);

            mazo1_P2.carta1_1.SetAlcance(4);
            mazo1_P2.carta1_2.SetAlcance(5.5);
            mazo1_P2.carta1_3.SetAlcance(5.5);
            mazo1_P2.carta1_4.SetAlcance(0);
            mazo1_P2.carta1_5.SetAlcance(3.5);
            mazo1_P2.carta1_6.SetAlcance(0);
            mazo1_P2.carta1_7.SetAlcance(3.5);
            mazo1_P2.carta1_8.SetAlcance(6);

            mazo1_P2.carta1_1.SetCosto(5);
            mazo1_P2.carta1_2.SetCosto(3);
            mazo1_P2.carta1_3.SetCosto(3);
            mazo1_P2.carta1_4.SetCosto(3);
            mazo1_P2.carta1_5.SetCosto(4);
            mazo1_P2.carta1_6.SetCosto(3);
            mazo1_P2.carta1_7.SetCosto(4);
            mazo1_P2.carta1_8.SetCosto(4);
            lblalcance4.Text = mazo1_P2.Get_alcance4().ToString();
            lbl_vida4.Text= mazo1_P2.Get_vida4().ToString();
            lbl_danio4.Text= mazo1_P2.Get_Danio4().ToString();
            cp_4.Text = mazo1_P2.Get_costo4().ToString();
        }






        private void btn_Nicname1_Click_1(object sender, EventArgs e)
        {
            String inicales = txt_equipo.Text;
            for (int i = 0; i < inicales.Length; i++)
            {

                if (inicales[i] == inicales[0] || inicales[i] == (inicales[5]))
                {
                    String conjunto = Convert.ToString(inicales[0]);
                    String conjuntos = Convert.ToString(inicales[5]);
                    String final = Convert.ToString(lbl_nick1.Text.Length - 1);
                    lbl_nick1.Text = conjunto + conjuntos + Txt_nombre.Text + final;
                    lbl_p1_M.Text = lbl_nick1.Text;
                    lbl_frente1.Text = lbl_nick1.Text;
                }
            }
        }

        private void Btn_nickanme2_Click_1(object sender, EventArgs e)
        {
            String inicales_ = Txt_equipo2.Text;
            for (int i = 0; i < inicales_.Length; i++)
            {

                if (inicales_[i] == inicales_[0] || inicales_[i] == (inicales_[5]))
                {
                    String conjunto_ = Convert.ToString(inicales_[0]);
                    String conjuntos_ = Convert.ToString(inicales_[5]);
                    String final_ = Convert.ToString(lbl_nick2.Text.Length - 1);
                    lbl_nick2.Text = conjunto_ + conjuntos_ + Txt_nombre2.Text + final_;
                    lbl_mazos_p2.Text = lbl_nick2.Text;
                    lbl_frente2.Text = lbl_nick2.Text;

                }
            }
        }

        private void btn_revelion_Click(object sender, EventArgs e)
        {
            String Texto = "Rebelion en la granja";
            Lblmazo_P1.Text = Texto;
        }

        private void btn_boys_Click(object sender, EventArgs e)
        {
            String texto = "The boys";
            Lblmazo_P1.Text = texto;
        }

        private void btn_esqueletos_Click(object sender, EventArgs e)
        {
            String _texto = "Mass Esqueletos";
            lbl_mazo_P2.Text = _texto;
        }

        private void btn_helado_Click(object sender, EventArgs e)
        {
            String Texto_ = "Globo Helado";
            lbl_mazo_P2.Text= Texto_;
        }
    }
}
