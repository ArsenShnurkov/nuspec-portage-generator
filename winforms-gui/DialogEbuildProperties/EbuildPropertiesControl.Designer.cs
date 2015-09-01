using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGUI
{
	using System.Windows.Forms;

	partial class EbuildPropertiesControl
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
			this.SuspendLayout();

			this.labelRepositoryUrl = new System.Windows.Forms.Label();
			this.textboxRepositoryUrl = new System.Windows.Forms.TextBox();
			this.labelSha1 = new System.Windows.Forms.Label();
			this.textboxSha1 = new System.Windows.Forms.TextBox();
			this.labelEbuildCategory = new System.Windows.Forms.Label();
			this.textboxEbuildCategory = new System.Windows.Forms.TextBox();
			this.labelEbuildName = new System.Windows.Forms.Label();
			this.textboxEbuildName = new System.Windows.Forms.TextBox();



			// 
			//this.labelRepositoryUrl.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
			this.labelRepositoryUrl.AutoSize = true;
			this.labelRepositoryUrl.Location = new System.Drawing.Point(20, 20);
			this.labelRepositoryUrl.Size = new System.Drawing.Size(150, 70);
			this.labelRepositoryUrl.TabIndex = 1;
			this.labelRepositoryUrl.Text = "Github project full URL:";
			// 
			this.textboxRepositoryUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxRepositoryUrl.Location = new System.Drawing.Point(20, 40);
			this.textboxRepositoryUrl.Size = new System.Drawing.Size(150, 70);
			this.textboxRepositoryUrl.TabIndex = 2;



			// 
			//this.labelSha1.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
			this.labelSha1.AutoSize = true;
			this.labelSha1.Location = new System.Drawing.Point(20, 80);
			this.labelSha1.Size = new System.Drawing.Size(150, 70);
			this.labelSha1.TabIndex = 1;
			this.labelSha1.Text = "SHA1 of commit:";
			// 
			this.textboxSha1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxSha1.Location = new System.Drawing.Point(20, 100);
			this.textboxSha1.Size = new System.Drawing.Size(150, 70);
			this.textboxSha1.TabIndex = 2;



			// 
			this.labelEbuildCategory.AutoSize = true;
			this.labelEbuildCategory.Location = new System.Drawing.Point(20, 140);
			this.labelEbuildCategory.Size = new System.Drawing.Size(150, 70);
			this.labelEbuildCategory.TabIndex = 1;
			this.labelEbuildCategory.Text = "Class name:";
			// 
			this.textboxEbuildCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxEbuildCategory.Location = new System.Drawing.Point(20, 160);
			this.textboxEbuildCategory.Size = new System.Drawing.Size(150, 70);
			this.textboxEbuildCategory.TabIndex = 2;


			// 
			this.labelEbuildName.AutoSize = true;
			this.labelEbuildName.Location = new System.Drawing.Point(20, 200);
			this.labelEbuildName.Size = new System.Drawing.Size(150, 70);
			this.labelEbuildName.TabIndex = 3;
			this.labelEbuildName.Text = "Ebuild name:";
			// 
			this.textboxEbuildName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textboxEbuildName.Location = new System.Drawing.Point(20, 220);
			this.textboxEbuildName.Size = new System.Drawing.Size(150, 70);
			this.textboxEbuildName.TabIndex = 4;




			this.Size = new System.Drawing.Size(190, 260);
			// 
			this.Controls.Add(this.labelRepositoryUrl);
			this.Controls.Add(this.textboxRepositoryUrl);
			// 
			this.Controls.Add(this.labelSha1);
			this.Controls.Add(this.textboxSha1);
			// 
			this.Controls.Add(this.textboxEbuildCategory);
			this.Controls.Add(this.labelEbuildCategory);
			// 
			this.Controls.Add(this.textboxEbuildName);
			this.Controls.Add(this.labelEbuildName);
			// 
            this.ResumeLayout(false);
        }

        #endregion

		private System.Windows.Forms.Label labelRepositoryUrl = null;
		private System.Windows.Forms.TextBox textboxRepositoryUrl = null;
		private System.Windows.Forms.Label labelSha1 = null;
		private System.Windows.Forms.TextBox textboxSha1 = null;

		private System.Windows.Forms.Label labelEbuildCategory = null;
		private System.Windows.Forms.TextBox textboxEbuildCategory = null;
		private System.Windows.Forms.Label labelEbuildName = null;
		private System.Windows.Forms.TextBox textboxEbuildName = null;

    }
}
