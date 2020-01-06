namespace ATM
{
    partial class ExtragereDepunere
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
            this.valoareTextBox = new System.Windows.Forms.TextBox();
            this.okButon = new System.Windows.Forms.Button();
            this.renuntaButon = new System.Windows.Forms.Button();
            this.disponibilLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(302, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "titlu";
            // 
            // valoareTextBox
            // 
            this.valoareTextBox.Location = new System.Drawing.Point(59, 149);
            this.valoareTextBox.Name = "valoareTextBox";
            this.valoareTextBox.Size = new System.Drawing.Size(163, 22);
            this.valoareTextBox.TabIndex = 2;
            // 
            // okButon
            // 
            this.okButon.Location = new System.Drawing.Point(59, 236);
            this.okButon.Name = "okButon";
            this.okButon.Size = new System.Drawing.Size(93, 29);
            this.okButon.TabIndex = 3;
            this.okButon.Text = "ACCEPTA";
            this.okButon.UseVisualStyleBackColor = true;
            this.okButon.Click += new System.EventHandler(this.okButon_Click);
            // 
            // renuntaButon
            // 
            this.renuntaButon.Location = new System.Drawing.Point(216, 236);
            this.renuntaButon.Name = "renuntaButon";
            this.renuntaButon.Size = new System.Drawing.Size(93, 29);
            this.renuntaButon.TabIndex = 4;
            this.renuntaButon.Text = "RENUNTA";
            this.renuntaButon.UseVisualStyleBackColor = true;
            // 
            // disponibilLabel
            // 
            this.disponibilLabel.AutoSize = true;
            this.disponibilLabel.Location = new System.Drawing.Point(56, 94);
            this.disponibilLabel.Name = "disponibilLabel";
            this.disponibilLabel.Size = new System.Drawing.Size(67, 17);
            this.disponibilLabel.TabIndex = 5;
            this.disponibilLabel.Text = "disponibil";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(59, 355);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 25);
            this.infoLabel.TabIndex = 6;
            // 
            // ExtragereDepunere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.disponibilLabel);
            this.Controls.Add(this.renuntaButon);
            this.Controls.Add(this.okButon);
            this.Controls.Add(this.valoareTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "ExtragereDepunere";
            this.Text = "ExtragereDepunere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox valoareTextBox;
        private System.Windows.Forms.Button okButon;
        private System.Windows.Forms.Button renuntaButon;
        private System.Windows.Forms.Label disponibilLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}