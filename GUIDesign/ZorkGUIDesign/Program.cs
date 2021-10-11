using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZorkGUIDesign
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //var zorkApp = new Form();

            //var createFileButton = new Button();
            //createFileButton.Text = "Create new game file";

            //createFileButton.Top = 15;
            //createFileButton.Left = 15;
            //createFileButton.Size = new System.Drawing.Size(80, 40);

            //createFileButton.Click += (s, e) => zorkApp.Close();

            //zorkApp.Controls.Add(createFileButton);
            //zorkApp.Show();

            //Application.Run();
        }
    }
}
