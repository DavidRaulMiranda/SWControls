﻿
namespace TestAppLauncher
{
    partial class TestAppLauncher
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
            this.appLauncher1 = new SC_CustomControls.AppLauncher();
            this.SuspendLayout();
            // 
            // appLauncher1
            // 
            this.appLauncher1.BackColor = System.Drawing.Color.DimGray;
            this.appLauncher1.Description = null;
            this.appLauncher1.Location = new System.Drawing.Point(252, 87);
            this.appLauncher1.Name = "appLauncher1";
            this.appLauncher1.NomApp = "test1";
            this.appLauncher1.Size = new System.Drawing.Size(246, 95);
            this.appLauncher1.TabIndex = 0;
            this.appLauncher1.title = null;
            this.appLauncher1.Load += new System.EventHandler(this.appLauncher1_Load);
            // 
            // TestAppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appLauncher1);
            this.Name = "TestAppLauncher";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private SC_CustomControls.AppLauncher appLauncher1;

        #endregion

        //private SC_CustomControls.AppLauncher appLauncher1;
    }
}

