﻿namespace LR6
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
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 35);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(180, 27);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(701, 315);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Лабораторна робота №6";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;

    #endregion
  }
}

