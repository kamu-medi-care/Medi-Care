namespace Kamu_Medi_Care.Medicines
{
    partial class MediStore
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
            this.CmdMedicineName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.DgvMediStore = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBillId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMediStore)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdMedicineName
            // 
            this.CmdMedicineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmdMedicineName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdMedicineName.ForeColor = System.Drawing.Color.Magenta;
            this.CmdMedicineName.FormattingEnabled = true;
            this.CmdMedicineName.Location = new System.Drawing.Point(26, 50);
            this.CmdMedicineName.Name = "CmdMedicineName";
            this.CmdMedicineName.Size = new System.Drawing.Size(372, 28);
            this.CmdMedicineName.TabIndex = 1;
            this.CmdMedicineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmdMedicineName_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TxtQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTotalBill);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtAvailableQty);
            this.panel1.Controls.Add(this.txtMedicineId);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.BtnNext);
            this.panel1.Controls.Add(this.BtnPrint);
            this.panel1.Controls.Add(this.DgvMediStore);
            this.panel1.Controls.Add(this.CmdMedicineName);
            this.panel1.Location = new System.Drawing.Point(40, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 394);
            this.panel1.TabIndex = 1;
            // 
            // TxtQty
            // 
            this.TxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.ForeColor = System.Drawing.Color.Magenta;
            this.TxtQty.Location = new System.Drawing.Point(700, 48);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(118, 27);
            this.TxtQty.TabIndex = 2;
            this.TxtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtQty_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(844, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(696, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(557, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(422, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Available Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine Name";
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalBill.Enabled = false;
            this.txtTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBill.ForeColor = System.Drawing.Color.Magenta;
            this.txtTotalBill.Location = new System.Drawing.Point(985, 346);
            this.txtTotalBill.Multiline = true;
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(141, 27);
            this.txtTotalBill.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Magenta;
            this.txtTotal.Location = new System.Drawing.Point(848, 49);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(118, 27);
            this.txtTotal.TabIndex = 3;
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvailableQty.Enabled = false;
            this.txtAvailableQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQty.ForeColor = System.Drawing.Color.Magenta;
            this.txtAvailableQty.Location = new System.Drawing.Point(426, 51);
            this.txtAvailableQty.Multiline = true;
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ShortcutsEnabled = false;
            this.txtAvailableQty.Size = new System.Drawing.Size(107, 27);
            this.txtAvailableQty.TabIndex = 3;
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedicineId.Enabled = false;
            this.txtMedicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.ForeColor = System.Drawing.Color.Magenta;
            this.txtMedicineId.Location = new System.Drawing.Point(286, 13);
            this.txtMedicineId.Multiline = true;
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.ShortcutsEnabled = false;
            this.txtMedicineId.Size = new System.Drawing.Size(130, 27);
            this.txtMedicineId.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Magenta;
            this.txtPrice.Location = new System.Drawing.Point(561, 49);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ShortcutsEnabled = false;
            this.txtPrice.Size = new System.Drawing.Size(107, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.White;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.Magenta;
            this.BtnNext.Location = new System.Drawing.Point(997, 46);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(131, 35);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.White;
            this.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.Magenta;
            this.BtnPrint.Location = new System.Drawing.Point(807, 344);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(131, 35);
            this.BtnPrint.TabIndex = 4;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // DgvMediStore
            // 
            this.DgvMediStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMediStore.BackgroundColor = System.Drawing.Color.White;
            this.DgvMediStore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMediStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMediStore.GridColor = System.Drawing.Color.DarkGray;
            this.DgvMediStore.Location = new System.Drawing.Point(26, 100);
            this.DgvMediStore.Name = "DgvMediStore";
            this.DgvMediStore.ReadOnly = true;
            this.DgvMediStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMediStore.Size = new System.Drawing.Size(1102, 224);
            this.DgvMediStore.TabIndex = 80;
            this.DgvMediStore.DoubleClick += new System.EventHandler(this.DgvMediStore_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(499, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medi_Care";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1090, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bill Id :";
            // 
            // lbBillId
            // 
            this.lbBillId.AutoSize = true;
            this.lbBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillId.ForeColor = System.Drawing.Color.White;
            this.lbBillId.Location = new System.Drawing.Point(1147, 31);
            this.lbBillId.Name = "lbBillId";
            this.lbBillId.Size = new System.Drawing.Size(18, 20);
            this.lbBillId.TabIndex = 2;
            this.lbBillId.Text = "3";
            // 
            // MediStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBillId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "MediStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medi_Store";
            this.Load += new System.EventHandler(this.MediStore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMediStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmdMedicineName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridView DgvMediStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBillId;
    }
}