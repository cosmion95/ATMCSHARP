namespace ATM
{
    partial class ClientForm
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
            this.accountsList = new System.Windows.Forms.ListBox();
            this.chooseButon = new System.Windows.Forms.Button();
            this.logoutButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(308, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(136, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "nume client";
            // 
            // accountsList
            // 
            this.accountsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsList.FormattingEnabled = true;
            this.accountsList.ItemHeight = 22;
            this.accountsList.Location = new System.Drawing.Point(72, 91);
            this.accountsList.Name = "accountsList";
            this.accountsList.Size = new System.Drawing.Size(406, 224);
            this.accountsList.TabIndex = 1;
            // 
            // chooseButon
            // 
            this.chooseButon.Location = new System.Drawing.Point(84, 377);
            this.chooseButon.Name = "chooseButon";
            this.chooseButon.Size = new System.Drawing.Size(118, 36);
            this.chooseButon.TabIndex = 2;
            this.chooseButon.Text = "ALEGE";
            this.chooseButon.UseVisualStyleBackColor = true;
            this.chooseButon.Click += new System.EventHandler(this.chooseButon_Click);
            // 
            // logoutButon
            // 
            this.logoutButon.Location = new System.Drawing.Point(255, 377);
            this.logoutButon.Name = "logoutButon";
            this.logoutButon.Size = new System.Drawing.Size(133, 36);
            this.logoutButon.TabIndex = 3;
            this.logoutButon.Text = "LOGOUT";
            this.logoutButon.UseVisualStyleBackColor = true;
            this.logoutButon.Click += new System.EventHandler(this.logoutButon_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButon);
            this.Controls.Add(this.chooseButon);
            this.Controls.Add(this.accountsList);
            this.Controls.Add(this.titleLabel);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox accountsList;
        private System.Windows.Forms.Button chooseButon;
        private System.Windows.Forms.Button logoutButon;
    }
}