namespace KeyboardTrainingUtility
{
    partial class KTUMain
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
            this.textBoxMain = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.DetectUrls = false;
            this.textBoxMain.Location = new System.Drawing.Point(11, 26);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(800, 200);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Text = "";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(30, 378);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Add Text";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // KTUMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 426);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBoxMain);
            this.Name = "KTUMain";
            this.Text = "Keyboard Training Utility";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBoxMain;
        private System.Windows.Forms.Button startButton;
    }
}

