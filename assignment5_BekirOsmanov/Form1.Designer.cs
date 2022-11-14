namespace assignment5_BekirOsmanov
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guess_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(281, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUESS THE NUMBER GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(297, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numbers range: 1 - 100";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(451, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guess!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guess_box
            // 
            this.guess_box.Location = new System.Drawing.Point(281, 281);
            this.guess_box.Multiline = true;
            this.guess_box.Name = "guess_box";
            this.guess_box.Size = new System.Drawing.Size(128, 42);
            this.guess_box.TabIndex = 3;
            this.guess_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guess_box_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Take your guess:";
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.info_lbl.Location = new System.Drawing.Point(362, 356);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(93, 30);
            this.info_lbl.TabIndex = 5;
            this.info_lbl.Text = "let it go!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(815, 411);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guess_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox guess_box;
        private Label label3;
        private Label info_lbl;
    }
}