namespace phasmo
{
    partial class ListItem
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
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblDowody = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwa.Location = new System.Drawing.Point(28, 43);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(261, 51);
            this.lblNazwa.TabIndex = 0;
            this.lblNazwa.Text = "Nazwa ducha";
            // 
            // lblDowody
            // 
            this.lblDowody.AutoSize = true;
            this.lblDowody.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDowody.Location = new System.Drawing.Point(321, 46);
            this.lblDowody.Name = "lblDowody";
            this.lblDowody.Size = new System.Drawing.Size(144, 46);
            this.lblDowody.TabIndex = 1;
            this.lblDowody.Text = "Dowody";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDowody);
            this.Controls.Add(this.lblNazwa);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(1178, 150);
            this.Click += new System.EventHandler(this.ListItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblDowody;
    }
}
