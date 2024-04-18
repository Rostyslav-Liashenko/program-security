using System;
using System.Windows.Forms;

namespace LR6
{
  public partial class Form1 : Form
  {

    private string selectedFilePath;


    private void setSelectedFilePath()
    {
      OpenFileDialog dialog = new OpenFileDialog();

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        selectedFilePath = dialog.FileName;
        label1.Text = "Вибраний файл для пошуку компаньйонів: " + selectedFilePath;
      }
    }
    
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      setSelectedFilePath();
    }
  }
}
