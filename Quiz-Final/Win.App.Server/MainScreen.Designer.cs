namespace Win.App.Server
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLPU = new System.Windows.Forms.Button();
            this.btnJPIA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1245, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 39;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLPU
            // 
            this.btnLPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLPU.BackgroundImage")));
            this.btnLPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLPU.Location = new System.Drawing.Point(680, 121);
            this.btnLPU.Name = "btnLPU";
            this.btnLPU.Size = new System.Drawing.Size(434, 488);
            this.btnLPU.TabIndex = 38;
            this.btnLPU.UseVisualStyleBackColor = true;
            this.btnLPU.Click += new System.EventHandler(this.btnLPU_Click);
            // 
            // btnJPIA
            // 
            this.btnJPIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJPIA.BackgroundImage")));
            this.btnJPIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJPIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJPIA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnJPIA.Location = new System.Drawing.Point(214, 121);
            this.btnJPIA.Name = "btnJPIA";
            this.btnJPIA.Size = new System.Drawing.Size(450, 488);
            this.btnJPIA.TabIndex = 37;
            this.btnJPIA.UseVisualStyleBackColor = true;
            this.btnJPIA.Click += new System.EventHandler(this.btnJPIA_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F);
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 57);
            this.label1.TabIndex = 36;
            this.label1.Text = "Welcome to Quiz Bee";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 683);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLPU);
            this.Controls.Add(this.btnJPIA);
            this.Controls.Add(this.label1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLPU;
        private System.Windows.Forms.Button btnJPIA;
        private System.Windows.Forms.Label label1;
    }
}