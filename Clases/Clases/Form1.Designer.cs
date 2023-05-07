namespace Clases
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrueba = new System.Windows.Forms.Button();
            this.txtNombreGET = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidoGET = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_cupon = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_desc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_fin = new System.Windows.Forms.Label();
            this.label_inicio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.btn_canjear = new System.Windows.Forms.Button();
            this.txt_mensaje = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(31, 193);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(182, 53);
            this.btnPrueba.TabIndex = 0;
            this.btnPrueba.Text = "Ver";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // txtNombreGET
            // 
            this.txtNombreGET.Enabled = false;
            this.txtNombreGET.Location = new System.Drawing.Point(71, 131);
            this.txtNombreGET.Name = "txtNombreGET";
            this.txtNombreGET.Size = new System.Drawing.Size(142, 20);
            this.txtNombreGET.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres:";
            // 
            // txtApellidoGET
            // 
            this.txtApellidoGET.Enabled = false;
            this.txtApellidoGET.Location = new System.Drawing.Point(71, 167);
            this.txtApellidoGET.Name = "txtApellidoGET";
            this.txtApellidoGET.Size = new System.Drawing.Size(142, 20);
            this.txtApellidoGET.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // cod_cupon
            // 
            this.cod_cupon.Location = new System.Drawing.Point(16, 58);
            this.cod_cupon.Name = "cod_cupon";
            this.cod_cupon.Size = new System.Drawing.Size(196, 20);
            this.cod_cupon.TabIndex = 10;
            this.cod_cupon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPrueba);
            this.groupBox1.Controls.Add(this.cod_cupon);
            this.groupBox1.Controls.Add(this.txtNombreGET);
            this.groupBox1.Controls.Add(this.txtApellidoGET);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 272);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "codCupon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Location = new System.Drawing.Point(275, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // txt_desc
            // 
            this.txt_desc.AutoSize = true;
            this.txt_desc.Location = new System.Drawing.Point(7, 28);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(0, 13);
            this.txt_desc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha Limite:";
            // 
            // label_fin
            // 
            this.label_fin.AutoSize = true;
            this.label_fin.Location = new System.Drawing.Point(415, 151);
            this.label_fin.Name = "label_fin";
            this.label_fin.Size = new System.Drawing.Size(10, 13);
            this.label_fin.TabIndex = 15;
            this.label_fin.Text = ".";
            // 
            // label_inicio
            // 
            this.label_inicio.AutoSize = true;
            this.label_inicio.Location = new System.Drawing.Point(300, 151);
            this.label_inicio.Name = "label_inicio";
            this.label_inicio.Size = new System.Drawing.Size(10, 13);
            this.label_inicio.TabIndex = 16;
            this.label_inicio.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Estado:";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(285, 206);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(150, 20);
            this.txt_estado.TabIndex = 18;
            // 
            // btn_canjear
            // 
            this.btn_canjear.Location = new System.Drawing.Point(303, 247);
            this.btn_canjear.Name = "btn_canjear";
            this.btn_canjear.Size = new System.Drawing.Size(117, 38);
            this.btn_canjear.TabIndex = 19;
            this.btn_canjear.Text = "CANJEAR";
            this.btn_canjear.UseVisualStyleBackColor = true;
            this.btn_canjear.Click += new System.EventHandler(this.btn_canjear_Click);
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.AutoSize = true;
            this.txt_mensaje.Location = new System.Drawing.Point(314, 297);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(10, 13);
            this.txt_mensaje.TabIndex = 20;
            this.txt_mensaje.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(508, 350);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.btn_canjear);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_inicio);
            this.Controls.Add(this.label_fin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Prueba API";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.TextBox txtNombreGET;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellidoGET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod_cupon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txt_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_fin;
        private System.Windows.Forms.Label label_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Button btn_canjear;
        private System.Windows.Forms.Label txt_mensaje;
    }
}

