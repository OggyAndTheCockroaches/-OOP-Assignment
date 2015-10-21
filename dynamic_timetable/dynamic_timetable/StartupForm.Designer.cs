namespace dynamic_timetable
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.AboutLabel = new System.Windows.Forms.Label();
            this.LoadingBar = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.AboutLabel.Location = new System.Drawing.Point(14, 11);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(304, 48);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = "            Dynamic Timetable application\r\nDeveloped by team Oggy and the cockroa" +
    "ches\r\n                        Copyright 2015";
            this.AboutLabel.UseWaitCursor = true;
            // 
            // LoadingBar
            // 
            this.LoadingBar.EditValue = "Loading...";
            this.LoadingBar.Location = new System.Drawing.Point(14, 72);
            this.LoadingBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.LoadingBar.Properties.MarqueeAnimationSpeed = 50;
            this.LoadingBar.Properties.ShowTitle = true;
            this.LoadingBar.Size = new System.Drawing.Size(304, 20);
            this.LoadingBar.TabIndex = 4;
            this.LoadingBar.UseWaitCursor = true;
            // 
            // StartupForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 102);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.AboutLabel);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2013";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Timetable";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.LoadingBar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private DevExpress.XtraEditors.MarqueeProgressBarControl LoadingBar;
    }
}