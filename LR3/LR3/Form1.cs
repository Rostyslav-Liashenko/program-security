using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form1 : Form
    {
        private string path = null, file = null;
        private int count = 9;
        private Random rd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown2.Value >= 12 ? 12 : numericUpDown2.Value <=
                                                                     1 ? 1 : numericUpDown2.Value;
        }

        private void setPathFleOrExit()
        {
            OpenFileDialog st = new OpenFileDialog();

            if (st.ShowDialog() == DialogResult.OK)
            {
                path = st.FileName;
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }

        private void checkTrial()
        {
            if (count > 0) return;
            
            MessageBox.Show("Тріал період завершений. Запуск ПЗ не можливий");
            Process.GetCurrentProcess().Kill();
        }

        private void checkEditFile()
        {
            if (System.IO.File.GetLastWriteTime("id.pas") == new DateTime(1992, 10, 22))
            {
                StreamReader read = new StreamReader(new FileStream("id.pas",
                    FileMode.Open, FileAccess.Read));
                count = Convert.ToInt32(read.ReadLine().Substring(8, 1)) - 1;
                read.Close();
                StreamWriter write = new StreamWriter(new FileStream("id.pas",
                    FileMode.Create, FileAccess.Write));
                for (int i = 0; i <= 99; i++) file += rd.Next(0, 10).ToString();
                file = file.Insert(8, count.ToString());
                write.Write(file);
                write.Close();
                System.IO.File.SetLastWriteTime("id.pas", new DateTime(1992, 10, 22));
            }
            else
            {
                MessageBox.Show("Службовий файл редагували. Відкрити не можливо!");
                Process.GetCurrentProcess().Kill();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isNotDigit = !Char.IsDigit(e.KeyChar);
            bool isNotBackspace = e.KeyChar != Convert.ToChar(8);
            
            if (isNotDigit && isNotBackspace) {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setPathFleOrExit();
            
            if (!System.IO.File.Exists("id.pas"))
            {
                StreamWriter write = new StreamWriter(new FileStream("id.pas",
                    FileMode.Create, FileAccess.Write));
                for (int i = 0; i <= 99; i++) file += rd.Next(0, 10).ToString();
                file = file.Insert(8, count.ToString());
                write.Write(file);
                write.Close();
                System.IO.File.SetLastWriteTime("id.pas", new DateTime(1992, 10, 22));
            }
            else
            {
                checkEditFile();
            }

            label5.Text = count.ToString();
            checkTrial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.SetLastWriteTime(@path, new
                DateTime(Convert.ToInt32(textBox1.Text), (int)numericUpDown2.Value,
                    (int)numericUpDown1.Value));
            System.IO.File.SetCreationTime(@path, new
                DateTime(Convert.ToInt32(textBox1.Text), (int)numericUpDown2.Value,
                    (int)numericUpDown1.Value));
            MessageBox.Show("Дати збережені");
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = numericUpDown1.Value >= 31 ? 31 : numericUpDown1.Value <=
                                                                     1 ? 1 : numericUpDown1.Value;
        }
    }
}