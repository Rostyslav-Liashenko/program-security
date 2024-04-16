﻿using System;
using System.IO;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string XorEn(string message, int key, string result = null)
        {
            for (int i = 0; i < message.Length; i++)
            {
                result += (char)(message[i] ^ key);
            }
            
            return result;
        }

        private void WriteInFile(string fileName, string text)
        {
            StreamWriter write = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write));
            write.Write(text);
            write.Close();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int keyLength = textBox2.Text.Length;
                string encryptedText = XorEn(textBox1.Text, Convert.ToInt32(textBox2.Text));
                
                textBox3.Text = encryptedText;
                Clipboard.SetText(encryptedText);
                
                int pos = new Random().Next(1, textBox3.Text.Length);
                string file = keyLength + "|" + pos + "|";
                
                textBox3.Text = textBox3.Text.Insert(pos, textBox2.Text);
                file += textBox3.Text;
                textBox3.Text = file;
                
                WriteInFile("text.sts", file);
            }
            else
            {
                Clipboard.SetText(textBox3.Text = XorEn(textBox1.Text,Convert.ToInt32(textBox2.Text)));
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8)) {
                e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                OpenFileDialog stas = new OpenFileDialog();
                if (stas.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read = new StreamReader(new FileStream(stas.FileName,
                        FileMode.Open, FileAccess.Read));
                    
                    string a3 = read.ReadLine();
                    string[] split = a3.Split(new Char[] { '|' });
                    int a1 = Convert.ToInt32(split[0]), a2 = Convert.ToInt32(split[1]);
                    a3 = a3.Remove(0, a1.ToString().Length + a2.ToString().Length + 2);

                    string key = a3.Substring(a2, a1);
                    string encryptedText = a3.Remove(a2, a1);
                    
                    textBox2.Text = key;
                    textBox1.Text = encryptedText;
                    textBox3.Text = XorEn(encryptedText, Convert.ToInt32(key));
                }
            }
        }
    }
}