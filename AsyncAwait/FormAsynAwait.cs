using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
    public partial class FormAsynAwait : Form
    {
        public FormAsynAwait()
        {
            InitializeComponent();
        }

        private async void Form_Load(object sender, EventArgs e)
        {

        }

        /** Click en el botón de búsqueda secuencial */
        private async void btnSequential_Click(object sender, EventArgs e)
        {
            progressBarSequential.Value = 0;
            ListBoxSequential.Items.Clear();
            Stopwatch clock = new Stopwatch();
            clock.Restart();

            var searchTask = Task.Factory.StartNew(() =>
            {

            });

            foreach (string directory in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)))
            {
                foreach (string file in Directory.GetFiles(directory))
                {
                    ListBoxSequential.Items.Add(file);
                }
            }

            clock.Stop();
            progressBarSequential.Value = 100;

            txtSequential.Text = clock.Elapsed.ToString() + " segons";

        }

        /** Click en el botón de búsqueda con TPL */
        private void btnTPL_Click(object sender, EventArgs e)
        {

        }

        /** Click en el botón para saber la hora */
        private void btnTime_Click(object sender, EventArgs e)
        {

        }
    }
}
