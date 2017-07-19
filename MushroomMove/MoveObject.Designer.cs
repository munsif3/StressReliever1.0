namespace MushroomMove
{
    partial class MoveObject
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
            this.components = new System.ComponentModel.Container();
            this.tmrMushroom = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrMushroom
            // 
            this.tmrMushroom.Enabled = true;
            this.tmrMushroom.Tick += new System.EventHandler(this.tmrMushroom_Tick);
            // 
            // MoveObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "MoveObject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mushroom";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MoveObject_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveObject_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrMushroom;
    }
}

