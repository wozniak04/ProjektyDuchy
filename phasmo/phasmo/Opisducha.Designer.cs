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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nazwa.AutoSize = true;
            this.Nazwa.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazwa.Location = new System.Drawing.Point(3, 0);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(804, 56);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.Text = "Duch";
            this.Nazwa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dowody
            // 
            this.Dowody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dowody.AutoSize = true;
            this.Dowody.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dowody.Location = new System.Drawing.Point(3, 364);
            this.Dowody.Name = "Dowody";
            this.Dowody.Size = new System.Drawing.Size(804, 73);
            this.Dowody.TabIndex = 1;
            this.Dowody.Text = "Dowody";
            this.Dowody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Opis
            // 
            this.Opis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Opis.AutoSize = true;
            this.Opis.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis.Location = new System.Drawing.Point(3, 56);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(804, 170);
            this.Opis.TabIndex = 2;
            this.Opis.Text = "Opis";
            this.Opis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Moc
            // 
            this.Moc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Moc.AutoSize = true;
            this.Moc.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Moc.Location = new System.Drawing.Point(3, 226);
            this.Moc.Name = "Moc";
            this.Moc.Size = new System.Drawing.Size(804, 69);
            this.Moc.TabIndex = 3;
            this.Moc.Text = "Moc";
            this.Moc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Slabosc
            // 
            this.Slabosc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Slabosc.AutoSize = true;
            this.Slabosc.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Slabosc.Location = new System.Drawing.Point(3, 295);
            this.Slabosc.Name = "Slabosc";
            this.Slabosc.Size = new System.Drawing.Size(804, 69);
            this.Slabosc.TabIndex = 4;
            this.Slabosc.Text = "Słabość";
            this.Slabosc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Nazwa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dowody, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Slabosc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Opis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Moc, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 437);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Opisducha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(215)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Opisducha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opisducha";
            this.Load += new System.EventHandler(this.Opisducha_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Label Dowody;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.Label Moc;
        private System.Windows.Forms.Label Slabosc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}