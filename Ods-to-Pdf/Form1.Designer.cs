namespace Ods_to_Pdf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button3 = new Button();
            FilenameOutput = new Label();
            Filename = new Label();
            button2 = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(FilenameOutput);
            groupBox1.Controls.Add(Filename);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(33, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(672, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            button3.Location = new Point(43, 120);
            button3.Name = "button3";
            button3.Size = new Size(140, 42);
            button3.TabIndex = 5;
            button3.Text = "Input File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FilenameOutput
            // 
            FilenameOutput.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FilenameOutput.Location = new Point(132, 37);
            FilenameOutput.Name = "FilenameOutput";
            FilenameOutput.Size = new Size(475, 39);
            FilenameOutput.TabIndex = 4;
            // 
            // Filename
            // 
            Filename.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Filename.ForeColor = SystemColors.ControlText;
            Filename.Location = new Point(17, 37);
            Filename.Name = "Filename";
            Filename.Size = new Size(145, 39);
            Filename.TabIndex = 3;
            Filename.Text = "Filename :";
            // 
            // button2
            // 
            button2.Location = new Point(402, 120);
            button2.Name = "button2";
            button2.Size = new Size(134, 42);
            button2.TabIndex = 2;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(225, 120);
            button1.Name = "button1";
            button1.Size = new Size(134, 42);
            button1.TabIndex = 1;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 204);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label Filename;
        private Label FilenameOutput;
        private Button button3;
        private OpenFileDialog openFileDialog2;
    }
}