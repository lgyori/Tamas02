using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Tamas02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.SzamlakFeje' table. You can move, or remove it, as needed.
            this.szamlakFejeTableAdapter.Fill(this.database1DataSet3.SzamlakFeje);
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            toolStripStatusLabel1.Text = "";
        }






        //Import data from excel file
        private void ImportDataFromExcel()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Excel xlsx files (*.xlsx)|*.xlsx|Excel xls files (*.xls)|*.xls|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {











                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }




        // Specify what you want to happen every 1000ms.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit from application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importFromExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportDataFromExcel();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ImportDataFromExcel();
        }

    }
}
