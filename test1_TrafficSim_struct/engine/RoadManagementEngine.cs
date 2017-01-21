using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1_TrafficSim_struct;
using test1_TrafficSim_struct.gui;

namespace test1_TrafficSim_struct
{
    /// <summary>
    /// Main engine class, it manages form creation, simulation/visualisation starting, first-class initialisation
    /// </summary>
    public class RoadManagementEngine
    {
        static private RoadManagementEngine instance = null;
        static private readonly object threadLock = new object();
        private Area currentArea;
        
        /// <summary>
        /// Default constructor, do not touch.
        /// </summary>
        private RoadManagementEngine()
        {
            currentArea = null;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static RoadManagementEngine GetInstance()
        { 
            lock (threadLock)
            {
                if (instance == null)
                {
                    instance = new RoadManagementEngine();
                }

                return instance;
            }
        }

        /// <summary>
        /// Starts windows with visualisation of generated structure
        /// </summary>
        private static void StartGui(object FORM)
        {
            Application.Run(FORM as MainDrawForm);
        }

        /// <summary>
        /// This method is supposed to generate Area object that is passed to main form for drawing.
        /// </summary>
        /// <param name="sections">List of sections (each section is a number and has divide/merge type) </param>
        /// <returns></returns>
        public int GenerateVisualisation(  )
        {
            return 0;
        }

        /// <summary>
        /// Initializes threads, forms and starts simulation
        /// </summary>
        public int StartEngine()
        {
            Area currentArea = Area.Generate(null);
            Console.WriteLine(currentArea.GetName());
            Console.WriteLine(currentArea.GetWay(0).GetName());
            Console.WriteLine(currentArea.GetWay(0).GetSegmentAt(0).GetName());
            Console.WriteLine(currentArea.GetWay(0).GetSegmentAt(0).superiorNodes[0].GetName());
            Console.WriteLine(currentArea.GetWay(0).GetSegmentAt(0).superiorNodes[1].GetName());
            Console.WriteLine(currentArea.GetWay(0).GetSegmentAt(0).GetLaneAt(0).GetName());
            //Console.WriteLine(currentArea.GetWay(0).GetSegmentAt(0).GetLaneAt(0).GetNext());
            Console.WriteLine();

            MainDrawForm mainForm = new MainDrawForm(currentArea);

            Console.WriteLine("This is main thread:" + Thread.CurrentThread.ManagedThreadId);

            Thread guiThread = new Thread(StartGui);
            guiThread.Start(mainForm);

            Thread updateThread = new Thread(mainForm.UpdateStatus);
            updateThread.Start();

            Console.ReadKey(); // Gotta repair console, when form starts it's blocked.
            // Getting console (witn our own intepreter) would be awesome.

            // KoooOOoompletna bieeeeEEEeeedaaaaAAAaa.

            return 0;
        }
    }
}
