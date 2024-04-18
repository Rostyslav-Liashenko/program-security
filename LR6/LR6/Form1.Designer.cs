namespace LR6
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 35);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(677, 41);
      this.button1.TabIndex = 0;
      this.button1.Text = "Вибрати файл";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(677, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Вибраний файл для пошуку компаньйонів:";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(12, 105);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(677, 196);
      this.listBox1.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(677, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Файли компаньйони:";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(12, 308);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(677, 36);
      this.button2.TabIndex = 4;
      this.button2.Text = "Почати пошук";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(12, 350);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(295, 41);
      this.button3.TabIndex = 5;
      this.button3.Text = "Видалитии компаньйонів";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click_1);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(324, 350);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(365, 41);
      this.button4.TabIndex = 6;
      this.button4.Text = "Перемістити компаньйонів";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(703, 403);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Лабораторна робота №6";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;

    #endregion
  }
}

