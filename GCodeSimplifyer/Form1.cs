using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GCodeSimplifyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            tb_out.Text = "";
            String temp = "";
            int tempint = 0;
            float progress = 0;
            Boolean write = false;

            String[] input = new String[tb_in.Lines.Length];

            for (int i = 0; i < tb_in.Lines.Length; i++)
            {               //für jede Zeile durchlaufen

                char[] c = new char[tb_in.Lines.Length];                //neues char array für die Zeile erstellen und füllen:
                //log("char array created!");
                tempint = tb_in.Lines[i].Length;
                c = tb_in.Lines[i].ToCharArray(0, tempint);
                //log("char array: " + c.ToString());

                write = true;
                for (int j = 0; j < c.Length; j++)                      //für jeden Buchstaben durchlaufen
                {
                    if (c[j] == '.')                                    //nach einem Komma wird....
                    {
                        write = false;
                    }
                    else if (c[j] == ' ')
                    {                              //...bis zum nächsten Leerzeichen nichts übernommen
                        write = true;
                    }
                    if (write)                                          //Buchstabe wird übernommen oder auch nicht 
                    {
                        temp += c[j];
                    }
                }
                tb_out.Text += temp + "\n";                             //alle Buchstaben durchlaufen, Zeile wird ausgegeben
                temp = "";

                progress = ((float)(i + 1) / tb_in.Lines.Length);
                log("progress: " + (i + 1) + " of " + tb_in.Lines.Length + " total\n");
                pgb_progress.Value = (int)(progress * 100);
                //System.Threading.Thread.Sleep(250);
            }
            MessageBox.Show("Edited " + tb_in.Lines.Length + " lines successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_out.Text = "";
            String last = "";
            String temp = "";
            float progress = 0;

            for (int i = 0; i < tb_in.Lines.Length; i++)
            {
                temp = tb_in.Lines[i];
                if (!temp.Equals(last))
                {
                    tb_out.Text += temp + "\n";
                    last = temp;
                }

                progress = ((float)(i + 1) / tb_in.Lines.Length);
                log("progress: " + (i + 1) + " of " + tb_in.Lines.Length + " total");
                pgb_progress.Value = (int)(progress * 100);
            }
            log("Deleted " + (tb_in.Lines.Length - tb_out.Lines.Length) + " duplicate Lines!");
            MessageBox.Show("Deleted " + (tb_in.Lines.Length - tb_out.Lines.Length) + " duplicate Lines!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_out.Lines.Length; i++)
            {
                System.Windows.Forms.Clipboard.SetText(System.Windows.Forms.Clipboard.GetText() + (tb_out.Lines[i] + "\n"));
            }
        }

        private void tb_console_TextChanged(object sender, EventArgs e)
        {
            tb_console.SelectionStart = tb_console.Text.Length;
            tb_console.ScrollToCaret();
        }

        private void log(String s)
        {
            tb_console.Text += s + "\n";
        }

        private void btn_switch_Click(object sender, EventArgs e)
        {
            String temp1 = tb_in.Text;
            String temp2 = tb_out.Text;

            tb_out.Text = temp1;
            tb_in.Text = temp2;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_in_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
