using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int soruno = 0, dogru = 0, yanlis = 0, bos = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            button1.Text = sayac.ToString();
            if (sayac == 15)
            {
                timer1.Stop();
                button1.Text = "Süreniz bitti üzgünüm diğer soruya geçiniz ";
                textBox1.Enabled = false;
                linkLabel1.Enabled = true;
                bos++;
                label6.Text = bos.ToString();

                sayac = 0;
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                linkLabel1.Enabled = true;
                sayac = 0;
                switch (soruno)
                {
                    case 1:

                        if (textBox1.Text == "ankara")
                        {
                            a.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            a.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";

                        break;
                    case 2:

                        if (textBox1.Text == "bornova")
                        {
                            b.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 3:
                        if (textBox1.Text == "cam")
                        {
                            c.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            c.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 4:
                        if (textBox1.Text == "doktor")
                        {
                            d.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            d.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            ee.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            ee.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 6:
                        if (textBox1.Text == "fransa")
                        {
                            f.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            f.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 7:
                        if (textBox1.Text == "gezi parkı")
                        {
                            g.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            g.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            h.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            h.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 9:
                        if (textBox1.Text == "ırmak")
                        {
                            ı.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            ı.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 10:
                        if (textBox1.Text == "kale")
                        {
                            k.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            k.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 11:
                        if (textBox1.Text == "lale")
                        {
                            l.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            l.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 12:
                        if (textBox1.Text == "malatya")
                        {
                            m.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            m.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 13:
                        if (textBox1.Text == "nadir")
                        {
                            n.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            n.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 14:
                        if (textBox1.Text == "olta")
                        {
                            o.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            o.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 15:
                        if (textBox1.Text == "paris")
                        {
                            p.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            p.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 16:
                        if (textBox1.Text == "ranza")
                        {
                            r.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            r.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 17:
                        if (textBox1.Text == "saat")
                        {
                            s.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            s.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 18:
                        if (textBox1.Text == "taç")
                        {
                            t.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            t.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 19:
                        if (textBox1.Text == "umut")
                        {
                            u.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            u.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 20:
                        if (textBox1.Text == "van")
                        {
                            v.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            v.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 21:
                        if (textBox1.Text == "yalova")
                        {
                            y.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            y.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    case 22:
                        if (textBox1.Text == "zonguldak")
                        {
                            z.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            z.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "";
                        break;
                    

                        
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            sayac = 0;
            linkLabel1.Text = "Sonraki";
            linkLabel1.Enabled = false;
            soruno++;


            textBox1.Enabled = true;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Anıtkabir";
                a.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İzmir'in bir ilçesi";
                b.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Isıtılmış kum";
                c.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Şifacı";
                d.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni değil";
                ee.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Eyfel kulesi";
                f.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Taksim";
                g.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Künefe";
                h.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Akar su";
                ı.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Kralın evi";
                k.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Çiçek";
                l.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Kaysı şehri";
                m.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Az bulunan";
                n.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Balık tutan şey";
                o.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Aşıklar şehri";
                p.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "İki yatak";
                r.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Zaman göstergesi";
                s.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Kralın kafasında";
                t.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Bir beklenti";
                u.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Doğu'nun incisi";
                v.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Bir marmara ili";
                y.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kömür  şehri";
                z.BackColor = Color.Yellow;
            }
            if(soruno == 23)
            {
                MessageBox.Show("oyun bitti");
            }
           
        }
    }
}


