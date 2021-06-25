using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StampIt
{
    public partial class Form1 : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        bool finishedLoading = false;

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Win = 8
        }

        public Form1()
        {
            InitializeComponent();

            //RegisterHotKey(this.Handle, 0, (int)KeyModifier.Alt, Keys.A.GetHashCode());
            //RegisterHotKey(this.Handle, 1, (int)KeyModifier.Alt, Keys.S.GetHashCode());
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                switch (m.WParam.ToInt32())
                {
                    case 0:
                        Console.WriteLine("A pressed");
                        //FileManager.HandleStart();
                        break;
                    case 1:
                        Console.WriteLine("B pressed");
                        //FileManager.PutStamp();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbDirPath.Text = Properties.Settings.Default.StoreLocation;

            ComboBinder comboBinder = new ComboBinder();
            comboBinder.AddEntries(new (int, string)[]{
                (0, "None"),
                (1, "Alt"),
                (2, "Control"),
                (4, "Shift"),
                (8, "Win"),
            });

            cbHotykeyStart.DataSource = comboBinder.GetBindingSource();
            cbHotykeyStart.DisplayMember = "Value";
            cbHotykeyStart.ValueMember = "Key";
            cbHotykeyStart.SelectedIndex = Properties.Settings.Default.HotkeyStartModificatorKey;

            cbHotykeyStamp.DataSource = comboBinder.GetBindingSource();
            cbHotykeyStamp.DisplayMember = "Value";
            cbHotykeyStamp.ValueMember = "Key";
            cbHotykeyStamp.SelectedIndex = Properties.Settings.Default.HotkeyStampModificatiorKey;

            tbHotkeyStamp.Text = Properties.Settings.Default.HotkeyStamp;
            tbHotkeyStart.Text = Properties.Settings.Default.HotkeyStart;

            RegisterHotkeys();
            finishedLoading = true;
        }

        private void btnOpenBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            var selectedDir = folderBrowserDialog1.SelectedPath;

            tbDirPath.Text = selectedDir;

            FileManager.path = tbDirPath.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
            UnregisterHotKey(this.Handle, 1);

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    if (MessageBox.Show("Exit Program?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                StampIt.Visible = true;
            }
        }

        private void TbDirPath_TextChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
                Properties.Settings.Default.StoreLocation = tbDirPath.Text;
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
                Properties.Settings.Default.HotkeyStartModificatorKey = ((KeyValuePair<int, string>)cbHotykeyStart.SelectedItem).Key;
        }

        private void cbHotykeyStamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
                Properties.Settings.Default.HotkeyStampModificatiorKey = ((KeyValuePair<int, string>)cbHotykeyStamp.SelectedItem).Key;
        }

        private void tbHotkeyStart_TextChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
                Properties.Settings.Default.HotkeyStart = tbHotkeyStart.Text;
        }

        private void tbHotkeyStamp_TextChanged(object sender, EventArgs e)
        {
            if (finishedLoading)
                Properties.Settings.Default.HotkeyStamp = tbHotkeyStamp.Text;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            StampIt.Visible = false;
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Save();
            RegisterHotkeys();
        }


        private void RegisterHotkeys()
        {
            if ( Properties.Settings.Default.HotkeyStart == null || Properties.Settings.Default.HotkeyStamp==null) { return; }

            char hotkeyStart = Properties.Settings.Default.HotkeyStart.First();
            char hotkeyStamp = Properties.Settings.Default.HotkeyStamp.First();

            if (char.IsDigit(hotkeyStart)||char.IsDigit(hotkeyStamp)) { return; }

            Func<char, int> GetKeyCode = (c) =>
             {
                 return ((Keys)char.ToUpper(c)).GetHashCode();
             };


            try
            {
                RegisterHotKey(this.Handle, 0, Properties.Settings.Default.HotkeyStartModificatorKey, GetKeyCode(hotkeyStart));
                RegisterHotKey(this.Handle, 1, Properties.Settings.Default.HotkeyStampModificatiorKey, GetKeyCode(hotkeyStamp));
            }
            catch (Exception e)
            {
                UnregisterHotKey(this.Handle, 0);
                UnregisterHotKey(this.Handle, 1);
            }

        }
    }
}
