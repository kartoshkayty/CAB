namespace CAB.Forms
{
    partial class VisitsList
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
            this.VisitsListView = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Browser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisitsListView
            // 
            this.VisitsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.Browser,
            this.Date});
            this.VisitsListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.VisitsListView.HideSelection = false;
            this.VisitsListView.Location = new System.Drawing.Point(0, 0);
            this.VisitsListView.Name = "VisitsListView";
            this.VisitsListView.Size = new System.Drawing.Size(610, 307);
            this.VisitsListView.TabIndex = 0;
            this.VisitsListView.UseCompatibleStateImageBehavior = false;
            this.VisitsListView.View = System.Windows.Forms.View.Details;
            // 
            // IP
            // 
            this.IP.Text = "IP Адрес";
            this.IP.Width = 163;
            // 
            // Browser
            // 
            this.Browser.Text = "Браузер";
            this.Browser.Width = 234;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 207;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(13, 313);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // VisitsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 348);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.VisitsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisitsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Визиты";
            this.Shown += new System.EventHandler(this.VisitsList_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView VisitsListView;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Browser;
        private System.Windows.Forms.ColumnHeader Date;
    }
}