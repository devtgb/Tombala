using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tombala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        Button btn;
        int totalButton = 90;
        int randomNumber = 89;
        bool isNumber = false;


        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSayiCek.Enabled = true;
            int sol = 0; //formun sol tarafından atanan değer
            int alt = 4; // formun üst tarafından atanan değer
            int bol; // bolme işlemindeki amaç formun boyutuna göre butonları sıralı bir şekilde görebilmek için
            bol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(totalButton)));

            for (int i = 1; i <= totalButton; i++)  // girilen buton sayısına göre döngü şartı sağlanana kadar oluşturmakta
            {

                btn = new Button();
                btn.Name = i.ToString();
                btn.AutoSize = false;
                btn.BackColor = Color.SteelBlue;
                btn.Font = new Font(btn.Font.FontFamily.Name, 18);
                btn.Size = new Size(this.Width / bol, this.Height / (bol * 2) + 20);
                btn.Text = i.ToString();
                btn.Location = new Point(sol, alt);
                panel2.Controls.Add(btn);
                sol += btn.Width;

                if (sol + this.Width / bol > this.Width)
                {
                    sol = 1;
                    alt += this.Height / (bol * 2) + 14;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 508;
            panel1.Width = this.Width;
            panel2.Width = this.Width;
            panel2.Height = this.Height;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSayiCek_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 91);

             isNumber = IsSameNumber(sayi);

             if (isNumber == false)
             {
                 foreach (Control buton in panel2.Controls) //panelde ki butonlar kontrol ediliyor. 
                 {
                     Control d = (sender as Button); 
                     d = buton;

                     if (buton.GetType() == typeof(Button))
                     {
                         if (buton.Text == number.ToString()) //butonun text'i ile sayi eşitse
                         {

                             d.BackColor = Color.LightBlue;
                             //rastgelesayi--;
                             totalButton--;

                             if (txtSonCekilen.Text != " ")
                             {
                                 txtSonCekilen.Text = " ";
                             }
                             txtSonCekilen.Text = number.ToString();


                             if (txtKalanCekilis.Text != " ")
                             {
                                 txtKalanCekilis.Text = " ";
                             }
                             txtKalanCekilis.Text = totalButton.ToString();
                             lstCekilenler.Items.Add(number);               
                         }
                     }
                 }
             }
             else
             {
                 number = rnd.Next(1, 91);

                 isNumber = IsSameNumber(number);
             }
            }
        /// <summary>
        /// Random dan gelen sayının listboxda olup olmadığının kontrol eden method. 
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        bool IsSameNumber(int sayi)
        {
            bool status = false;
                if (lstCekilenler.Items.Contains(sayi))
                {
                    status = true;
                }
                else
                {
                     status = false;
                }
            return durum;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tombala oyunu");
        }
        }
    }

            
                           
             
         

     
     
