namespace FormLittleERP_Orders.Representation
{
    partial class Form_AddO
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
            this.lblTitleAO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalAO = new System.Windows.Forms.TextBox();
            this.txtPrepAO = new System.Windows.Forms.TextBox();
            this.dtpDateAO = new System.Windows.Forms.DateTimePicker();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProdAO = new System.Windows.Forms.Button();
            this.btnModifProdAO = new System.Windows.Forms.Button();
            this.btnDelProdAO = new System.Windows.Forms.Button();
            this.btnCanAO = new System.Windows.Forms.Button();
            this.btnCustomerAO = new System.Windows.Forms.Button();
            this.btnAddAO = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCustomA = new System.Windows.Forms.ComboBox();
            this.cboPayA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAO
            // 
            this.lblTitleAO.AutoSize = true;
            this.lblTitleAO.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAO.Location = new System.Drawing.Point(368, 21);
            this.lblTitleAO.Name = "lblTitleAO";
            this.lblTitleAO.Size = new System.Drawing.Size(79, 45);
            this.lblTitleAO.TabIndex = 0;
            this.lblTitleAO.Text = "title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pay Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Prepaid";
            // 
            // txtTotalAO
            // 
            this.txtTotalAO.Location = new System.Drawing.Point(220, 197);
            this.txtTotalAO.Name = "txtTotalAO";
            this.txtTotalAO.ReadOnly = true;
            this.txtTotalAO.Size = new System.Drawing.Size(259, 22);
            this.txtTotalAO.TabIndex = 11;
            // 
            // txtPrepAO
            // 
            this.txtPrepAO.Location = new System.Drawing.Point(220, 152);
            this.txtPrepAO.Name = "txtPrepAO";
            this.txtPrepAO.Size = new System.Drawing.Size(259, 22);
            this.txtPrepAO.TabIndex = 13;
            this.txtPrepAO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrepAO_KeyPress);
            // 
            // dtpDateAO
            // 
            this.dtpDateAO.Checked = false;
            this.dtpDateAO.Location = new System.Drawing.Point(220, 291);
            this.dtpDateAO.Name = "dtpDateAO";
            this.dtpDateAO.Size = new System.Drawing.Size(259, 22);
            this.dtpDateAO.TabIndex = 14;
            this.dtpDateAO.ValueChanged += new System.EventHandler(this.dtpDateAO_ValueChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(82, 376);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(828, 235);
            this.dgvProducts.TabIndex = 15;
            // 
            // btnAddProdAO
            // 
            this.btnAddProdAO.Location = new System.Drawing.Point(611, 331);
            this.btnAddProdAO.Name = "btnAddProdAO";
            this.btnAddProdAO.Size = new System.Drawing.Size(75, 44);
            this.btnAddProdAO.TabIndex = 16;
            this.btnAddProdAO.Text = "ADD";
            this.btnAddProdAO.UseVisualStyleBackColor = true;
            this.btnAddProdAO.Click += new System.EventHandler(this.btnAddProdAO_Click);
            // 
            // btnModifProdAO
            // 
            this.btnModifProdAO.Location = new System.Drawing.Point(710, 331);
            this.btnModifProdAO.Name = "btnModifProdAO";
            this.btnModifProdAO.Size = new System.Drawing.Size(75, 44);
            this.btnModifProdAO.TabIndex = 17;
            this.btnModifProdAO.Text = "Modif";
            this.btnModifProdAO.UseVisualStyleBackColor = true;
            this.btnModifProdAO.Click += new System.EventHandler(this.btnModifProdAO_Click);
            // 
            // btnDelProdAO
            // 
            this.btnDelProdAO.Location = new System.Drawing.Point(811, 331);
            this.btnDelProdAO.Name = "btnDelProdAO";
            this.btnDelProdAO.Size = new System.Drawing.Size(75, 44);
            this.btnDelProdAO.TabIndex = 18;
            this.btnDelProdAO.Text = "DEL";
            this.btnDelProdAO.UseVisualStyleBackColor = true;
            this.btnDelProdAO.Click += new System.EventHandler(this.btnDelProdAO_Click);
            // 
            // btnCanAO
            // 
            this.btnCanAO.Location = new System.Drawing.Point(811, 633);
            this.btnCanAO.Name = "btnCanAO";
            this.btnCanAO.Size = new System.Drawing.Size(96, 30);
            this.btnCanAO.TabIndex = 19;
            this.btnCanAO.Text = "Cancel";
            this.btnCanAO.UseVisualStyleBackColor = true;
            this.btnCanAO.Click += new System.EventHandler(this.btnCanAO_Click);
            // 
            // btnCustomerAO
            // 
            this.btnCustomerAO.Location = new System.Drawing.Point(503, 101);
            this.btnCustomerAO.Name = "btnCustomerAO";
            this.btnCustomerAO.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAO.TabIndex = 20;
            this.btnCustomerAO.Text = "New...";
            this.btnCustomerAO.UseVisualStyleBackColor = true;
            this.btnCustomerAO.Click += new System.EventHandler(this.btnCustomerAO_Click);
            // 
            // btnAddAO
            // 
            this.btnAddAO.Location = new System.Drawing.Point(670, 158);
            this.btnAddAO.Name = "btnAddAO";
            this.btnAddAO.Size = new System.Drawing.Size(176, 59);
            this.btnAddAO.TabIndex = 23;
            this.btnAddAO.Text = "ADD ORDER";
            this.btnAddAO.UseVisualStyleBackColor = true;
            this.btnAddAO.Click += new System.EventHandler(this.btnAddAO_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Products";
            // 
            // cboCustomA
            // 
            this.cboCustomA.FormattingEnabled = true;
            this.cboCustomA.Location = new System.Drawing.Point(220, 101);
            this.cboCustomA.Name = "cboCustomA";
            this.cboCustomA.Size = new System.Drawing.Size(259, 24);
            this.cboCustomA.TabIndex = 26;
            this.cboCustomA.SelectionChangeCommitted += new System.EventHandler(this.cboCustomA_SelectionChangeCommitted);
            // 
            // cboPayA
            // 
            this.cboPayA.FormattingEnabled = true;
            this.cboPayA.Location = new System.Drawing.Point(220, 241);
            this.cboPayA.Name = "cboPayA";
            this.cboPayA.Size = new System.Drawing.Size(259, 24);
            this.cboPayA.TabIndex = 27;
            this.cboPayA.SelectedIndexChanged += new System.EventHandler(this.cboPayA_SelectedIndexChanged);
            // 
            // Form_AddO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 682);
            this.Controls.Add(this.cboPayA);
            this.Controls.Add(this.cboCustomA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddAO);
            this.Controls.Add(this.btnCustomerAO);
            this.Controls.Add(this.btnCanAO);
            this.Controls.Add(this.btnDelProdAO);
            this.Controls.Add(this.btnModifProdAO);
            this.Controls.Add(this.btnAddProdAO);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dtpDateAO);
            this.Controls.Add(this.txtPrepAO);
            this.Controls.Add(this.txtTotalAO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitleAO);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form_AddO";
            this.Text = "Form_AddO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleAO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalAO;
        private System.Windows.Forms.TextBox txtPrepAO;
        private System.Windows.Forms.DateTimePicker dtpDateAO;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddProdAO;
        private System.Windows.Forms.Button btnModifProdAO;
        private System.Windows.Forms.Button btnDelProdAO;
        private System.Windows.Forms.Button btnCanAO;
        private System.Windows.Forms.Button btnCustomerAO;
        private System.Windows.Forms.Button btnAddAO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCustomA;
        private System.Windows.Forms.ComboBox cboPayA;
    }
}