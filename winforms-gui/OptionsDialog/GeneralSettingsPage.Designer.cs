using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI
{
	partial class GeneralSettingsPage
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
			this.radioButton_UsePortage = new System.Windows.Forms.RadioButton();
			this.radioButton_UseLayman = new System.Windows.Forms.RadioButton();
			this.nuspecLabel = new System.Windows.Forms.Label();
			this.nuspecPath = new System.Windows.Forms.TextBox();
			this.ebuildLabel = new System.Windows.Forms.Label();
			this.ebuildPath = new System.Windows.Forms.TextBox();

			// 
			this.radioButton_UsePortage.AutoSize = true;
			this.radioButton_UsePortage.Location = new System.Drawing.Point(4, 4);
			this.radioButton_UsePortage.Name = "radioButton_UsePortage";
			this.radioButton_UsePortage.Size = new System.Drawing.Size(263, 17);
			this.radioButton_UsePortage.TabIndex = 0;
			this.radioButton_UsePortage.Text = "Use main portage tree";
			this.radioButton_UsePortage.Enabled = false;
			this.radioButton_UsePortage.UseVisualStyleBackColor = true;
			// 
			this.radioButton_UseLayman.AutoSize = true;
			this.radioButton_UseLayman.Location = new System.Drawing.Point(4, 28);
			this.radioButton_UseLayman.Name = "radioButton_UseLayman";
			this.radioButton_UseLayman.Size = new System.Drawing.Size(174, 17);
			this.radioButton_UseLayman.TabIndex = 1;
			this.radioButton_UseLayman.Enabled = false;
			this.radioButton_UseLayman.Text = "Use one of overlays from layman";
			this.radioButton_UseLayman.UseVisualStyleBackColor = true;
			// 
			this.nuspecLabel.AutoSize = true;
			this.nuspecLabel.Location = new System.Drawing.Point(20, 100);
			this.nuspecLabel.Name = "nuspecLabel";
			this.nuspecLabel.Size = new System.Drawing.Size(281, 70);
			this.nuspecLabel.TabIndex = 4;
			this.nuspecLabel.Text = ".nuspec location:";
			// 
			this.nuspecPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.nuspecPath.Location = new System.Drawing.Point(20, 120);
			this.nuspecPath.Name = "nuspecPath";
			this.nuspecPath.Size = new System.Drawing.Size(281, 70);
			this.nuspecPath.TabIndex = 5;
			// 
			this.ebuildLabel.AutoSize = true;
			this.ebuildLabel.Location = new System.Drawing.Point(20, 160);
			this.ebuildLabel.Name = "ebuildLabel";
			this.ebuildLabel.Size = new System.Drawing.Size(281, 70);
			this.ebuildLabel.TabIndex = 6;
			this.ebuildLabel.Text = ".ebuild location:";
			// 
			this.ebuildPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.ebuildPath.Location = new System.Drawing.Point(20, 180);
			this.ebuildPath.Name = ".ebuild Path";
			this.ebuildPath.Size = new System.Drawing.Size(281, 70);
			this.ebuildPath.TabIndex = 7;

			this.SuspendLayout();
			this.Name = "GeneralSettingsPage";
			this.Size = new System.Drawing.Size(338, 150);
			// 
			this.Controls.Add(this.radioButton_UseLayman);
			this.Controls.Add(this.radioButton_UsePortage);
			// 
			this.Controls.Add(this.nuspecPath);
			this.Controls.Add(this.nuspecLabel);
			// 
			this.Controls.Add(this.ebuildPath);
			this.Controls.Add(this.ebuildLabel);
			// 
            this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.RadioButton radioButton_UsePortage;
		private System.Windows.Forms.RadioButton radioButton_UseLayman;
		private System.Windows.Forms.Label nuspecLabel;
		private System.Windows.Forms.TextBox nuspecPath;
		private System.Windows.Forms.Label ebuildLabel;
		private System.Windows.Forms.TextBox ebuildPath;
    }
}
