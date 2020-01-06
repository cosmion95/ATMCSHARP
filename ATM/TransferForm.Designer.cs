namespace ATM
{
    partial class TransferForm
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
            this.contLabel = new System.Windows.Forms.Label();
            this.disponibilLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contTextBox = new System.Windows.Forms.TextBox();
            this.NumeTextBox = new System.Windows.Forms.TextBox();
            this.ValoareTextBox = new System.Windows.Forms.TextBox();
            this.MesajTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(319, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "TRANSFER";
            // 
            // contLabel
            // 
            this.contLabel.AutoSize = true;
            this.contLabel.Location = new System.Drawing.Point(12, 56);
            this.contLabel.Name = "contLabel";
            this.contLabel.Size = new System.Drawing.Size(46, 17);
            this.contLabel.TabIndex = 1;
            this.contLabel.Text = "label1";
            // 
            // disponibilLabel
            // 
            this.disponibilLabel.AutoSize = true;
            this.disponibilLabel.Location = new System.Drawing.Point(12, 111);
            this.disponibilLabel.Name = "disponibilLabel";
            this.disponibilLabel.Size = new System.Drawing.Size(46, 17);
            this.disponibilLabel.TabIndex = 2;
            this.disponibilLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "In contul:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mesaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume benficiar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valoare:";
            // 
            // contTextBox
            // 
            this.contTextBox.Location = new System.Drawing.Point(144, 162);
            this.contTextBox.Name = "contTextBox";
            this.contTextBox.Size = new System.Drawing.Size(313, 22);
            this.contTextBox.TabIndex = 6;
            // 
            // NumeTextBox
            // 
            this.NumeTextBox.Location = new System.Drawing.Point(144, 209);
            this.NumeTextBox.Name = "NumeTextBox";
            this.NumeTextBox.Size = new System.Drawing.Size(313, 22);
            this.NumeTextBox.TabIndex = 7;
            // 
            // ValoareTextBox
            // 
            this.ValoareTextBox.Location = new System.Drawing.Point(144, 252);
            this.ValoareTextBox.Name = "ValoareTextBox";
            this.ValoareTextBox.Size = new System.Drawing.Size(313, 22);
            this.ValoareTextBox.TabIndex = 8;
            // 
            // MesajTextBox
            // 
            this.MesajTextBox.Location = new System.Drawing.Point(144, 295);
            this.MesajTextBox.Name = "MesajTextBox";
            this.MesajTextBox.Size = new System.Drawing.Size(313, 22);
            this.MesajTextBox.TabIndex = 9;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(134, 343);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(129, 33);
            this.acceptButton.TabIndex = 10;
            this.acceptButton.Text = "ACCEPTA";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(322, 343);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 33);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "RENUNTA";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(46, 409);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 12;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.MesajTextBox);
            this.Controls.Add(this.ValoareTextBox);
            this.Controls.Add(this.NumeTextBox);
            this.Controls.Add(this.contTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disponibilLabel);
            this.Controls.Add(this.contLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label contLabel;
        private System.Windows.Forms.Label disponibilLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contTextBox;
        private System.Windows.Forms.TextBox NumeTextBox;
        private System.Windows.Forms.TextBox ValoareTextBox;
        private System.Windows.Forms.TextBox MesajTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label infoLabel;
    }
}