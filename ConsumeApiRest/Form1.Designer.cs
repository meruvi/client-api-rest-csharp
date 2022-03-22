namespace ConsumeApiRest
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
            this.btnApiRest = new System.Windows.Forms.Button();
            this.btnApiRest2 = new System.Windows.Forms.Button();
            this.btnRestSharp = new System.Windows.Forms.Button();
            this.restSharpAwait = new System.Windows.Forms.Button();
            this.btnApiRestHeader = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnApiRest
            // 
            this.btnApiRest.Location = new System.Drawing.Point(41, 26);
            this.btnApiRest.Name = "btnApiRest";
            this.btnApiRest.Size = new System.Drawing.Size(170, 32);
            this.btnApiRest.TabIndex = 0;
            this.btnApiRest.Text = "API REST METHOD 1";
            this.btnApiRest.UseVisualStyleBackColor = true;
            this.btnApiRest.Click += new System.EventHandler(this.btnApiRest_Click);
            // 
            // btnApiRest2
            // 
            this.btnApiRest2.Location = new System.Drawing.Point(41, 64);
            this.btnApiRest2.Name = "btnApiRest2";
            this.btnApiRest2.Size = new System.Drawing.Size(170, 32);
            this.btnApiRest2.TabIndex = 1;
            this.btnApiRest2.Text = "API REST METHOD 2";
            this.btnApiRest2.UseVisualStyleBackColor = true;
            this.btnApiRest2.Click += new System.EventHandler(this.btnApiRest2_Click);
            // 
            // btnRestSharp
            // 
            this.btnRestSharp.Location = new System.Drawing.Point(247, 26);
            this.btnRestSharp.Name = "btnRestSharp";
            this.btnRestSharp.Size = new System.Drawing.Size(170, 32);
            this.btnRestSharp.TabIndex = 2;
            this.btnRestSharp.Text = "API REST RESTSHARP";
            this.btnRestSharp.UseVisualStyleBackColor = true;
            this.btnRestSharp.Click += new System.EventHandler(this.btnRestSharp_Click);
            // 
            // restSharpAwait
            // 
            this.restSharpAwait.Location = new System.Drawing.Point(247, 64);
            this.restSharpAwait.Name = "restSharpAwait";
            this.restSharpAwait.Size = new System.Drawing.Size(184, 32);
            this.restSharpAwait.TabIndex = 3;
            this.restSharpAwait.Text = "API REST RESTSHARP AWAIT";
            this.restSharpAwait.UseVisualStyleBackColor = true;
            this.restSharpAwait.Click += new System.EventHandler(this.restSharpAwait_Click);
            // 
            // btnApiRestHeader
            // 
            this.btnApiRestHeader.Location = new System.Drawing.Point(41, 102);
            this.btnApiRestHeader.Name = "btnApiRestHeader";
            this.btnApiRestHeader.Size = new System.Drawing.Size(170, 32);
            this.btnApiRestHeader.TabIndex = 4;
            this.btnApiRestHeader.Text = "API REST HEADER";
            this.btnApiRestHeader.UseVisualStyleBackColor = true;
            this.btnApiRestHeader.Click += new System.EventHandler(this.btnApiRestHeader_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(41, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "API REST LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnApiRestHeader);
            this.Controls.Add(this.restSharpAwait);
            this.Controls.Add(this.btnRestSharp);
            this.Controls.Add(this.btnApiRest2);
            this.Controls.Add(this.btnApiRest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApiRest;
        private System.Windows.Forms.Button btnApiRest2;
        private System.Windows.Forms.Button btnRestSharp;
        private System.Windows.Forms.Button restSharpAwait;
        private System.Windows.Forms.Button btnApiRestHeader;
        private System.Windows.Forms.Button btnLogin;
    }
}

