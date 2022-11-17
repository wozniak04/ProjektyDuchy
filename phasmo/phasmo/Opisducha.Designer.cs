namespace phasmo
{
    partial class Opisducha
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
/// </summary>private void InitializeComponent()
        private void InitializeComponent(){
            this.Nazwa = new System.Windows.Forms.Label();
            this.Dowody = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.Label();
            this.Moc = new System.Windows.Forms.Label();
            this.Slabosc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazwa.Location = new System.Drawing.Point(12, 9);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(122, 55);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.Text = "Duch";
            // 
            // Dowody
            // 
            this.Dowody.AutoSize = true;
            this.Dowody.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dowody.Location = new System.Drawing.Point(16, 394);
            this.Dowody.Name = "Dowody";
            this.Dowody.Size = new System.Drawing.Size(104, 33);
            this.Dowody.TabIndex = 1;
            this.Dowody.Text = "Dowody";
            // 
            // Opis
            // 
            this.Opis.AutoSize = true;
            this.Opis.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis.Location = new System.Drawing.Point(17, 84);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(57, 30);
            this.Opis.TabIndex = 2;
            this.Opis.Text = "Opis";
            // 
            // Moc
            // 
            this.Moc.AutoSize = true;
            this.Moc.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Moc.Location = new System.Drawing.Point(17, 292);
            this.Moc.Name = "Moc";
            this.Moc.Size = new System.Drawing.Size(53, 30);
            this.Moc.TabIndex = 3;
            this.Moc.Text = "Moc";
            // 
            // Slabosc
            // 
            this.Slabosc.AutoSize = true;
            this.Slabosc.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Slabosc.Location = new System.Drawing.Point(17, 340);
            this.Slabosc.Name = "Slabosc";
            this.Slabosc.Size = new System.Drawing.Size(87, 30);
            this.Slabosc.TabIndex = 4;
            this.Slabosc.Text = "Słabość";
            // 
            // Opisducha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Slabosc);
            this.Controls.Add(this.Moc);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.Dowody);
            this.Controls.Add(this.Nazwa);
            this.Name = "Opisducha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opisducha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Label Dowody;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.Label Moc;
        private System.Windows.Forms.Label Slabosc;
    }
}