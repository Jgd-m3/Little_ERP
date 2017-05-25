namespace FormLittleERP_Orders.Representation
{
    partial class Form_ChangesO
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
            this.dgvChangesO = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkCO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangesO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChangesO
            // 
            this.dgvChangesO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangesO.Location = new System.Drawing.Point(85, 138);
            this.dgvChangesO.Name = "dgvChangesO";
            this.dgvChangesO.RowTemplate.Height = 24;
            this.dgvChangesO.Size = new System.Drawing.Size(857, 312);
            this.dgvChangesO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Changes in Orders";
            // 
            // btnOkCO
            // 
            this.btnOkCO.Location = new System.Drawing.Point(469, 504);
            this.btnOkCO.Name = "btnOkCO";
            this.btnOkCO.Size = new System.Drawing.Size(75, 23);
            this.btnOkCO.TabIndex = 2;
            this.btnOkCO.Text = "OK";
            this.btnOkCO.UseVisualStyleBackColor = true;
            this.btnOkCO.Click += new System.EventHandler(this.btnOkCO_Click);
            // 
            // Form_ChangesO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 588);
            this.Controls.Add(this.btnOkCO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChangesO);
            this.Name = "Form_ChangesO";
            this.Text = "Form_ChangesO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangesO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChangesO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkCO;
    }
}