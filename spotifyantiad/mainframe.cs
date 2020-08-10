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
using SpotifyAntiAd;

namespace spotifyantiad
{
    public partial class mainframe : Form
    {
        public mainframe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainframe_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list = File.ReadAllLines($@"{Directory.GetCurrentDirectory()}\blocklist.txt");

            if (File.Exists($@"C:\Users\{Environment.UserName}\AppData\Roaming\Spotify\Spotify.exe"))
            {
                File.AppendAllLines(@"C:\Windows\System32\drivers\etc\hosts", list);
                success success = new success();
                success.Show();
            }

            else
            {
                error error = new error();
                error.Show();
            }
        }
    }
}
