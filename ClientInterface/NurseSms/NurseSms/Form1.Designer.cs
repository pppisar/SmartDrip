﻿namespace NurseSms
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
      this.button2 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(37, 371);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(419, 67);
      this.button2.TabIndex = 1;
      this.button2.Text = "Очистити історію повідомлень";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(37, 344);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(419, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(32, 312);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(322, 29);
      this.label1.TabIndex = 3;
      this.label1.Text = "Рівень рідини в капельниці:";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBox1.Location = new System.Drawing.Point(37, 10);
      this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
      this.richTextBox1.Size = new System.Drawing.Size(417, 298);
      this.richTextBox1.TabIndex = 5;
      this.richTextBox1.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(489, 450);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button2);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

