
namespace SC_CustomControls
{
    partial class SWCodi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIntro
            // 
            this.txtIntro.Location = new System.Drawing.Point(5, 4);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(55, 20);
            this.txtIntro.TabIndex = 0;
            this.txtIntro.Enter += new System.EventHandler(this.txtIntro_Enter);
            this.txtIntro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIntro_KeyDown);
            this.txtIntro.Leave += new System.EventHandler(this.txtIntro_Leave);
            this.txtIntro.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(69, 5);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(432, 20);
            this.txtData.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtIntro);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(504, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntro;
        private System.Windows.Forms.TextBox txtData;
    }
}
