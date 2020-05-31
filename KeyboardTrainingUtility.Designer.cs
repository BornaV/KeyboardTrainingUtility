namespace KeyboardTrainingUtility
{
    partial class mainWindow
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
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.DetectUrls = false;
            this.textBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMain.Location = new System.Drawing.Point(11, 26);
            this.textBoxMain.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ReadOnly = true;
            this.textBoxMain.Size = new System.Drawing.Size(800, 200);
            this.textBoxMain.TabIndex = 0;
            this.textBoxMain.Text = "";
            this.textBoxMain.Enter += new System.EventHandler(this.textBoxMain_Enter);
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
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.DetectUrls = false;
            this.textBoxInput.Location = new System.Drawing.Point(12, 231);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(516, 96);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "";
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 464);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBoxInput);
            this.Name = "mainWindow";
            this.Text = "Keyboard Training Utility";
            this.Enter += new System.EventHandler(this.mainWindow_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBoxMain;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RichTextBox textBoxInput;
    }
}

