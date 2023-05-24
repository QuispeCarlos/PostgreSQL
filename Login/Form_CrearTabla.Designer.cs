namespace Login
{
    partial class Form_CrearTabla
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
            this.groupBox_general = new System.Windows.Forms.GroupBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.textBox_nombreTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_DB = new System.Windows.Forms.GroupBox();
            this.comboBox_bd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_tablas = new System.Windows.Forms.GroupBox();
            this.comboBox_tablas = new System.Windows.Forms.ComboBox();
            this.groupBox_general.SuspendLayout();
            this.groupBox_DB.SuspendLayout();
            this.groupBox_tablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_general
            // 
            this.groupBox_general.Controls.Add(this.button_cancelar);
            this.groupBox_general.Controls.Add(this.button_crear);
            this.groupBox_general.Controls.Add(this.textBox_nombreTabla);
            this.groupBox_general.Controls.Add(this.label1);
            this.groupBox_general.Location = new System.Drawing.Point(279, 12);
            this.groupBox_general.Name = "groupBox_general";
            this.groupBox_general.Size = new System.Drawing.Size(342, 299);
            this.groupBox_general.TabIndex = 2;
            this.groupBox_general.TabStop = false;
            this.groupBox_general.Text = "General";
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(194, 113);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(110, 32);
            this.button_cancelar.TabIndex = 4;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(68, 113);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(103, 32);
            this.button_crear.TabIndex = 3;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // textBox_nombreTabla
            // 
            this.textBox_nombreTabla.Location = new System.Drawing.Point(103, 35);
            this.textBox_nombreTabla.Name = "textBox_nombreTabla";
            this.textBox_nombreTabla.Size = new System.Drawing.Size(201, 22);
            this.textBox_nombreTabla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // groupBox_DB
            // 
            this.groupBox_DB.Controls.Add(this.comboBox_bd);
            this.groupBox_DB.Controls.Add(this.label2);
            this.groupBox_DB.Location = new System.Drawing.Point(12, 12);
            this.groupBox_DB.Name = "groupBox_DB";
            this.groupBox_DB.Size = new System.Drawing.Size(261, 299);
            this.groupBox_DB.TabIndex = 3;
            this.groupBox_DB.TabStop = false;
            this.groupBox_DB.Text = "BD";
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
            // groupBox_tablas
            // 
            this.groupBox_tablas.Controls.Add(this.comboBox_tablas);
            this.groupBox_tablas.Location = new System.Drawing.Point(627, 12);
            this.groupBox_tablas.Name = "groupBox_tablas";
            this.groupBox_tablas.Size = new System.Drawing.Size(200, 299);
            this.groupBox_tablas.TabIndex = 4;
            this.groupBox_tablas.TabStop = false;
            this.groupBox_tablas.Text = "Tablas Creadas";
            // 
            // comboBox_tablas
            // 
            this.comboBox_tablas.FormattingEnabled = true;
            this.comboBox_tablas.Location = new System.Drawing.Point(20, 33);
            this.comboBox_tablas.Name = "comboBox_tablas";
            this.comboBox_tablas.Size = new System.Drawing.Size(161, 24);
            this.comboBox_tablas.TabIndex = 0;
            // 
            // Form_CrearTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 384);
            this.Controls.Add(this.groupBox_tablas);
            this.Controls.Add(this.groupBox_DB);
            this.Controls.Add(this.groupBox_general);
            this.Name = "Form_CrearTabla";
            this.Text = "Form_CrearTabla";
            this.Load += new System.EventHandler(this.Form_CrearTabla_Load);
            this.groupBox_general.ResumeLayout(false);
            this.groupBox_general.PerformLayout();
            this.groupBox_DB.ResumeLayout(false);
            this.groupBox_DB.PerformLayout();
            this.groupBox_tablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_general;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.TextBox textBox_nombreTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.GroupBox groupBox_DB;
        private System.Windows.Forms.ComboBox comboBox_bd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_tablas;
        private System.Windows.Forms.ComboBox comboBox_tablas;
    }
}