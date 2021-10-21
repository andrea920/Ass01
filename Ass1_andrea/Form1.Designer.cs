
namespace Ass1_andrea
{
    partial class Form1
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
            this.btnClk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClk
            // 
            this.btnClk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClk.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClk.Location = new System.Drawing.Point(232, 78);
            this.btnClk.Name = "btnClk";
            this.btnClk.Size = new System.Drawing.Size(180, 79);
            this.btnClk.TabIndex = 0;
            this.btnClk.Text = "CLICK HERE!";
            this.btnClk.UseVisualStyleBackColor = false;
            this.btnClk.Click += new System.EventHandler(this.btnClk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 260);
            this.Controls.Add(this.btnClk);
            this.Name = "Form1";
            this.Text = "Message Box";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClk;
    }
}

