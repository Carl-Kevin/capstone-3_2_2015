namespace Win.App.Server
{
    partial class TallySheetScreen
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
            this.ContestantListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ContestantListView
            // 
            this.ContestantListView.AllowColumnReorder = true;
            this.ContestantListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContestantListView.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContestantListView.FullRowSelect = true;
            this.ContestantListView.GridLines = true;
            this.ContestantListView.Location = new System.Drawing.Point(0, 0);
            this.ContestantListView.Name = "ContestantListView";
            this.ContestantListView.Size = new System.Drawing.Size(1001, 520);
            this.ContestantListView.TabIndex = 9;
            this.ContestantListView.UseCompatibleStateImageBehavior = false;
            this.ContestantListView.View = System.Windows.Forms.View.Details;
            // 
            // TallySheetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 520);
            this.Controls.Add(this.ContestantListView);
            this.Name = "TallySheetScreen";
            this.Text = "TallySheetScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ContestantListView;
    }
}