using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZorkGUIDesign
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game roomRoom = new Game();
            roomRoom.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createNewGameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openExistingGameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                /*try
                {
                    var openFile = openFileDialog.FileName;

                    using (Stream stream = openFileDialog.OpenFile())
                    {
                        Process.Start("notepad.exe", openFile);
                    }
                }*/

                var openFile = openFileDialog.FileName;

                using (Stream stream = openFileDialog.OpenFile())
                {
                    Process.Start("notepad.exe", openFile);
                }

            }
        }

        private void saveGameFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
