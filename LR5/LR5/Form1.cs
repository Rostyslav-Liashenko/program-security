using System;
using System.Windows.Forms;

namespace LR5
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;
        private string textForSearch;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void setSelectedFilePath(string filePath)
        {
            selectedFilePath = filePath;
            label2.Text = "Вибраний файл " + filePath;
        }
        
        private bool validation()
        {
            bool hasSelectedFilePath = selectedFilePath != "";
            bool hasTextForSearch = textForSearch != "";

            return hasSelectedFilePath && hasTextForSearch;
        }

        private void selectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName);
                setSelectedFilePath(dialog.FileName);
            }
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            selectedFilePath = "";
            textForSearch = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isValid = validation();

            if (!isValid)
            {
                MessageBox.Show("Дані для пошуку не валідні!");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textForSearch = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectFile();
        }
    }
}