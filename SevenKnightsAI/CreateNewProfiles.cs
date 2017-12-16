using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SevenKnightsAI
{
    public partial class CreateNewProfiles : Form
    {
        public static readonly string FILE_EXT = ".json";
        public static readonly string PATH = "\\profiles";
        public static readonly string PARENT_PATH = @Environment.CurrentDirectory.ToString();
        public CreateNewProfiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = "/C copy " + PARENT_PATH + PATH + "\\Default" + FILE_EXT + " " + PARENT_PATH + PATH + "\\" + textBox1.Text.ToString() + FILE_EXT;
            process.StartInfo = processStartInfo;
            if (process.Start())
            {
                MessageBox.Show("Create New Profiles Success, Restart Bot to set New Profiles");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
