using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ARM9_Editor
{
    public partial class Form1 : Form
    {
        int size = -1;
        string arnine = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showMusicTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arnine);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    byte[] arnine = File.ReadAllBytes(file);
                    size = arnine.Length;
                    saveAsToolStripMenuItem.Enabled = true;

                }
                catch (IOException)
                {
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mario Kart DS ARM9 Editor - Made by Ermelber\n\nThis is shit :3");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arm9.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = arm9.FileName;
            File.Create(name).Close();
            File.WriteAllText(name, arnine);
            progressBar1.Value = 100;
        }
    }
}
