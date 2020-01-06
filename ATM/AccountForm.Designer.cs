namespace ATM
{
    partial class AccountForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.disponibilLabel = new System.Windows.Forms.Label();
            this.operatiiLabel = new System.Windows.Forms.Label();
            this.extrageButon = new System.Windows.Forms.Button();
            this.depunereButon = new System.Windows.Forms.Button();
            this.transferLabel = new System.Windows.Forms.Button();
            this.backButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(52, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "titlu";
            // 
            // disponibilLabel
            // 
            this.disponibilLabel.AutoSize = true;
            this.disponibilLabel.Location = new System.Drawing.Point(55, 71);
            this.disponibilLabel.Name = "disponibilLabel";
            this.disponibilLabel.Size = new System.Drawing.Size(67, 17);
            this.disponibilLabel.TabIndex = 1;
            this.disponibilLabel.Text = "disponibil";
            // 
            // operatiiLabel
            // 
            this.operatiiLabel.AutoSize = true;
            this.operatiiLabel.Location = new System.Drawing.Point(13, 122);
            this.operatiiLabel.Name = "operatiiLabel";
            this.operatiiLabel.Size = new System.Drawing.Size(149, 17);
            this.operatiiLabel.TabIndex = 2;
            this.operatiiLabel.Text = "Operatiuni disponibile:";
            // 
            // extrageButon
            // 
            this.extrageButon.Location = new System.Drawing.Point(29, 167);
            this.extrageButon.Name = "extrageButon";
            this.extrageButon.Size = new System.Drawing.Size(133, 46);
            this.extrageButon.TabIndex = 3;
            this.extrageButon.Text = "EXTRAGERE";
            this.extrageButon.UseVisualStyleBackColor = true;
            this.extrageButon.Click += new System.EventHandler(this.extrageButon_Click);
            // 
            // depunereButon
            // 
            this.depunereButon.Location = new System.Drawing.Point(29, 235);
            this.depunereButon.Name = "depunereButon";
            this.depunereButon.Size = new System.Drawing.Size(133, 46);
            this.depunereButon.TabIndex = 4;
            this.depunereButon.Text = "DEPUNERE";
            this.depunereButon.UseVisualStyleBackColor = true;
            this.depunereButon.Click += new System.EventHandler(this.depunereButon_Click);
            // 
            // transferLabel
            // 
            this.transferLabel.Location = new System.Drawing.Point(29, 301);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(133, 46);
            this.transferLabel.TabIndex = 5;
            this.transferLabel.Text = "TRANSFERA";
            this.transferLabel.UseVisualStyleBackColor = true;
            this.transferLabel.Click += new System.EventHandler(this.transferLabel_Click);
            // 
            // backButon
            // 
            this.backButon.Location = new System.Drawing.Point(29, 401);
            this.backButon.Name = "backButon";
            this.backButon.Size = new System.Drawing.Size(133, 23);
            this.backButon.TabIndex = 6;
            this.backButon.Text = "Alege alt cont";
            this.backButon.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButon);
            this.Controls.Add(this.transferLabel);
            this.Controls.Add(this.depunereButon);
            this.Controls.Add(this.extrageButon);
            this.Controls.Add(this.operatiiLabel);
            this.Controls.Add(this.disponibilLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label disponibilLabel;
        private System.Windows.Forms.Label operatiiLabel;
        private System.Windows.Forms.Button extrageButon;
        private System.Windows.Forms.Button depunereButon;
        private System.Windows.Forms.Button transferLabel;
        private System.Windows.Forms.Button backButon;
    }
}