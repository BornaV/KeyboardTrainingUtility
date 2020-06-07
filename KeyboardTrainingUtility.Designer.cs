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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.textBoxMain = new System.Windows.Forms.RichTextBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.buttonRandomText = new System.Windows.Forms.Button();
            this.buttonRandomLetter = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.trackBarUpperCase = new System.Windows.Forms.TrackBar();
            this.labelTrackBarValue = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.checkBoxRenew = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpperCase)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMain
            // 
            this.textBoxMain.DetectUrls = false;
            this.textBoxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMain.Location = new System.Drawing.Point(11, 11);
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
            this.buttonAddText.Location = new System.Drawing.Point(11, 241);
            this.buttonAddText.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(64, 45);
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
            this.textBoxInput.Location = new System.Drawing.Point(12, 115);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(516, 96);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "";
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // buttonRandomText
            // 
            this.buttonRandomText.Location = new System.Drawing.Point(79, 241);
            this.buttonRandomText.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomText.Name = "buttonRandomText";
            this.buttonRandomText.Size = new System.Drawing.Size(110, 45);
            this.buttonRandomText.TabIndex = 1;
            this.buttonRandomText.Text = "Add Random Text";
            this.buttonRandomText.UseVisualStyleBackColor = true;
            this.buttonRandomText.Click += new System.EventHandler(this.buttonRadnomText_Click);
            // 
            // buttonRandomLetter
            // 
            this.buttonRandomLetter.Location = new System.Drawing.Point(193, 241);
            this.buttonRandomLetter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomLetter.Name = "buttonRandomLetter";
            this.buttonRandomLetter.Size = new System.Drawing.Size(110, 45);
            this.buttonRandomLetter.TabIndex = 1;
            this.buttonRandomLetter.Text = "Add Random Letter Sequance";
            this.buttonRandomLetter.UseVisualStyleBackColor = true;
            this.buttonRandomLetter.Click += new System.EventHandler(this.buttonRadnomLetter_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(459, 241);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(24, 23);
            this.textBoxAmount.TabIndex = 3;
            this.textBoxAmount.Text = "50";
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trackBarUpperCase
            // 
            this.trackBarUpperCase.LargeChange = 1;
            this.trackBarUpperCase.Location = new System.Drawing.Point(308, 241);
            this.trackBarUpperCase.Maximum = 100;
            this.trackBarUpperCase.Name = "trackBarUpperCase";
            this.trackBarUpperCase.Size = new System.Drawing.Size(145, 45);
            this.trackBarUpperCase.TabIndex = 4;
            this.trackBarUpperCase.ValueChanged += new System.EventHandler(this.trackBarUpperCase_ValueChanged);
            // 
            // labelTrackBarValue
            // 
            this.labelTrackBarValue.AutoSize = true;
            this.labelTrackBarValue.Location = new System.Drawing.Point(314, 271);
            this.labelTrackBarValue.Name = "labelTrackBarValue";
            this.labelTrackBarValue.Size = new System.Drawing.Size(139, 15);
            this.labelTrackBarValue.TabIndex = 5;
            this.labelTrackBarValue.Text = "Upper Case Amount: 0 %";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(459, 271);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(51, 15);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Amount";
            // 
            // checkBoxRenew
            // 
            this.checkBoxRenew.AutoSize = true;
            this.checkBoxRenew.Location = new System.Drawing.Point(513, 241);
            this.checkBoxRenew.Name = "checkBoxRenew";
            this.checkBoxRenew.Size = new System.Drawing.Size(90, 19);
            this.checkBoxRenew.TabIndex = 7;
            this.checkBoxRenew.Text = "Auto Renew";
            this.checkBoxRenew.UseVisualStyleBackColor = true;
            this.checkBoxRenew.Enter += new System.EventHandler(this.checkBoxRenew_Enter);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 301);
            this.Controls.Add(this.textBoxMain);
            this.Controls.Add(this.checkBoxRenew);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTrackBarValue);
            this.Controls.Add(this.trackBarUpperCase);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonRandomLetter);
            this.Controls.Add(this.buttonRandomText);
            this.Controls.Add(this.buttonAddText);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Keyboard Training Utility";
            this.Enter += new System.EventHandler(this.mainWindow_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpperCase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox textBoxMain;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Button buttonRandomText;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.Button buttonRandomLetter;
        private System.Windows.Forms.TextBox textBoxAmount;
        public System.Windows.Forms.TrackBar trackBarUpperCase;
        private System.Windows.Forms.Label labelTrackBarValue;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.CheckBox checkBoxRenew;
    }
}

