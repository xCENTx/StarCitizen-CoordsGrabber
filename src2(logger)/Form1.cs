using System;
using System.Drawing;
using System.Windows.Forms;
using Memory;

namespace StarCitizen_DevTool
{
    public partial class Main : Form
    {
        bool GameRunning;
        Mem m = new Mem();

        public static class Offsets
        {
            public const string X = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1C0";
            public const string Y = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1C8";
            public const string Z = "0x9F4FD10,0x240,0x168,0x18,0xB0,0x8,0x1D0";
        }

        public Main()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("StarCitizen");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                GameRunning = true;
                active_Panel.BackColor = Color.FromArgb(0, 169, 0);
                return;
            }
            GameRunning = false;
            active_Panel.BackColor = Color.FromArgb(169, 0, 0);
        }

        private void tele_button_Click(object sender, EventArgs e)
        {
            if (!GameRunning) return;
            string writeX = X_textBox.Text;
            string writeY = Y_textBox.Text;
            string writeZ = Z_textBox.Text;
            m.WriteMemory($"StarCitizen.exe+{Offsets.X}", "double", writeX);
            m.WriteMemory($"StarCitizen.exe+{Offsets.Y}", "double", writeY);
            m.WriteMemory($"StarCitizen.exe+{Offsets.Z}", "double", writeZ);
        }

        private void output_button_Click(object sender, EventArgs e)
        {
            if (!GameRunning) return;
            if (summary_textBox.Text == null)
            {
                MessageBox.Show("INCLUDE A SUMMARY");
                return;
            }
            richTextBox.Text = "//" + summary_textBox.Text + "\n"
                    + X_textBox.Text + "\n"
                    + Y_textBox.Text + "\n"
                    + Z_textBox.Text;
        }
    }
}
