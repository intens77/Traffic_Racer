
using System.Drawing;
using Traffic_Racer.Core.Controller;
using Traffic_Racer.Core.Model;
using Traffic_Racer.Core.View;

namespace Traffic_Racer
{
    partial class Traffic_Racer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Traffic_Racer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Traffic_Racer";
            this.Text = "Traffic_Racer";
            this.ResumeLayout(false);
            this.Paint += new System.Windows.Forms.PaintEventHandler(View.Draw);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Controller.CheckDownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(Controller.CheckUpKey);
        }

        #endregion
    }
}

