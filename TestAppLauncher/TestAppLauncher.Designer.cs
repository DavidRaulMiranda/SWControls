
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
            this.button3 = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.swCodi1 = new SC_CustomControls.SWCodi();
            this.appLauncher1 = new SC_CustomControls.AppLauncher();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(609, 293);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 5;
            // 
            // swCodi1
            // 
            this.swCodi1.ClaseCS = null;
            this.swCodi1.controlID = "txta";
            this.swCodi1.FormCS = null;
            this.swCodi1.Location = new System.Drawing.Point(12, 283);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nomcodi = "CodeAgency";
            this.swCodi1.NomDesc = "DescAgency";
            this.swCodi1.NomId = "idAgency";
            this.swCodi1.NomTaula = "Agencies";
            this.swCodi1.Requerit = false;
            this.swCodi1.Size = new System.Drawing.Size(514, 30);
            this.swCodi1.TabIndex = 4;
            // 
            // appLauncher1
            // 
            this.appLauncher1.BackColor = System.Drawing.Color.Yellow;
            this.appLauncher1.ButtonColor = System.Drawing.Color.Empty;
            this.appLauncher1.Clase = "HelloWorldForm";
            this.appLauncher1.Description = null;
            this.appLauncher1.Form = "Form1";
            this.appLauncher1.ImagePath = null;
            this.appLauncher1.Location = new System.Drawing.Point(57, 30);
            this.appLauncher1.MinimumSize = new System.Drawing.Size(50, 50);
            this.appLauncher1.Name = "appLauncher1";
            this.appLauncher1.PosPanel = null;
            this.appLauncher1.Size = new System.Drawing.Size(141, 50);
            this.appLauncher1.TabIndex = 0;
            this.appLauncher1.title = null;
            this.appLauncher1.Load += new System.EventHandler(this.appLauncher1_Load);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1282, 606);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // TestAppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appLauncher1);
            this.Name = "TestAppLauncher";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private SC_CustomControls.AppLauncher appLauncher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private SC_CustomControls.SWCodi swCodi1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        #endregion

        //private SC_CustomControls.AppLauncher appLauncher1;
    }
}

