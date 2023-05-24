namespace Login
{
    partial class Form_VerRegistros
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
            this.groupBox_DB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox_bd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Registros = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_DB.SuspendLayout();
            this.groupBox_Registros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_DB
            // 
            this.groupBox_DB.Controls.Add(this.label1);
            this.groupBox_DB.Controls.Add(this.comboBox2);
            this.groupBox_DB.Controls.Add(this.comboBox_bd);
            this.groupBox_DB.Controls.Add(this.label2);
            this.groupBox_DB.Location = new System.Drawing.Point(12, 12);
            this.groupBox_DB.Name = "groupBox_DB";
            this.groupBox_DB.Size = new System.Drawing.Size(250, 374);
            this.groupBox_DB.TabIndex = 7;
            this.groupBox_DB.TabStop = false;
            this.groupBox_DB.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la tabla:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox_bd
            // 
            this.comboBox_bd.FormattingEnabled = true;
            this.comboBox_bd.Location = new System.Drawing.Point(24, 76);
            this.comboBox_bd.Name = "comboBox_bd";
            this.comboBox_bd.Size = new System.Drawing.Size(212, 24);
            this.comboBox_bd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione la base de datos:";
            // 
            // groupBox_Registros
            // 
            this.groupBox_Registros.Controls.Add(this.dataGridView1);
            this.groupBox_Registros.Location = new System.Drawing.Point(268, 12);
            this.groupBox_Registros.Name = "groupBox_Registros";
            this.groupBox_Registros.Size = new System.Drawing.Size(549, 374);
            this.groupBox_Registros.TabIndex = 8;
            this.groupBox_Registros.TabStop = false;
            this.groupBox_Registros.Text = "Registros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form_VerRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.groupBox_Registros);
            this.Controls.Add(this.groupBox_DB);
            this.Name = "Form_VerRegistros";
            this.Text = "Form_VerRegistros";
            this.Load += new System.EventHandler(this.Form_VerRegistros_Load);
            this.groupBox_DB.ResumeLayout(false);
            this.groupBox_DB.PerformLayout();
            this.groupBox_Registros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox_bd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_Registros;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}