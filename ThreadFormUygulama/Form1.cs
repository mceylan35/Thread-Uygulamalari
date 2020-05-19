using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadFormUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnRed.Click += btnRed_Click;
            btnSari.Click += btnSari_Click;
            btnYesil.Click += btnYesil_Click;
            //Butona tıklamadan çalışacak

        }

        Random random=new Random();
        void Sari()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.YellowGreen,4),
                                                    new Rectangle(random.Next(0,this.Width),random.Next(0,this.Height),30,30));
                Thread.Sleep(150);
            }
        }
        void Mavi()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue,4),
                                                new Rectangle(random.Next(0, this.Width),random.Next(0,this.Height),30,30));
                Thread.Sleep(150);
            }
        }
        void Kirmizi()
        {
            for (int i = 0; i < 100; i++)
            {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red,4),
                                                new Rectangle(random.Next(0,this.Width),random.Next(0,this.Height),30,30));
                    Thread.Sleep(150);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSari_Click(object sender, EventArgs e)
        {
            Thread sariThread=new Thread(x=>Sari());

           sariThread.Start();
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
             Thread yesilThread=new Thread(y=>Mavi());
             yesilThread.Start();
        
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
         Thread redThread=new Thread(r=>Kirmizi());
         redThread.Start();
        }
    }
}
