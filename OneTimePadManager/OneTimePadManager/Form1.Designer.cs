namespace OneTimePadManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.userInputGroupBox = new System.Windows.Forms.GroupBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.manualTxtInputGroupBox = new System.Windows.Forms.RadioButton();
            this.inputChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.keyFileRadioButton = new System.Windows.Forms.RadioButton();
            this.keyTextUpload = new System.Windows.Forms.RadioButton();
            this.fileIORadioButton = new System.Windows.Forms.RadioButton();
            this.keyGroupBox = new System.Windows.Forms.GroupBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.userInputGroupBox.SuspendLayout();
            this.inputChoiceGroupBox.SuspendLayout();
            this.keyGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(6, 19);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(179, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // userInputGroupBox
            // 
            this.userInputGroupBox.Controls.Add(this.inputTextBox);
            this.userInputGroupBox.Location = new System.Drawing.Point(37, 105);
            this.userInputGroupBox.Name = "userInputGroupBox";
            this.userInputGroupBox.Size = new System.Drawing.Size(200, 55);
            this.userInputGroupBox.TabIndex = 1;
            this.userInputGroupBox.TabStop = false;
            this.userInputGroupBox.Text = "User Input";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(256, 34);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(363, 160);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = resources.GetString("noteLabel.Text");
            // 
            // manualTxtInputGroupBox
            // 
            this.manualTxtInputGroupBox.AutoSize = true;
            this.manualTxtInputGroupBox.Location = new System.Drawing.Point(6, 19);
            this.manualTxtInputGroupBox.Name = "manualTxtInputGroupBox";
            this.manualTxtInputGroupBox.Size = new System.Drawing.Size(46, 17);
            this.manualTxtInputGroupBox.TabIndex = 1;
            this.manualTxtInputGroupBox.TabStop = true;
            this.manualTxtInputGroupBox.Text = "Text";
            this.manualTxtInputGroupBox.UseVisualStyleBackColor = true;
            // 
            // inputChoiceGroupBox
            // 
            this.inputChoiceGroupBox.Controls.Add(this.keyFileRadioButton);
            this.inputChoiceGroupBox.Controls.Add(this.keyTextUpload);
            this.inputChoiceGroupBox.Controls.Add(this.fileIORadioButton);
            this.inputChoiceGroupBox.Controls.Add(this.manualTxtInputGroupBox);
            this.inputChoiceGroupBox.Location = new System.Drawing.Point(37, 34);
            this.inputChoiceGroupBox.Name = "inputChoiceGroupBox";
            this.inputChoiceGroupBox.Size = new System.Drawing.Size(200, 65);
            this.inputChoiceGroupBox.TabIndex = 2;
            this.inputChoiceGroupBox.TabStop = false;
            this.inputChoiceGroupBox.Text = "Input Choice";
            // 
            // keyFileRadioButton
            // 
            this.keyFileRadioButton.AutoSize = true;
            this.keyFileRadioButton.Location = new System.Drawing.Point(90, 42);
            this.keyFileRadioButton.Name = "keyFileRadioButton";
            this.keyFileRadioButton.Size = new System.Drawing.Size(99, 17);
            this.keyFileRadioButton.TabIndex = 4;
            this.keyFileRadioButton.TabStop = true;
            this.keyFileRadioButton.Text = "Key File Upload";
            this.keyFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // keyTextUpload
            // 
            this.keyTextUpload.AutoSize = true;
            this.keyTextUpload.Location = new System.Drawing.Point(90, 19);
            this.keyTextUpload.Name = "keyTextUpload";
            this.keyTextUpload.Size = new System.Drawing.Size(104, 17);
            this.keyTextUpload.TabIndex = 3;
            this.keyTextUpload.TabStop = true;
            this.keyTextUpload.Text = "Key Text Upload";
            this.keyTextUpload.UseVisualStyleBackColor = true;
            // 
            // fileIORadioButton
            // 
            this.fileIORadioButton.AutoSize = true;
            this.fileIORadioButton.Location = new System.Drawing.Point(6, 42);
            this.fileIORadioButton.Name = "fileIORadioButton";
            this.fileIORadioButton.Size = new System.Drawing.Size(78, 17);
            this.fileIORadioButton.TabIndex = 2;
            this.fileIORadioButton.TabStop = true;
            this.fileIORadioButton.Text = "File Upload";
            this.fileIORadioButton.UseVisualStyleBackColor = true;
            // 
            // keyGroupBox
            // 
            this.keyGroupBox.Controls.Add(this.keyTextBox);
            this.keyGroupBox.Location = new System.Drawing.Point(37, 166);
            this.keyGroupBox.Name = "keyGroupBox";
            this.keyGroupBox.Size = new System.Drawing.Size(200, 50);
            this.keyGroupBox.TabIndex = 2;
            this.keyGroupBox.TabStop = false;
            this.keyGroupBox.Text = "Key Input";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(6, 19);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(179, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(6, 16);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(31, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Info: ";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(37, 222);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(534, 236);
            this.outputGroupBox.TabIndex = 2;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Decrypted Message";
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(260, 178);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(85, 38);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(351, 178);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(85, 38);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 609);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.keyGroupBox);
            this.Controls.Add(this.inputChoiceGroupBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.userInputGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.userInputGroupBox.ResumeLayout(false);
            this.userInputGroupBox.PerformLayout();
            this.inputChoiceGroupBox.ResumeLayout(false);
            this.inputChoiceGroupBox.PerformLayout();
            this.keyGroupBox.ResumeLayout(false);
            this.keyGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox userInputGroupBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.RadioButton manualTxtInputGroupBox;
        private System.Windows.Forms.GroupBox inputChoiceGroupBox;
        private System.Windows.Forms.RadioButton fileIORadioButton;
        private System.Windows.Forms.RadioButton keyFileRadioButton;
        private System.Windows.Forms.RadioButton keyTextUpload;
        private System.Windows.Forms.GroupBox keyGroupBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
    }
}

