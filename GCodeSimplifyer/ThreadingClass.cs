using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GCodeSimplifyer
{
    class ThreadingClass
    {

        static void Convert(RichTextBox tb_in, RichTextBox tb_out)
        {
            tb_out.Text = "";
            String temp = "";
            int tempint = 0;

            Boolean write = false;

            String[] input = new String[tb_in.Lines.Length];

            for(int i = 0; i < tb_in.Lines.Length ; i++){               //für jede Zeile durchlaufen

                char[] c = new char[tb_in.Lines.Length];                //neues char array für die Zeile erstellen und füllen:
                //log("char array created!");
                tempint = tb_in.Lines[i].Length;
                c = tb_in.Lines[i].ToCharArray(0,tempint);
                //log("char array: " + c.ToString());

                write = true;
                for (int j = 0; j < c.Length; j++)                      //für jeden Buchstaben durchlaufen
                {
                    if (c[j] == '.')                                    //nach einem Komma wird....
                    {
                        write = false;
                    }else if(c[j] == ' '){                              //...bis zum nächsten Leerzeichen nichts übernommen
                        write = true;
                    }
                    if (write)                                          //Buchstabe wird übernommen oder auch nicht 
                    {
                        temp += c[j];
                    }
                }
                tb_out.Text += temp + "\n";                             //alle Buchstaben durchlaufen, Zeile wird ausgegeben
                temp = "";
            }
        }

        internal void RemoveDec(RichTextBox tb_in, RichTextBox tb_out)
        {
            Task.Factory.StartNew(() => Convert(tb_in, tb_out));
        }
    }
}
