﻿namespace pGina.Plugin.krb5Auth
{
    partial class Configuration
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
            this.label1 = new System.Windows.Forms.Label();
            this.rText = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentRealmText = new System.Windows.Forms.Label();
            this.currentRealmLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realm:";
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(52, 24);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(214, 20);
            this.rText.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(397, 305);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(6, 57);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(251, 38);
            this.description.TabIndex = 3;
            this.description.Text = "The realm is the fully qualified target domain name that you will be authenticati" +
    "ng against.";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(316, 305);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentRealmText);
            this.groupBox1.Controls.Add(this.currentRealmLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rText);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kerberos Settings";
            // 
            // currentRealmText
            // 
            this.currentRealmText.AutoSize = true;
            this.currentRealmText.Location = new System.Drawing.Point(93, 99);
            this.currentRealmText.Name = "currentRealmText";
            this.currentRealmText.Size = new System.Drawing.Size(35, 13);
            this.currentRealmText.TabIndex = 5;
            this.currentRealmText.Text = "label3";
            // 
            // currentRealmLabel
            // 
            this.currentRealmLabel.AutoSize = true;
            this.currentRealmLabel.Location = new System.Drawing.Point(9, 99);
            this.currentRealmLabel.Name = "currentRealmLabel";
            this.currentRealmLabel.Size = new System.Drawing.Size(77, 13);
            this.currentRealmLabel.TabIndex = 4;
            this.currentRealmLabel.Text = "Current Realm:";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Name = "Configuration";
            this.Text = "KRB5 Realm Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rText;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label currentRealmText;
        private System.Windows.Forms.Label currentRealmLabel;
    }
}