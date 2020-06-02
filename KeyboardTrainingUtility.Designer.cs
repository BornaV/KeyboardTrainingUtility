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
            this.buttonAddText = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonRandomText = new System.Windows.Forms.Button();
            this.buttonRandomLetter = new System.Windows.Forms.Button();
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
            // buttonAddText
            // 
            this.buttonAddText.Location = new System.Drawing.Point(30, 378);
            this.buttonAddText.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(64, 40);
            this.buttonAddText.TabIndex = 1;
            this.buttonAddText.Text = "Add Text";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.startButton_Click);
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
            // buttonRandomText
            // 
            this.buttonRandomText.Location = new System.Drawing.Point(98, 378);
            this.buttonRandomText.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomText.Name = "buttonRandomText";
            this.buttonRandomText.Size = new System.Drawing.Size(110, 40);
            this.buttonRandomText.TabIndex = 1;
            this.buttonRandomText.Text = "Add Random Text";
            this.buttonRandomText.UseVisualStyleBackColor = true;
            this.buttonRandomText.Click += new System.EventHandler(this.buttonRadnomText_Click);
            // 
            // buttonRandomLetter
            // 
            this.buttonRandomLetter.Location = new System.Drawing.Point(212, 378);
            this.buttonRandomLetter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomLetter.Name = "buttonRandomLetter";
            this.buttonRandomLetter.Size = new System.Drawing.Size(110, 40);
            this.buttonRandomLetter.TabIndex = 1;
            this.buttonRandomLetter.Text = "Add Random Letter Sequance";
            this.buttonRandomLetter.UseVisualStyleBackColor = true;
            this.buttonRandomLetter.Click += new System.EventHandler(this.buttonRadnomLetter_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 464);
            this.Controls.Add(this.buttonRandomLetter);
            this.Controls.Add(this.buttonRandomText);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.buttonAddText);
            this.Controls.Add(this.textBoxInput);
            this.Name = "mainWindow";
            this.Text = "Keyboard Training Utility";
            this.Enter += new System.EventHandler(this.mainWindow_Enter);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBoxMain;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Button buttonRandomText;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.Button buttonRandomLetter;
    }
}

