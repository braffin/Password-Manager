namespace PasswordManager
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
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NEWACCOUNTBUTTON = new System.Windows.Forms.Button();
            this.LISTACCOUNTSBUTTON = new System.Windows.Forms.Button();
            this.CHANGEINFORMATIONBUTTON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.changeusernamebox = new System.Windows.Forms.TextBox();
            this.changepasswordbox = new System.Windows.Forms.TextBox();
            this.newaccountbox = new System.Windows.Forms.TextBox();
            this.newusernamebox = new System.Windows.Forms.TextBox();
            this.newpasswordbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(526, 14);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(168, 276);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 310);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Debug";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(17, 14);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(501, 254);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // NEWACCOUNTBUTTON
            // 
            this.NEWACCOUNTBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NEWACCOUNTBUTTON.Location = new System.Drawing.Point(16, 295);
            this.NEWACCOUNTBUTTON.Name = "NEWACCOUNTBUTTON";
            this.NEWACCOUNTBUTTON.Size = new System.Drawing.Size(66, 44);
            this.NEWACCOUNTBUTTON.TabIndex = 3;
            this.NEWACCOUNTBUTTON.Text = "New Account";
            this.NEWACCOUNTBUTTON.UseVisualStyleBackColor = true;
            this.NEWACCOUNTBUTTON.Click += new System.EventHandler(this.NEWACCOUNT_CLICK);
            // 
            // LISTACCOUNTSBUTTON
            // 
            this.LISTACCOUNTSBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LISTACCOUNTSBUTTON.Location = new System.Drawing.Point(160, 295);
            this.LISTACCOUNTSBUTTON.Name = "LISTACCOUNTSBUTTON";
            this.LISTACCOUNTSBUTTON.Size = new System.Drawing.Size(66, 44);
            this.LISTACCOUNTSBUTTON.TabIndex = 5;
            this.LISTACCOUNTSBUTTON.Text = "List Accounts";
            this.LISTACCOUNTSBUTTON.UseVisualStyleBackColor = true;
            this.LISTACCOUNTSBUTTON.Click += new System.EventHandler(this.LISTACCOUNTS_CLICK);
            // 
            // CHANGEINFORMATIONBUTTON
            // 
            this.CHANGEINFORMATIONBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHANGEINFORMATIONBUTTON.Location = new System.Drawing.Point(232, 296);
            this.CHANGEINFORMATIONBUTTON.Name = "CHANGEINFORMATIONBUTTON";
            this.CHANGEINFORMATIONBUTTON.Size = new System.Drawing.Size(68, 42);
            this.CHANGEINFORMATIONBUTTON.TabIndex = 6;
            this.CHANGEINFORMATIONBUTTON.Text = "Change Information";
            this.CHANGEINFORMATIONBUTTON.UseVisualStyleBackColor = true;
            this.CHANGEINFORMATIONBUTTON.Click += new System.EventHandler(this.CHANGEINFORMATION_CLICK);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(306, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DELETEBUTTON_CLICK);
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(92, 272);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(426, 20);
            this.inputText.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 13);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Account Input:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(88, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Get Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetPasswordButton_Click);
            // 
            // changeusernamebox
            // 
            this.changeusernamebox.Location = new System.Drawing.Point(232, 337);
            this.changeusernamebox.Name = "changeusernamebox";
            this.changeusernamebox.Size = new System.Drawing.Size(10, 20);
            this.changeusernamebox.TabIndex = 12;
            this.changeusernamebox.Visible = false;
            // 
            // changepasswordbox
            // 
            this.changepasswordbox.Location = new System.Drawing.Point(248, 337);
            this.changepasswordbox.Name = "changepasswordbox";
            this.changepasswordbox.Size = new System.Drawing.Size(10, 20);
            this.changepasswordbox.TabIndex = 13;
            this.changepasswordbox.Visible = false;
            // 
            // newaccountbox
            // 
            this.newaccountbox.Location = new System.Drawing.Point(17, 337);
            this.newaccountbox.Name = "newaccountbox";
            this.newaccountbox.Size = new System.Drawing.Size(10, 20);
            this.newaccountbox.TabIndex = 14;
            this.newaccountbox.Visible = false;
            // 
            // newusernamebox
            // 
            this.newusernamebox.Location = new System.Drawing.Point(33, 337);
            this.newusernamebox.Name = "newusernamebox";
            this.newusernamebox.Size = new System.Drawing.Size(10, 20);
            this.newusernamebox.TabIndex = 15;
            this.newusernamebox.Visible = false;
            // 
            // newpasswordbox
            // 
            this.newpasswordbox.Location = new System.Drawing.Point(49, 337);
            this.newpasswordbox.Name = "newpasswordbox";
            this.newpasswordbox.Size = new System.Drawing.Size(8, 20);
            this.newpasswordbox.TabIndex = 16;
            this.newpasswordbox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 369);
            this.Controls.Add(this.newpasswordbox);
            this.Controls.Add(this.newusernamebox);
            this.Controls.Add(this.newaccountbox);
            this.Controls.Add(this.changepasswordbox);
            this.Controls.Add(this.changeusernamebox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CHANGEINFORMATIONBUTTON);
            this.Controls.Add(this.LISTACCOUNTSBUTTON);
            this.Controls.Add(this.NEWACCOUNTBUTTON);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LogBox);
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button NEWACCOUNTBUTTON;
        private System.Windows.Forms.Button LISTACCOUNTSBUTTON;
        private System.Windows.Forms.Button CHANGEINFORMATIONBUTTON;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox changeusernamebox;
        public System.Windows.Forms.TextBox changepasswordbox;
        public System.Windows.Forms.TextBox newaccountbox;
        public System.Windows.Forms.TextBox newusernamebox;
        public System.Windows.Forms.TextBox newpasswordbox;
    }
}

