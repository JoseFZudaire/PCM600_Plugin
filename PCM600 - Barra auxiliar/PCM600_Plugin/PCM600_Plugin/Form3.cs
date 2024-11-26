using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PCM600_Plugin
{
    public partial class Form3 : Form
    {
        int type_form;
        int type_signals = 1;
        int type_block = 2;

        public Form3(int type)
        {
            InitializeComponent();
            this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.Columns[0].Width = 200;

            type_form = type;

            int i = 100;
            while (i > 0)
            {
                this.dataGridView1.Rows.Add();
                i--;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellBeginEdit(object sender, KeyEventArgs e)
        {

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            string s = Clipboard.GetText();
            string[] lines = s.Split('\n');
            int row = dataGridView1.CurrentCell.RowIndex;
            int col = dataGridView1.CurrentCell.ColumnIndex;
            foreach (string line in lines)
            {
                string[] cells = line.Split('\t');
                int cellsSelected = cells.Length;
                if (row < dataGridView1.Rows.Count)
                {
                    for (int i = 0; i < cellsSelected; i++)
                    {
                        if (col + i < dataGridView1.Columns.Count)
                            dataGridView1[col + i, row].Value = cells[i];
                        else
                            break;
                    }
                    row++;
                }
                else
                {
                    break;
                }

                //if ((row == (dataGridView1.Rows.Count - 1)) || (row == dataGridView1.Rows.Count))
                //{
                //    dataGridView1.Rows.Add();
                //}
            }
        }

        private void nothing(object sender, KeyEventArgs e)
        {

        }

        private void changedCell(object sender, DataGridViewCellCancelEventArgs e)
        {
            //string s = Clipboard.GetText();
            //string[] lines = s.Split('\n');
            //int row = dataGridView1.CurrentCell.RowIndex;
            //int col = dataGridView1.CurrentCell.ColumnIndex;
            //foreach (string line in lines)
            //{
            //    string[] cells = line.Split('\t');
            //    int cellsSelected = cells.Length;
            //    if (row < dataGridView1.Rows.Count)
            //    {
            //        for (int i = 0; i < cellsSelected; i++)
            //        {
            //            if (col + i < dataGridView1.Columns.Count)
            //                dataGridView1[col + i, row].Value = cells[i];
            //            else
            //                break;
            //        }
            //        row++;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //    if ((row == (dataGridView1.Rows.Count - 1)) || (row == dataGridView1.Rows.Count))
            //    {
            //        dataGridView1.Rows.Add();
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (type_form == type_signals)
            //{
            //    MessageBox.Show("In type signals");

            //    this.WindowState = FormWindowState.Minimized;

            //    System.Diagnostics.Process processFile = new System.Diagnostics.Process();
            //    System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

            //    startInfoFile.RedirectStandardOutput = true;
            //    startInfoFile.RedirectStandardError = true;
            //    startInfoFile.UseShellExecute = false;
            //    startInfoFile.CreateNoWindow = true;

            //    startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //    startInfoFile.FileName = "cmd.exe";
            //    startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\Open PCM600\\OpenPCM600.ahk";
            //    processFile.StartInfo = startInfoFile;

            //    processFile.Start();
            //} else if(type_form == type_block) {
            //    this.WindowState = FormWindowState.Minimized;

            //    System.Diagnostics.Process processFile = new System.Diagnostics.Process();
            //    System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

            //    startInfoFile.RedirectStandardOutput = true;
            //    startInfoFile.RedirectStandardError = true;
            //    startInfoFile.UseShellExecute = false;
            //    startInfoFile.CreateNoWindow = true;

            //    startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //    startInfoFile.FileName = "cmd.exe";
            //    startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\Open PCM600\\OpenPCM600_block.ahk";
            //    processFile.StartInfo = startInfoFile;

            //    processFile.Start();

            //}

            //if (type_form == type_signals)
            //{
            //    startInfoFile.RedirectStandardOutput = true;
            //    startInfoFile.RedirectStandardError = true;
            //    startInfoFile.UseShellExecute = false;
            //    startInfoFile.CreateNoWindow = true;

            //    startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //    startInfoFile.FileName = "cmd.exe";
            //    startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\EditSignal.ahk";
            //    processFile.StartInfo = startInfoFile;

            //    processFile.Start();
            //} 
            //else if (type_form == type_block)
            //{
            //    startInfoFile.RedirectStandardOutput = true;
            //    startInfoFile.RedirectStandardError = true;
            //    startInfoFile.UseShellExecute = false;
            //    startInfoFile.CreateNoWindow = true;

            //    startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //    startInfoFile.FileName = "cmd.exe";
            //    startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\EditBlock.ahk";
            //    processFile.StartInfo = startInfoFile;

            //    processFile.Start();
            //}

            string value = ""; 

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    value += row.Cells[0].Value.ToString() + " ";
                    //MessageBox.Show("Value is: " + value);

                    //System.Diagnostics.Process processFile = new System.Diagnostics.Process();
                    //System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

                    //startInfoFile.RedirectStandardOutput = true;
                    //startInfoFile.RedirectStandardError = true;
                    //startInfoFile.UseShellExecute = false;
                    //startInfoFile.CreateNoWindow = true;

                    //startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    //startInfoFile.FileName = "cmd.exe";
                    //startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\ReplaceInput.ahk " + value;
                    //processFile.StartInfo = startInfoFile;

                    //processFile.Start();
                }
                else
                {
                    break;
                }
            }

            if (type_form == type_signals)
            {
                //MessageBox.Show("Type is signals");

                this.WindowState = FormWindowState.Minimized;

                System.Diagnostics.Process processFile = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

                //startInfoFile.RedirectStandardOutput = true;
                //startInfoFile.RedirectStandardError = true;
                startInfoFile.UseShellExecute = false;
                //startInfoFile.CreateNoWindow = false;
                startInfoFile.CreateNoWindow = true;

                startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                //MessageBox.Show("Values are: " + value);

                startInfoFile.FileName = "cmd.exe";
                startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\EditSignal\\EditSignal.ahk " + value;
                processFile.StartInfo = startInfoFile;

                processFile.Start();
            }
            else if (type_form == type_block)
            {
                //MessageBox.Show("Type is block");

                this.WindowState = FormWindowState.Minimized;

                System.Diagnostics.Process processFile = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfoFile = new System.Diagnostics.ProcessStartInfo();

                //startInfoFile.RedirectStandardOutput = true;
                //startInfoFile.RedirectStandardError = true;
                startInfoFile.UseShellExecute = false;
                //startInfoFile.CreateNoWindow = false;
                startInfoFile.CreateNoWindow = true;

                startInfoFile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                //MessageBox.Show("Values are: " + value);

                startInfoFile.FileName = "cmd.exe";
                startInfoFile.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\EditBlock\\EditBlock.ahk " + value;
                processFile.StartInfo = startInfoFile;

                processFile.Start();

            }

            //System.Diagnostics.Process processFile_2 = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfoFile_2 = new System.Diagnostics.ProcessStartInfo();

            //startInfoFile_2.UseShellExecute = false;
            //startInfoFile_2.CreateNoWindow = true;

            //startInfoFile_2.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfoFile_2.FileName = "cmd.exe";
            //startInfoFile_2.Arguments = "/C C:\\Users\\JH0213\\Documents\\AutoHotkey\\Loop\\LoopArguments.ahk " + value;
            //processFile_2.StartInfo = startInfoFile_2;

            //processFile_2.Start();

            this.Close();
        }
    }
}
