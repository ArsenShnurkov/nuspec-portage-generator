using System.Windows.Forms;
using System.Drawing;

namespace WinFormsGUI
{
	partial class DialogEbuildProperties
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
            this.components = new System.ComponentModel.Container();
			this.userControlClassAndName = new EbuildPropertiesControl();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 308);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(470, 46);
            this.buttonPanel.TabIndex = 2;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cancelButton.Location = new System.Drawing.Point(302, 11);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.okButton.Location = new System.Drawing.Point(383, 11);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);

			this.userControlClassAndName.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
			int width = 400; //this.userControlClassAndName.Size.Width;
			int height = this.userControlClassAndName.Size.Height + this.buttonPanel.Size.Height;
			this.ClientSize = new System.Drawing.Size(width, height);
			this.Controls.Add(this.userControlClassAndName);
            this.Controls.Add(this.buttonPanel);
            this.Name = "DialogEbuildProperties";
            this.Text = "Ebuild Properties Dialog";
            this.Load += new System.EventHandler(this.OptionsDialog_Load);



            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private EbuildPropertiesControl userControlClassAndName;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
    }
}

