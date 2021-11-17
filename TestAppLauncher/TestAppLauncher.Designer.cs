
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.appLauncher1 = new SC_CustomControls.AppLauncher();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // appLauncher1
            // 
            this.appLauncher1.BackColor = System.Drawing.Color.Yellow;
            this.appLauncher1.ButtonColor = System.Drawing.Color.Empty;
            this.appLauncher1.Clase = "HelloWorldForm";
            this.appLauncher1.Description = null;
            this.appLauncher1.Form = "Form1";
            this.appLauncher1.ImagePath = null;
            this.appLauncher1.Location = new System.Drawing.Point(252, 87);
            this.appLauncher1.Name = "appLauncher1";
            this.appLauncher1.Size = new System.Drawing.Size(246, 82);
            this.appLauncher1.TabIndex = 0;
            this.appLauncher1.title = null;
            this.appLauncher1.Load += new System.EventHandler(this.appLauncher1_Load);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestAppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appLauncher1);
            this.Name = "TestAppLauncher";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private SC_CustomControls.AppLauncher appLauncher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        #endregion

        //private SC_CustomControls.AppLauncher appLauncher1;
    }
}

