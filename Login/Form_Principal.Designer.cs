namespace Login
{
    partial class Form_Principal
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
            this.groupBox_PostgreSQL = new System.Windows.Forms.GroupBox();
            this.button_refrescar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.comboBox_databases = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_informacion = new System.Windows.Forms.GroupBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.groupBox_PostgreSQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_PostgreSQL
            // 
            this.groupBox_PostgreSQL.Controls.Add(this.button_eliminar);
            this.groupBox_PostgreSQL.Controls.Add(this.button_refrescar);
            this.groupBox_PostgreSQL.Controls.Add(this.button_crear);
            this.groupBox_PostgreSQL.Controls.Add(this.comboBox_databases);
            this.groupBox_PostgreSQL.Controls.Add(this.label3);
            this.groupBox_PostgreSQL.Controls.Add(this.label2);
            this.groupBox_PostgreSQL.Controls.Add(this.label1);
            this.groupBox_PostgreSQL.Location = new System.Drawing.Point(21, 12);
            this.groupBox_PostgreSQL.Name = "groupBox_PostgreSQL";
            this.groupBox_PostgreSQL.Size = new System.Drawing.Size(275, 519);
            this.groupBox_PostgreSQL.TabIndex = 0;
            this.groupBox_PostgreSQL.TabStop = false;
            this.groupBox_PostgreSQL.Text = "PostgreSQL 15";
            // 
            // button_refrescar
            // 
            this.button_refrescar.Location = new System.Drawing.Point(176, 85);
            this.button_refrescar.Name = "button_refrescar";
            this.button_refrescar.Size = new System.Drawing.Size(93, 29);
            this.button_refrescar.TabIndex = 5;
            this.button_refrescar.Text = "Refrescar";
            this.button_refrescar.UseVisualStyleBackColor = true;
            this.button_refrescar.Click += new System.EventHandler(this.button_refrescar_Click);
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(176, 50);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(93, 29);
            this.button_crear.TabIndex = 4;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // comboBox_databases
            // 
            this.comboBox_databases.FormattingEnabled = true;
            this.comboBox_databases.Location = new System.Drawing.Point(9, 130);
            this.comboBox_databases.Name = "comboBox_databases";
            this.comboBox_databases.Size = new System.Drawing.Size(154, 24);
            this.comboBox_databases.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tablespaces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login/Group Roles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // groupBox_informacion
            // 
            this.groupBox_informacion.Location = new System.Drawing.Point(302, 12);
            this.groupBox_informacion.Name = "groupBox_informacion";
            this.groupBox_informacion.Size = new System.Drawing.Size(626, 519);
            this.groupBox_informacion.TabIndex = 1;
            this.groupBox_informacion.TabStop = false;
            this.groupBox_informacion.Text = "Opciones";
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(176, 130);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(93, 29);
            this.button_eliminar.TabIndex = 6;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 578);
            this.Controls.Add(this.groupBox_informacion);
            this.Controls.Add(this.groupBox_PostgreSQL);
            this.Name = "Form_Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox_PostgreSQL.ResumeLayout(false);
            this.groupBox_PostgreSQL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PostgreSQL;
        private System.Windows.Forms.GroupBox groupBox_informacion;
        private System.Windows.Forms.ComboBox comboBox_databases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_refrescar;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_eliminar;
    }
}