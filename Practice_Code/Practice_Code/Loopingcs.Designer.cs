namespace Practice_Code
{
    partial class Loopingcs
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
            this.btnLoop = new System.Windows.Forms.Button();
            this.lbLoop = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(143, 82);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(124, 34);
            this.btnLoop.TabIndex = 0;
            this.btnLoop.Text = "Star Loop";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // lbLoop
            // 
            this.lbLoop.FormattingEnabled = true;
            this.lbLoop.Location = new System.Drawing.Point(143, 169);
            this.lbLoop.Name = "lbLoop";
            this.lbLoop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLoop.Size = new System.Drawing.Size(124, 160);
            this.lbLoop.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(319, 423);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 34);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loopingcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbLoop);
            this.Controls.Add(this.btnLoop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loopingcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loopingcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.ListBox lbLoop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
    }
}