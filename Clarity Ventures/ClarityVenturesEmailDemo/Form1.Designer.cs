
namespace ClarityVenturesEmailDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.recipientText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.subjectText = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 23);
            this.textBox1.TabIndex = 0;
            // 
            // recipientText
            // 
            this.recipientText.AutoSize = true;
            this.recipientText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recipientText.Location = new System.Drawing.Point(59, 197);
            this.recipientText.Name = "recipientText";
            this.recipientText.Size = new System.Drawing.Size(25, 17);
            this.recipientText.TabIndex = 1;
            this.recipientText.Text = "To:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(388, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 144);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(90, 425);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(177, 32);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // subjectText
            // 
            this.subjectText.AutoSize = true;
            this.subjectText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subjectText.Location = new System.Drawing.Point(29, 226);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(55, 17);
            this.subjectText.TabIndex = 5;
            this.subjectText.Text = "Subject:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(409, 23);
            this.textBox2.TabIndex = 4;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageText.Location = new System.Drawing.Point(20, 255);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(64, 17);
            this.messageText.TabIndex = 7;
            this.messageText.Text = "Message:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 254);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(409, 165);
            this.textBox3.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeButton.Location = new System.Drawing.Point(322, 425);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(177, 32);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 494);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipientText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label recipientText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label subjectText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label messageText;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button closeButton;
    }
}

