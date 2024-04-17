using System;
using System.IO;
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
                setSelectedFilePath(dialog.FileName);
            }
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            selectedFilePath = "";
            textForSearch = "";
        }

        private bool findStringInFile(string filePath, string search)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (line.Contains(search))
                {
                    return true;
                }
            }

            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textForSearch = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectFile();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            bool isValid = validation();

            if (!isValid)
            {
                MessageBox.Show("Дані для пошуку не валідні!");
                return;
            }
            
            bool isFouned = findStringInFile(selectedFilePath, textForSearch);

            if (isFouned)
            {
                label3.Text = "Результат пошуку: рядок знайдений";
            }
            else
            {
                label3.Text = "Результат пошуку: рядок не знайдений";
            }
        }
    }
}