using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RunAs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void RunNormal(string command)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = command;
                psi.Verb = "open";
                Process.Start(psi);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Run_Click(object sender, EventArgs e)
        {
            RunNormal(Command.Text);
        }

        private void RunAdmin_Click(object sender, EventArgs e)
        {
            
            try
            {   
                ProcessStartInfo psi = null;
                string fileName = string.Empty;
                string args = string.Empty;
                string expression = "\"?.*\"?\\s";
                Regex rgx = new Regex(expression);
                MatchCollection coll = rgx.Matches(Command.Text);
                if (coll.Count > 0)
                {
                    fileName = coll[0].Value.Trim();
                    args = Command.Text.Replace(coll[0].Value, "");
                }
                else
                {
                    fileName = Command.Text;
                    args = "";
                }
                //Try straight forward method first
                try
                {
                    psi = new ProcessStartInfo(fileName);
                    psi.UseShellExecute = true;
                    psi.Verb = "runas";
                    psi.Arguments = args;
                    Process.Start(psi);
                    return;
                }
                catch { }

                // determine is a file or a directory
                bool IsDir = System.IO.Directory.Exists(fileName);
                bool IsFile = System.IO.File.Exists(fileName);
                if (IsFile)
                {
                    psi = new ProcessStartInfo(fileName);
                    psi.UseShellExecute = true;
                    psi.Verb = "runas";
                    psi.Arguments = args;
                    Process.Start(psi);
                    return;
                }
                if(IsDir)
                {
                    psi = new ProcessStartInfo("explorer.exe");
                    psi.UseShellExecute = true;
                    psi.Verb = "runas";
                    psi.Arguments = Command.Text;
                    Process.Start(psi);
                    return;
                }
                else
                {
                    RunNormal(Command.Text);
                    return;
                }
            }
            catch
            {
                RunNormal(Command.Text);
            }
        }
    }
}
