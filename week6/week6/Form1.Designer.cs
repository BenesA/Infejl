
namespace week6
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
            this.components = new System.ComponentModel.Container();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnselectcar = new System.Windows.Forms.Button();
            this.btnselectball = new System.Windows.Forms.Button();
            this.lblnext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTimer
            // 
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(12, 130);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 308);
            this.mainPanel.TabIndex = 0;
            // 
            // btnselectcar
            // 
            this.btnselectcar.Location = new System.Drawing.Point(12, 12);
            this.btnselectcar.Name = "btnselectcar";
            this.btnselectcar.Size = new System.Drawing.Size(158, 81);
            this.btnselectcar.TabIndex = 1;
            this.btnselectcar.Text = "Car";
            this.btnselectcar.UseVisualStyleBackColor = true;
            this.btnselectcar.Click += new System.EventHandler(this.btnselectcar_Click);
            // 
            // btnselectball
            // 
            this.btnselectball.Location = new System.Drawing.Point(206, 12);
            this.btnselectball.Name = "btnselectball";
            this.btnselectball.Size = new System.Drawing.Size(156, 81);
            this.btnselectball.TabIndex = 2;
            this.btnselectball.Text = "Ball";
            this.btnselectball.UseVisualStyleBackColor = true;
            this.btnselectball.Click += new System.EventHandler(this.btnselectball_Click);
            // 
            // lblnext
            // 
            this.lblnext.AutoSize = true;
            this.lblnext.Location = new System.Drawing.Point(400, 12);
            this.lblnext.Name = "lblnext";
            this.lblnext.Size = new System.Drawing.Size(70, 13);
            this.lblnext.TabIndex = 3;
            this.lblnext.Text = "coming soon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnext);
            this.Controls.Add(this.btnselectball);
            this.Controls.Add(this.btnselectcar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnselectcar;
        private System.Windows.Forms.Button btnselectball;
        private System.Windows.Forms.Label lblnext;
    }
}

