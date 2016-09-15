namespace MyApplication
{
    partial class FormM3URelativePath
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
            this.ucBrowseFileSystem1 = new MyControlsLibrary.UcBrowseFileSystem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucBrowseFileSystem1);
            this.splitContainer1.Size = new System.Drawing.Size(637, 402);
            this.splitContainer1.SplitterDistance = 177;
            // 
            // ucBrowseFileSystem1
            // 
            this.ucBrowseFileSystem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBrowseFileSystem1.Location = new System.Drawing.Point(0, 0);
            this.ucBrowseFileSystem1.Name = "ucBrowseFileSystem1";
            this.ucBrowseFileSystem1.Size = new System.Drawing.Size(637, 177);
            this.ucBrowseFileSystem1.TabIndex = 0;
            // 
            // FormM3URelativePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 402);
            this.Name = "FormM3URelativePath";
            this.Text = "FormM3URelativePath";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControlsLibrary.UcBrowseFileSystem ucBrowseFileSystem1;
    }
}