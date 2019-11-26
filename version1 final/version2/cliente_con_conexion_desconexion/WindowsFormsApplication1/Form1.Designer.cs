namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.color_dame = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ganador = new System.Windows.Forms.RadioButton();
            this.LOGIN = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.labcolor = new System.Windows.Forms.Label();
            this.Tantoporciento = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.AutoSizeChanged += new System.EventHandler(this.Label2_AutoSizeChanged);
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(152, 32);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(126, 20);
            this.nombre.TabIndex = 3;
            this.nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(653, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Tantoporciento);
            this.groupBox1.Controls.Add(this.labcolor);
            this.groupBox1.Controls.Add(this.color_dame);
            this.groupBox1.Controls.Add(this.contraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ganador);
            this.groupBox1.Controls.Add(this.LOGIN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.Edad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 249);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // color_dame
            // 
            this.color_dame.Location = new System.Drawing.Point(67, 157);
            this.color_dame.Name = "color_dame";
            this.color_dame.Size = new System.Drawing.Size(126, 20);
            this.color_dame.TabIndex = 12;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(152, 57);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(126, 20);
            this.contraseña.TabIndex = 11;
            this.contraseña.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Contraseña_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Ganador
            // 
            this.Ganador.AutoSize = true;
            this.Ganador.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganador.Location = new System.Drawing.Point(199, 111);
            this.Ganador.Name = "Ganador";
            this.Ganador.Size = new System.Drawing.Size(124, 21);
            this.Ganador.TabIndex = 7;
            this.Ganador.TabStop = true;
            this.Ganador.Text = "Dame el ganador";
            this.Ganador.UseVisualStyleBackColor = true;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(337, 32);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(78, 24);
            this.LOGIN.TabIndex = 7;
            this.LOGIN.TabStop = true;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.CheckedChanged += new System.EventHandler(this.LOGIN_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(67, 112);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(126, 20);
            this.Fecha.TabIndex = 9;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(199, 140);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(279, 21);
            this.Edad.TabIndex = 8;
            this.Edad.TabStop = true;
            this.Edad.Text = "Edad media de los ganadores con ese color";
            this.Edad.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(653, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labcolor
            // 
            this.labcolor.AutoSize = true;
            this.labcolor.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcolor.Location = new System.Drawing.Point(26, 160);
            this.labcolor.Name = "labcolor";
            this.labcolor.Size = new System.Drawing.Size(35, 17);
            this.labcolor.TabIndex = 13;
            this.labcolor.Text = "Color";
            this.labcolor.Click += new System.EventHandler(this.Labcolor_Click);
            // 
            // Tantoporciento
            // 
            this.Tantoporciento.AutoSize = true;
            this.Tantoporciento.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tantoporciento.Location = new System.Drawing.Point(199, 176);
            this.Tantoporciento.Name = "Tantoporciento";
            this.Tantoporciento.Size = new System.Drawing.Size(221, 21);
            this.Tantoporciento.TabIndex = 15;
            this.Tantoporciento.TabStop = true;
            this.Tantoporciento.Text = "% partidas ganadas con ese color";
            this.Tantoporciento.UseVisualStyleBackColor = true;
            this.Tantoporciento.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Ganador;
        private System.Windows.Forms.RadioButton Edad;
        private System.Windows.Forms.RadioButton LOGIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fecha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox color_dame;
        private System.Windows.Forms.Label labcolor;
        private System.Windows.Forms.RadioButton Tantoporciento;
    }
}

