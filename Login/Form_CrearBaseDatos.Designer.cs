namespace Login
{
    partial class Form_CrearBaseDatos
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
            this.textBox_nombreBaseDatos = new System.Windows.Forms.TextBox();
            this.button_crear = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombreBaseDatos
            // 
            this.textBox_nombreBaseDatos.Location = new System.Drawing.Point(265, 43);
            this.textBox_nombreBaseDatos.Name = "textBox_nombreBaseDatos";
            this.textBox_nombreBaseDatos.Size = new System.Drawing.Size(167, 22);
            this.textBox_nombreBaseDatos.TabIndex = 1;
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(174, 129);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(114, 32);
            this.button_crear.TabIndex = 2;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(318, 129);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(114, 32);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // Form_CrearBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 197);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.textBox_nombreBaseDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form_CrearBaseDatos";
            this.Text = "Form_CrearBaseDatos";
            this.Load += new System.EventHandler(this.Form_CrearBaseDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombreBaseDatos;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_cancelar;
    }
}