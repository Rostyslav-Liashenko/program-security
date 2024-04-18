using System;
using System.IO;
using System.Windows.Forms;

namespace LR6
{
  public partial class Form1 : Form
  {

    private string selectedFilePath;


    private void SetSelectedFilePath()
    {
      OpenFileDialog dialog = new OpenFileDialog();

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        selectedFilePath = dialog.FileName;
        label1.Text = "Файл для пошуку компаньйонів: " + selectedFilePath;
      }
    }

    private string GetRootBySelectedFile()
    {
      int pos = selectedFilePath.LastIndexOf("\\", StringComparison.Ordinal);
      
      return selectedFilePath.Substring(0, pos);
    }

    private string GetFileNameByFile(string filePath)
    {
      int pos = filePath.LastIndexOf("\\", StringComparison.Ordinal);
      string fileNameWithExtension = filePath.Substring(pos + 1);
      int pointPos = fileNameWithExtension.IndexOf(".");

      return fileNameWithExtension.Substring(0, pointPos);
    }

    private string GetFileExtensionByFile(string filePath)
    {
      int pos = filePath.LastIndexOf("\\", StringComparison.Ordinal);
      string fileNameWithExtension = filePath.Substring(pos + 1);
      int pointPos = fileNameWithExtension.IndexOf(".");

      return fileNameWithExtension.Substring(pointPos + 1);
    }

    private void SearchCompanion(string folderPath)
    {
      string[] filePaths = Directory.GetFiles(folderPath);
      string selectedFileName = GetFileNameByFile(selectedFilePath);
      string selectedFileExtension = GetFileExtensionByFile(selectedFilePath);

      foreach (string filePath in filePaths)
      {
        string fileName = GetFileNameByFile(filePath);
        string extension = GetFileExtensionByFile(filePath);
        bool isCompanion = fileName == selectedFileName && selectedFileExtension != extension;

        if (isCompanion)
        {
          listBox1.Items.Add(filePath);
        }
      }
      
      string[] subdirectories = Directory.GetDirectories(folderPath);
      foreach (string subdirectory in subdirectories)
      {
        SearchCompanion(subdirectory);
      }
    }
    
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SetSelectedFilePath();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (selectedFilePath == "")
      {
        MessageBox.Show("Ви не вибрали файл");
        return;
      }

      string selectedFolder = GetRootBySelectedFile();
      SearchCompanion(selectedFolder);
    }
  }
}
