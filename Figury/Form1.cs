using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Numerics;
using System.Media;

namespace Kulki
{
    public partial class Form1 : Form
    {
        private int szerPanelu, wysPanelu;
        private bool czyZatrzymano = true;
        private int liczbaFigur = 1; //Okresla ilosc ile potrzebuje miejsc w tablicy
        private int vOd = 1; //od tej liczby (łącznie z nią) bedzie losowana predkosc
        private int vDo = 2; //do tej liczby (wyłączając ja) bedzie losowana predkosc
        private int rOd = 1; //od tej liczby (łącznie z nia) bedzie losowany promien
        private int rDo = 2; //do tej liczby (wyłączająć ją) bedzie losowany promien
        private int promien;
        private int rodzaj;
        private int x; //zmienna pomocnicza do sprawdzenia czy figura o srodku x y nie wygeneruje sie na jakiejs innej figurze
        private int y;
        private int a; //zmienna pomocnicza aby okreslic ile jest jeszcze figur to wygenerowania
        private Random r = new Random();
        private int[,] pozycje;
        private List<Figura> figury = new List<Figura>();
        public Form1()
        {
            InitializeComponent();
            szerPanelu = panelFigur.Width;
            wysPanelu = panelFigur.Height;
        }

        private void timer_Tick(object sender, EventArgs e) // dziala co interval timera
        {
                for(int i = 0; i < figury.Count; i++)
                {
                    for (int j = i + 1; j < figury.Count; j++)
                    {
                        if (czyKoliduje(figury[i], figury[j]))
                        {
                            odbij(figury[i], figury[j]);
                            figury[i].wydajDzwiek();
                            figury[j].wydajDzwiek();
                        }
                    }
                figury[i].rusz(szerPanelu, wysPanelu);
                }
                panelFigur.Refresh();
        }

        private void przyciskStartStop_Click(object sender, EventArgs e) // zwykly przycisk start/stop
        {
            if(czyZatrzymano)
            {
                timer.Start(); // timer startuje
                przyciskStartStop.Text = "STOP";
                czyZatrzymano = false;
            }
            else
            {
                timer.Stop(); //timer stopuje
                przyciskStartStop.Text = "START";
                czyZatrzymano = true;
            }
        }

        private void panelKulek_Resize(object sender, EventArgs e) // za kazdym razem gdy zmieni sie rozmiar panelu to przypisuje ten rozmiar do zmiennych
        { //aby kulki mogly latac po calym panelu
            szerPanelu = panelFigur.Width;
            wysPanelu = panelFigur.Height;
        }
        private void promienOd_ValueChanged(object sender, EventArgs e)
        {
            rOd = (int)promienOd.Value;
        }

        private void promienDo_ValueChanged(object sender, EventArgs e)
        {
            rDo = (int)promienDo.Value;
        }

        private void predkoscOd_ValueChanged(object sender, EventArgs e)
        {
            vOd = (int)predkoscOd.Value;
        }

        private void predkoscDo_ValueChanged(object sender, EventArgs e)
        {
            vDo = (int)predkoscDo.Value;
        }

        private void dlugoscInterwalu_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)dlugoscInterwalu.Value;
        }

        private void przyciskWyczysc_Click(object sender, EventArgs e) // czyszczenie planszy
        {
            wyczysc();
        }
        
        private void wyczysc()
        {
            figury.Clear();
            panelFigur.Refresh();
            inicjalizujPozycje();
        }


        private bool czyKoliduje(Figura f1, Figura f2)
        {
            int odleglosc = (int)(((f1.X - f2.X) * (f1.X - f2.X)) + ((f1.Y - f2.Y) * (f1.Y - f2.Y)));
            if (odleglosc <= ((f1.R + f2.R) * (f1.R + f2.R))) //Wtedy ta figura na rzecz ktorej jest wykonana ta metoda i kulka k sie przecinaja, wynika to z twierdzenia pitagorasa
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panelFigur_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figury)
            {
                f.rysuj(e.Graphics);
            }
        }

        private void odbij(Figura f1, Figura f2)
        {   // nie jest to idealnie fizycznie rozwiazanie ale
            // uzyłem wzoru na predkosc dla jednego wymiaru przy zalozeniu ze masy tych figur sa takie same.
            // dostosowalem to tak zeby dzialalo dla dwoch wymiarow.
            int vxTemp, vyTemp;

            vxTemp = f1.Vx;
            vyTemp = f1.Vy;

            f1.Vx = f2.Vx;
            f1.Vy = f2.Vy;

            f2.Vx = vxTemp;
            f2.Vy = vyTemp;
        }

        private void iloscFigur_ValueChanged(object sender, EventArgs e)
        {
            liczbaFigur = (int)iloscFigur.Value; // rzutuje na inta poniewaz value numericupdown jest typu decimal
        }

        private void przyciskGenFigury_Click(object sender, EventArgs e)
        {
            generujFigury();
        }

        private bool czyJestMiejsce(int x, int y, int r)
        {
            for(int i = y - r; i <= y + r; i++) // sprawdza czy miejsce jest wolne aby wygenerowac tam figure
            {
                for(int j = x - r; j <= x + r; j++)
                {
                    if(pozycje[i, j] == 1)
                    {
                        return false;
                    }
                }
            }
            //jezeli juz przeszlo cala petle to znaczy ze jest, wiec trzeba teraz te miejsca wypelnic 1, po to aby bylo wiadomo przy nastepnym generowaniu ze jest to miejsce juz zajete
            for (int i = y - r; i <= y + r; i++)
            {
                for (int j = x - r; j <= x + r; j++)
                {
                    pozycje[i, j] = 1;
                }
            }
            return true;

        }
        private void inicjalizujPozycje()
        {
            for(int i = 0; i < wysPanelu; i++)
            {
                for(int j = 0; j < szerPanelu; j++)
                {
                    pozycje[i, j] = 0;
                }
            }
        }
        private void generujFigury()
        {
            if(vOd < vDo && rOd < rDo)
            {

                pozycje = new int[wysPanelu, szerPanelu];
                figury.Clear(); //czysci liste
                inicjalizujPozycje(); //wypelnia 0 tablice pozycje
                a = liczbaFigur;
                while( a > 0) // bede zmniejszal a o 1 gdy znajdzie wolna pozycje dla kwadratu lub kulki
                {
                    promien = r.Next(rOd, rDo);
                    rodzaj = r.Next(0, 2);
                    x = r.Next(0 + promien, szerPanelu - promien);
                    y = r.Next(0 + promien, wysPanelu - promien);

                    if(czyJestMiejsce(x, y, promien))
                    {
                        switch (rodzaj)
                        {
                            case 0:
                                figury.Add(new Kulka(x, y, r.Next(vOd, vDo), r.Next(vOd, vDo), promien, Color.Blue));
                                break;
                            case 1:
                                figury.Add(new Kwadrat(x, y, r.Next(vOd, vDo), r.Next(vOd, vDo), promien, Color.Red));
                                break;
                        }
                        a--;
                    }
                }
                panelFigur.Refresh();
            }
            else
            {
                MessageBox.Show("Niepoprawny przedział");
            }
        }

    }

    public class MojPanel : Panel
    {
        public MojPanel()
        {
            DoubleBuffered = true;
        }
    }

    abstract class Figura
    {
        protected int x;
        protected int y;
        protected int vx;
        protected int vy;
        protected int r;
        protected SolidBrush sb;

        public Figura(int x, int y, int vx, int vy, int r, Color k)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.r = r;
            sb = new SolidBrush(k);
        }

        abstract public void rysuj(Graphics g);
        abstract public void wydajDzwiek();

        public void rusz(int szer, int wys)
        {
            x += vx;
            if(x >= szer - r || x <= r )
            {
                vx = -vx;
                wydajDzwiek();
            }
            y += vy;
            if(y >= wys - r || y <= r)
            {
                vy = -vy;
                wydajDzwiek();
            }
        }

        public int X
        {
            get { return x; }
            set { x = value;  }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Vx
        {
            get { return vx; }
            set { vx = value; }
        }
        public int Vy
        {
            get { return vy; }
            set { vy = value; }
        }
        public int R
        {
            get { return r; }
            set { r = value; }
        }


    }
   
    class Kwadrat : Figura
    {
        public Kwadrat(int x, int y, int vx, int vy, int r, Color k) : base(x, y, vx, vy, r, k)
        {
        }

        override
        public void rysuj(Graphics g)
        {
            g.FillRectangle(sb, x - r, y - r, 2 * r, 2 * r);
        }
        
        override
        public void wydajDzwiek()
        {
            new SoundPlayer(Kulki.Properties.Resources.kwadrat).Play(); //Kulki dlatego ze tak pierwotnie sie nazywał ten projekt.
            //Dodalem pliki .wav do resources.resx aby byly dostepne zawsze w projekcie.
        }
    }


    class Kulka : Figura
    {
        public Kulka(int x, int y, int vx, int vy, int r, Color k) : base(x, y, vx, vy, r, k)
        {
        }

        override
        public void rysuj(Graphics g)
        {
            g.FillEllipse(sb, x - r, y - r, 2 * r, 2 * r);
        }

        override
        public void wydajDzwiek()
        {
            new SoundPlayer(Kulki.Properties.Resources.kulka).Play();
        }
    }
}
