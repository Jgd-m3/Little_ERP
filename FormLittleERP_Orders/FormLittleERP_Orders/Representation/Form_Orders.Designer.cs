namespace FormLittleERP_Orders.Representation
{
    partial class Form_Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddO = new System.Windows.Forms.Button();
            this.btnModifO = new System.Windows.Forms.Button();
            this.btnDelO = new System.Windows.Forms.Button();
            this.btnChangesO = new System.Windows.Forms.Button();
            this.btnDoneO = new System.Windows.Forms.Button();
            this.dgvOrdersO = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceO = new System.Windows.Forms.TextBox();
            this.dtpDateO = new System.Windows.Forms.DateTimePicker();
            this.cbSignPriceO = new System.Windows.Forms.ComboBox();
            this.btnFiltO = new System.Windows.Forms.Button();
            this.btnClearO = new System.Windows.Forms.Button();
            this.cbPaymentO = new System.Windows.Forms.ComboBox();
            this.cbxDate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckDelO = new System.Windows.Forms.CheckBox();
            this.cbCustomerO = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // btnAddO
            // 
            this.btnAddO.Location = new System.Drawing.Point(103, 265);
            this.btnAddO.Name = "btnAddO";
            this.btnAddO.Size = new System.Drawing.Size(91, 46);
            this.btnAddO.TabIndex = 1;
            this.btnAddO.Text = "ADD";
            this.btnAddO.UseVisualStyleBackColor = true;
            this.btnAddO.Click += new System.EventHandler(this.btnAddO_Click);
            // 
            // btnModifO
            // 
            this.btnModifO.Location = new System.Drawing.Point(216, 265);
            this.btnModifO.Name = "btnModifO";
            this.btnModifO.Size = new System.Drawing.Size(93, 46);
            this.btnModifO.TabIndex = 2;
            this.btnModifO.Text = "Modif";
            this.btnModifO.UseVisualStyleBackColor = true;
            this.btnModifO.Click += new System.EventHandler(this.btnModifO_Click);
            // 
            // btnDelO
            // 
            this.btnDelO.Location = new System.Drawing.Point(333, 265);
            this.btnDelO.Name = "btnDelO";
            this.btnDelO.Size = new System.Drawing.Size(100, 46);
            this.btnDelO.TabIndex = 3;
            this.btnDelO.Text = "DEL";
            this.btnDelO.UseVisualStyleBackColor = true;
            this.btnDelO.Click += new System.EventHandler(this.btnDeleteO_Click);
            // 
            // btnChangesO
            // 
            this.btnChangesO.Location = new System.Drawing.Point(997, 265);
            this.btnChangesO.Name = "btnChangesO";
            this.btnChangesO.Size = new System.Drawing.Size(106, 46);
            this.btnChangesO.TabIndex = 4;
            this.btnChangesO.Text = "Changes";
            this.btnChangesO.UseVisualStyleBackColor = true;
            this.btnChangesO.Click += new System.EventHandler(this.btnChangesO_Click);
            // 
            // btnDoneO
            // 
            this.btnDoneO.Location = new System.Drawing.Point(997, 658);
            this.btnDoneO.Name = "btnDoneO";
            this.btnDoneO.Size = new System.Drawing.Size(106, 47);
            this.btnDoneO.TabIndex = 5;
            this.btnDoneO.Text = "Done";
            this.btnDoneO.UseVisualStyleBackColor = true;
            this.btnDoneO.Click += new System.EventHandler(this.btnDoneO_Click);
            // 
            // dgvOrdersO
            // 
            this.dgvOrdersO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersO.Location = new System.Drawing.Point(103, 331);
            this.dgvOrdersO.MultiSelect = false;
            this.dgvOrdersO.Name = "dgvOrdersO";
            this.dgvOrdersO.RowTemplate.Height = 24;
            this.dgvOrdersO.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdersO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersO.Size = new System.Drawing.Size(1000, 307);
            this.dgvOrdersO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment method";
            // 
            // txtPriceO
            // 
            this.txtPriceO.Location = new System.Drawing.Point(496, 183);
            this.txtPriceO.Name = "txtPriceO";
            this.txtPriceO.Size = new System.Drawing.Size(218, 22);
            this.txtPriceO.TabIndex = 13;
            this.txtPriceO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceO_KeyPress);
            // 
            // dtpDateO
            // 
            this.dtpDateO.Location = new System.Drawing.Point(430, 149);
            this.dtpDateO.Name = "dtpDateO";
            this.dtpDateO.Size = new System.Drawing.Size(284, 22);
            this.dtpDateO.TabIndex = 15;
            // 
            // cbSignPriceO
            // 
            this.cbSignPriceO.FormattingEnabled = true;
            this.cbSignPriceO.IntegralHeight = false;
            this.cbSignPriceO.Items.AddRange(new object[] {
            "*",
            "=",
            "<",
            ">"});
            this.cbSignPriceO.Location = new System.Drawing.Point(406, 181);
            this.cbSignPriceO.Name = "cbSignPriceO";
            this.cbSignPriceO.Size = new System.Drawing.Size(84, 24);
            this.cbSignPriceO.TabIndex = 16;
            // 
            // btnFiltO
            // 
            this.btnFiltO.Location = new System.Drawing.Point(849, 116);
            this.btnFiltO.Name = "btnFiltO";
            this.btnFiltO.Size = new System.Drawing.Size(161, 55);
            this.btnFiltO.TabIndex = 19;
            this.btnFiltO.Text = "Search";
            this.btnFiltO.UseVisualStyleBackColor = true;
            this.btnFiltO.Click += new System.EventHandler(this.btnFiltO_Click);
            // 
            // btnClearO
            // 
            this.btnClearO.Location = new System.Drawing.Point(849, 184);
            this.btnClearO.Name = "btnClearO";
            this.btnClearO.Size = new System.Drawing.Size(161, 56);
            this.btnClearO.TabIndex = 20;
            this.btnClearO.Text = "Clear";
            this.btnClearO.UseVisualStyleBackColor = true;
            this.btnClearO.Click += new System.EventHandler(this.btnClearO_Click);
            // 
            // cbPaymentO
            // 
            this.cbPaymentO.FormattingEnabled = true;
            this.cbPaymentO.Items.AddRange(new object[] {
            "1"});
            this.cbPaymentO.Location = new System.Drawing.Point(406, 218);
            this.cbPaymentO.Name = "cbPaymentO";
            this.cbPaymentO.Size = new System.Drawing.Size(308, 24);
            this.cbPaymentO.TabIndex = 21;
            // 
            // cbxDate
            // 
            this.cbxDate.AutoSize = true;
            this.cbxDate.Location = new System.Drawing.Point(406, 154);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.Size = new System.Drawing.Size(18, 17);
            this.cbxDate.TabIndex = 22;
            this.cbxDate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1031, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Deleteds?";
            // 
            // ckDelO
            // 
            this.ckDelO.AutoSize = true;
            this.ckDelO.Location = new System.Drawing.Point(1055, 136);
            this.ckDelO.Name = "ckDelO";
            this.ckDelO.Size = new System.Drawing.Size(18, 17);
            this.ckDelO.TabIndex = 24;
            this.ckDelO.UseVisualStyleBackColor = true;
            // 
            // cbCustomerO
            // 
            this.cbCustomerO.FormattingEnabled = true;
            this.cbCustomerO.Location = new System.Drawing.Point(406, 116);
            this.cbCustomerO.Name = "cbCustomerO";
            this.cbCustomerO.Size = new System.Drawing.Size(308, 24);
            this.cbCustomerO.TabIndex = 26;
            // 
            // Form_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 731);
            this.Controls.Add(this.cbCustomerO);
            this.Controls.Add(this.ckDelO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.cbPaymentO);
            this.Controls.Add(this.btnClearO);
            this.Controls.Add(this.btnFiltO);
            this.Controls.Add(this.cbSignPriceO);
            this.Controls.Add(this.dtpDateO);
            this.Controls.Add(this.txtPriceO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOrdersO);
            this.Controls.Add(this.btnDoneO);
            this.Controls.Add(this.btnChangesO);
            this.Controls.Add(this.btnDelO);
            this.Controls.Add(this.btnModifO);
            this.Controls.Add(this.btnAddO);
            this.Controls.Add(this.label1);
            this.Name = "Form_Orders";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddO;
        private System.Windows.Forms.Button btnModifO;
        private System.Windows.Forms.Button btnDelO;
        private System.Windows.Forms.Button btnChangesO;
        private System.Windows.Forms.Button btnDoneO;
        private System.Windows.Forms.DataGridView dgvOrdersO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceO;
        private System.Windows.Forms.DateTimePicker dtpDateO;
        private System.Windows.Forms.ComboBox cbSignPriceO;
        private System.Windows.Forms.Button btnFiltO;
        private System.Windows.Forms.Button btnClearO;
        private System.Windows.Forms.ComboBox cbPaymentO;
        private System.Windows.Forms.CheckBox cbxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckDelO;
        private System.Windows.Forms.ComboBox cbCustomerO;
    }
}

