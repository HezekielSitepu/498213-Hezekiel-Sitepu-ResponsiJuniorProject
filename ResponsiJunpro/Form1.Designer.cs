namespace ResponsiJunpro
{
    partial class Form1
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblKaryawan = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.txtNamaKaryawan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDepKaryawan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(42, 159);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(179, 159);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(319, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblKaryawan
            // 
            this.lblKaryawan.AutoSize = true;
            this.lblKaryawan.Location = new System.Drawing.Point(39, 65);
            this.lblKaryawan.Name = "lblKaryawan";
            this.lblKaryawan.Size = new System.Drawing.Size(94, 13);
            this.lblKaryawan.TabIndex = 3;
            this.lblKaryawan.Text = "Nama Karyawan : ";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(39, 107);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(80, 13);
            this.lblDep.TabIndex = 4;
            this.lblDep.Text = "Dep. Karyawan";
            // 
            // txtNamaKaryawan
            // 
            this.txtNamaKaryawan.Location = new System.Drawing.Point(139, 65);
            this.txtNamaKaryawan.Name = "txtNamaKaryawan";
            this.txtNamaKaryawan.Size = new System.Drawing.Size(100, 20);
            this.txtNamaKaryawan.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 180);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDepKaryawan
            // 
            this.txtDepKaryawan.Location = new System.Drawing.Point(139, 104);
            this.txtDepKaryawan.Name = "txtDepKaryawan";
            this.txtDepKaryawan.Size = new System.Drawing.Size(100, 20);
            this.txtDepKaryawan.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepKaryawan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNamaKaryawan);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblKaryawan);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblKaryawan;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.TextBox txtNamaKaryawan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDepKaryawan;
        private System.Windows.Forms.Label label1;
    }
}

