namespace GCodeSimplifyer
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
            this.btn_Convert = new System.Windows.Forms.Button();
            this.tb_in = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_out = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_switch = new System.Windows.Forms.Button();
            this.tb_console = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pgb_progress = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(12, 12);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(110, 23);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "Remove Decimals";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(12, 58);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(456, 154);
            this.tb_in.TabIndex = 1;
            this.tb_in.Text = "";
            this.tb_in.TextChanged += new System.EventHandler(this.tb_in_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(12, 263);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(456, 255);
            this.tb_out.TabIndex = 3;
            this.tb_out.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(180, 224);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(122, 23);
            this.btn_switch.TabIndex = 5;
            this.btn_switch.Text = "Input <-> Output";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(12, 524);
            this.tb_console.Name = "tb_console";
            this.tb_console.Size = new System.Drawing.Size(456, 70);
            this.tb_console.TabIndex = 6;
            this.tb_console.Text = "";
            this.tb_console.TextChanged += new System.EventHandler(this.tb_console_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove Clones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pgb_progress
            // 
            this.pgb_progress.Location = new System.Drawing.Point(239, 11);
            this.pgb_progress.Name = "pgb_progress";
            this.pgb_progress.Size = new System.Drawing.Size(229, 23);
            this.pgb_progress.TabIndex = 8;
            this.pgb_progress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Copy 2 Clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 604);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pgb_progress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_in);
            this.Controls.Add(this.btn_Convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCodeSimplifyer v0.1 (c)stryct 2015";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.RichTextBox tb_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tb_out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_switch;
        private System.Windows.Forms.RichTextBox tb_console;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pgb_progress;
        private System.Windows.Forms.Button button2;
    }
}

