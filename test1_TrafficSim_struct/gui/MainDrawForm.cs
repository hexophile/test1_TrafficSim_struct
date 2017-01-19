using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1_TrafficSim_struct.gui
{
    public partial class MainDrawForm : Form
    {
        /// <summary>
        /// Default constructor of the main form.
        /// </summary>
        public MainDrawForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parametrized constructor of the main form.
        /// </summary>
        /// <param name="AREA"></param>
        public MainDrawForm( Area AREA )
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method updates gui elements and performs event check. Procedure is supposed to be in different thread.
        /// </summary>
        public void UpdateStatus()
        {
            Console.WriteLine("UpdateStatus() in MainDrawForm, thread:" + Thread.CurrentThread.ManagedThreadId);
        }

        private int xxx = 0;

        /// <summary>
        /// Main MainDrawForm paint event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainDrawForm_Paint(object sender, PaintEventArgs e)
        {
            ++xxx;
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics(); // Na początek trzeba eventu (ta metoda) i obiektu do bazgrania

            Pen myPen = new Pen(System.Drawing.Color.Red, 5); // Teraz trzeba pisaka czy innego pędzla

            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid; // Rodzaj pędzla
            myPen.Color = System.Drawing.Color.RoyalBlue; // Kolor pędzla
            myPen.Width = 3; // Wielkość pędzla

            graphicsObj.DrawLine(myPen, 20+xxx, 20, 200, 20);
            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            graphicsObj.DrawLine(myPen, 20, 40, 200, 40); // Droga główna

            myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            myPen.Color = System.Drawing.Color.BlueViolet;
            graphicsObj.DrawLine(myPen, 20, 60, 140, 60);
            graphicsObj.DrawLine(myPen, 180, 60, 200, 60); // Przerwania przy połączeniu


            myPen.Color = System.Drawing.Color.Green;
            graphicsObj.DrawLine(myPen, 20, 100, 140, 60); // (1)
            graphicsObj.DrawLine(myPen, 20, 120, 180, 60); // (2) Droga podporządkowana


            myPen.Color = System.Drawing.Color.Red;
            graphicsObj.DrawLine(myPen, 20, 10, 20, 70); // Węzeł początkowy (główna)
            myPen.Color = System.Drawing.Color.DarkRed;
            graphicsObj.DrawLine(myPen, 20, 90, 20, 130); // Węzęł początkowy (podporządkowana)
            myPen.Color = System.Drawing.Color.Orange;
            graphicsObj.DrawLine(myPen, 180, 10, 180, 70); // Węzęł łączący
        }
    }
}
