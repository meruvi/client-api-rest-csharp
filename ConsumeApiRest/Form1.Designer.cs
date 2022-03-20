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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 261);
            this.Controls.Add(this.btnApiRest2);
            this.Controls.Add(this.btnApiRest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApiRest;
        private System.Windows.Forms.Button btnApiRest2;
    }
}

