namespace InteruptBlocker
{
    partial class MainForm
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
            this.pMain = new MetroFramework.Controls.MetroPanel();
            this.lblInteruptCount = new MetroFramework.Controls.MetroLabel();
            this.lblInteruptCountVal = new MetroFramework.Controls.MetroLabel();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMain.Controls.Add(this.lblInteruptCountVal);
            this.pMain.Controls.Add(this.lblInteruptCount);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.HorizontalScrollbarBarColor = true;
            this.pMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pMain.HorizontalScrollbarSize = 10;
            this.pMain.Location = new System.Drawing.Point(20, 60);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(212, 46);
            this.pMain.TabIndex = 0;
            this.pMain.VerticalScrollbarBarColor = true;
            this.pMain.VerticalScrollbarHighlightOnWheel = false;
            this.pMain.VerticalScrollbarSize = 10;
            // 
            // lblInteruptCount
            // 
            this.lblInteruptCount.AutoSize = true;
            this.lblInteruptCount.Location = new System.Drawing.Point(11, 14);
            this.lblInteruptCount.Name = "lblInteruptCount";
            this.lblInteruptCount.Size = new System.Drawing.Size(87, 19);
            this.lblInteruptCount.TabIndex = 2;
            this.lblInteruptCount.Text = "Keys blocked:";
            // 
            // lblInteruptCountVal
            // 
            this.lblInteruptCountVal.AutoSize = true;
            this.lblInteruptCountVal.Location = new System.Drawing.Point(98, 14);
            this.lblInteruptCountVal.Name = "lblInteruptCountVal";
            this.lblInteruptCountVal.Size = new System.Drawing.Size(16, 19);
            this.lblInteruptCountVal.TabIndex = 3;
            this.lblInteruptCountVal.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 126);
            this.Controls.Add(this.pMain);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Interupt Blocker";
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pMain;
        private MetroFramework.Controls.MetroLabel lblInteruptCount;
        private MetroFramework.Controls.MetroLabel lblInteruptCountVal;
    }
}

