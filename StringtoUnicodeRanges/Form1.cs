using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StringtoUnicodeRanges
{
    public struct Comma
    {
        public int index;
    }
    public struct Tre
    {
        public int index;
    }
    public partial class StringToUnicodeRange : Form
    {
        public int conversiontype = 0;
        public bool rangefilter = false;
        public List<char> allchartsused = new List<char>();
        public char[] convertedchars;
        public StringToUnicodeRange()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public bool isByteAlreadyinList(char checkchar)
        {
            bool flag = false;
            if (allchartsused.Count > 0)
            {
                foreach (char charmatch in allchartsused)
                {
                    if (charmatch == checkchar)
                        flag = true;
                }

            }
            return flag;
        }
        public bool isCharacterinRange(char checkchar)
        {
            char minchar= (char)int.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber);
            char maxchar = (char)int.Parse(textBox2.Text, System.Globalization.NumberStyles.HexNumber);
            if (checkchar >= minchar && checkchar <= maxchar)
                return true;
            else
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox2.Text = null;
            allchartsused = new List<char>();
            byte[] bytes = UnicodeEncoding.BigEndianUnicode.GetBytes(richTextBox1.Text);
            char[] chars = UnicodeEncoding.BigEndianUnicode.GetChars(bytes);
            for (int i = 0; i < chars.Length; i++)
            {
                if (rangefilter)
                {
                    if (!isCharacterinRange(chars[i]))
                    {
                        continue;
                    }
                }

                if (isByteAlreadyinList(chars[i]) || chars[i] == ' ')
                    continue;
                else
                    allchartsused.Add(chars[i]);
            }
            ListBytes();
        }
        public void ListBytes()
        {
            convertedchars = new char[allchartsused.Count];
            for (int i = 0; i < allchartsused.Count; i++)
            {
                convertedchars[i] = allchartsused[i];
            }
            if (conversiontype == 0)
            {
                Encoding encoding = Encoding.BigEndianUnicode;
                for (int i = 0; i < convertedchars.Length; i++)
                {
                    byte[] character = UnicodeEncoding.BigEndianUnicode.GetBytes(convertedchars, i, 1);
                    string willtype = BitConverter.ToString(character);
                    string modified = willtype.Remove(2, 1);
                    richTextBox2.Text += modified;
                    if (i != convertedchars.Length - 1)
                        richTextBox2.Text += ",";
                }
            }
            else if (conversiontype == 1)
            {
                List<char> sortedcharlist = allchartsused.OrderBy(o => o).ToList();
                List<int> willremovedindexes = new List<int>();

                List<Comma> comma = new List<Comma>();
                List<Tre> tre = new List<Tre>();
                if (sortedcharlist.Count > 3)
                {
                    for (int i = sortedcharlist.Count - 2; i >= 1; i--)
                    {
                        if (Math.Abs(sortedcharlist[i] - sortedcharlist[i - 1]) == 1 && Math.Abs(sortedcharlist[i + 1] - sortedcharlist[i]) == 1)
                        {
                            willremovedindexes.Add(i);
                            Tre tre1 = new Tre();
                            tre1.index = i;
                            tre.Add(tre1);
                            continue;
                        }
                        else if (Math.Abs(sortedcharlist[i] - sortedcharlist[i - 1]) == 1 && Math.Abs(sortedcharlist[i + 1] - sortedcharlist[i]) > 1)
                        {
                            Comma comma1 = new Comma();
                            comma1.index = i;
                            comma.Add(comma1);
                            continue;
                        }
                        else if (Math.Abs(sortedcharlist[i] - sortedcharlist[i - 1]) > 1 && Math.Abs(sortedcharlist[i + 1] - sortedcharlist[i]) == 1)
                        {
                            Comma comma1 = new Comma();
                            comma1.index = i;
                            comma.Add(comma1);
                            continue;
                        }
                        else
                        {
                            Comma comma1 = new Comma();
                            comma1.index = i;
                            comma.Add(comma1);
                            continue;
                        }
                    }
                    if (Math.Abs(sortedcharlist[sortedcharlist.Count - 1] - sortedcharlist[sortedcharlist.Count - 2]) == 1 && Math.Abs(sortedcharlist[sortedcharlist.Count - 2] - sortedcharlist[sortedcharlist.Count - 3]) == 1)
                    {
                    }
                    else
                    {
                        Comma comma1 = new Comma();
                        comma1.index = sortedcharlist.Count - 1;
                        comma.Add(comma1);
                    }
                    for (int i = sortedcharlist.Count - 1; i >= 0; i--)
                    {

                        if (willremovedindexes.Contains(i))
                        {
                            sortedcharlist.RemoveAt(i);
                        }
                        bool commaortreinsterted = false;
                        if (comma.Count > 1)
                        {
                            foreach (Comma comma2 in comma)
                            {
                                if (comma2.index == i && !commaortreinsterted)
                                {
                                    sortedcharlist.Insert(i, ',');
                                    commaortreinsterted = true;
                                }

                            }
                        }
                        if (tre.Count > 1)
                        {
                            foreach (Tre tre2 in tre)
                            {
                                if (tre2.index == i && !commaortreinsterted)
                                {
                                    sortedcharlist.Insert(i, '-');
                                    commaortreinsterted = true;
                                }

                            }
                        }

                    }
                    convertedchars = new char[sortedcharlist.Count];
                    for (int i = 0; i < sortedcharlist.Count; i++)
                    {
                        convertedchars[i] = sortedcharlist[i];
                    }
                    Encoding encoding = Encoding.BigEndianUnicode;
                    for (int i = 0; i < convertedchars.Length; i++)
                    {
                        if ((convertedchars[i] == ',' || convertedchars[i] == '-') && i != 0)
                        {
                            if (convertedchars[i - 1] == ',' || convertedchars[i - 1] == '-')
                            {
                                continue;
                            }
                            else
                                richTextBox2.Text += convertedchars[i];
                            continue;
                        }
                        byte[] character = UnicodeEncoding.BigEndianUnicode.GetBytes(convertedchars, i, 1);
                        string willtype = BitConverter.ToString(character);
                        string modified = willtype.Remove(2, 1);
                        richTextBox2.Text += modified;

                    }
                }
                else
                {
                    for (int i = 0; i < sortedcharlist.Count; i++)
                    {
                        convertedchars[i] = sortedcharlist[i];
                    }

                    Encoding encoding = Encoding.BigEndianUnicode;
                    for (int i = 0; i < convertedchars.Length; i++)
                    {
                        byte[] character = UnicodeEncoding.BigEndianUnicode.GetBytes(convertedchars, i, 1);
                        string willtype = BitConverter.ToString(character);
                        string modified = willtype.Remove(2, 1);
                        richTextBox2.Text += modified;
                        if (i != convertedchars.Length - 1)
                            richTextBox2.Text += ",";
                    }

                }


            }

        }
        private void convertTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversiontype = 0;
            simpleToolStripMenuItem.Checked = true;
            textMeshProToolStripMenuItem.Checked = false;
        }

        private void convertTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textMeshProToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversiontype = 1;
            simpleToolStripMenuItem.Checked = false;
            textMeshProToolStripMenuItem.Checked = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void applyRangeFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void hexFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rangefilter = !rangefilter;
            if (rangefilter)
                hexFilterToolStripMenuItem.Checked = true;
            else
                hexFilterToolStripMenuItem.Checked = false;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
