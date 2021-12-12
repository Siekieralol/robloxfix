using System;
using System.IO;
using System.Windows.Forms;
namespace Roblox_Fix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\GlobalBasicSettings_13.xml");
            } catch { }
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\GlobalSettings_13.xml");
            } catch { }
            try
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Roblox\AnalysticsSettings.xml");
            } catch { }
        }
    }
}