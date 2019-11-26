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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Añadir = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Jugarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvitadortextBox3 = new System.Windows.Forms.TextBox();
            this.Rechazarbtn = new System.Windows.Forms.Button();
            this.Aceptarbtn = new System.Windows.Forms.Button();
            this.Invitacion_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listacon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLbl = new System.Windows.Forms.Label();
            this.tablero = new System.Windows.Forms.Panel();
            this.amarilloLbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Tantoporciento = new System.Windows.Forms.RadioButton();
            this.labcolor = new System.Windows.Forms.Label();
            this.color_dame = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ganador = new System.Windows.Forms.RadioButton();
            this.LOGIN = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.Añadir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.AutoSizeChanged += new System.EventHandler(this.Label2_AutoSizeChanged);
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(124, 30);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(126, 20);
            this.nombre.TabIndex = 3;
            this.nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(909, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Añadir
            // 
            this.Añadir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Añadir.Controls.Add(this.panel2);
            this.Añadir.Controls.Add(this.Jugarbutton);
            this.Añadir.Controls.Add(this.label4);
            this.Añadir.Controls.Add(this.textBox1);
            this.Añadir.Controls.Add(this.panel1);
            this.Añadir.Controls.Add(this.dataGridView1);
            this.Añadir.Controls.Add(this.numeroLbl);
            this.Añadir.Controls.Add(this.tablero);
            this.Añadir.Controls.Add(this.button4);
            this.Añadir.Controls.Add(this.Tantoporciento);
            this.Añadir.Controls.Add(this.labcolor);
            this.Añadir.Controls.Add(this.color_dame);
            this.Añadir.Controls.Add(this.contraseña);
            this.Añadir.Controls.Add(this.label1);
            this.Añadir.Controls.Add(this.Ganador);
            this.Añadir.Controls.Add(this.LOGIN);
            this.Añadir.Controls.Add(this.label3);
            this.Añadir.Controls.Add(this.Fecha);
            this.Añadir.Controls.Add(this.Edad);
            this.Añadir.Controls.Add(this.label2);
            this.Añadir.Controls.Add(this.button2);
            this.Añadir.Controls.Add(this.nombre);
            this.Añadir.Location = new System.Drawing.Point(12, 52);
            this.Añadir.Name = "Añadir";
            this.Añadir.Size = new System.Drawing.Size(1128, 488);
            this.Añadir.TabIndex = 6;
            this.Añadir.TabStop = false;
            this.Añadir.Text = "Peticion";
            this.Añadir.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(318, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 38);
            this.panel2.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 31;
            // 
            // Jugarbutton
            // 
            this.Jugarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Jugarbutton.Location = new System.Drawing.Point(395, 346);
            this.Jugarbutton.Name = "Jugarbutton";
            this.Jugarbutton.Size = new System.Drawing.Size(84, 31);
            this.Jugarbutton.TabIndex = 30;
            this.Jugarbutton.Text = "Invitar";
            this.Jugarbutton.UseVisualStyleBackColor = true;
            this.Jugarbutton.Click += new System.EventHandler(this.Jugarbutton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.InvitadortextBox3);
            this.panel1.Controls.Add(this.Rechazarbtn);
            this.panel1.Controls.Add(this.Aceptarbtn);
            this.panel1.Controls.Add(this.Invitacion_lbl);
            this.panel1.Location = new System.Drawing.Point(318, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 96);
            this.panel1.TabIndex = 27;
            // 
            // InvitadortextBox3
            // 
            this.InvitadortextBox3.Location = new System.Drawing.Point(168, 22);
            this.InvitadortextBox3.Name = "InvitadortextBox3";
            this.InvitadortextBox3.Size = new System.Drawing.Size(58, 20);
            this.InvitadortextBox3.TabIndex = 31;
            // 
            // Rechazarbtn
            // 
            this.Rechazarbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Rechazarbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rechazarbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Rechazarbtn.Location = new System.Drawing.Point(151, 59);
            this.Rechazarbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Rechazarbtn.Name = "Rechazarbtn";
            this.Rechazarbtn.Size = new System.Drawing.Size(75, 23);
            this.Rechazarbtn.TabIndex = 0;
            this.Rechazarbtn.Text = "No";
            this.Rechazarbtn.UseVisualStyleBackColor = false;
            // 
            // Aceptarbtn
            // 
            this.Aceptarbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Aceptarbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Aceptarbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Aceptarbtn.Location = new System.Drawing.Point(27, 59);
            this.Aceptarbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Aceptarbtn.Name = "Aceptarbtn";
            this.Aceptarbtn.Size = new System.Drawing.Size(75, 23);
            this.Aceptarbtn.TabIndex = 1;
            this.Aceptarbtn.Text = "Si";
            this.Aceptarbtn.UseVisualStyleBackColor = false;
            this.Aceptarbtn.Click += new System.EventHandler(this.Aceptarbtn_Click_1);
            // 
            // Invitacion_lbl
            // 
            this.Invitacion_lbl.AutoSize = true;
            this.Invitacion_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Invitacion_lbl.Location = new System.Drawing.Point(15, 25);
            this.Invitacion_lbl.Name = "Invitacion_lbl";
            this.Invitacion_lbl.Size = new System.Drawing.Size(223, 13);
            this.Invitacion_lbl.TabIndex = 0;
            this.Invitacion_lbl.Text = "Desea aceptar la invitacion de                      ?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listacon});
            this.dataGridView1.Location = new System.Drawing.Point(377, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(126, 183);
            this.dataGridView1.TabIndex = 26;
            // 
            // listacon
            // 
            this.listacon.HeaderText = "Lista de conectados";
            this.listacon.Name = "listacon";
            // 
            // numeroLbl
            // 
            this.numeroLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLbl.Location = new System.Drawing.Point(528, 416);
            this.numeroLbl.Name = "numeroLbl";
            this.numeroLbl.Size = new System.Drawing.Size(61, 62);
            this.numeroLbl.TabIndex = 25;
            this.numeroLbl.Text = "0";
            this.numeroLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablero
            // 
            this.tablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tablero.BackgroundImage")));
            this.tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablero.Controls.Add(this.amarilloLbl);
            this.tablero.Location = new System.Drawing.Point(595, 10);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(516, 468);
            this.tablero.TabIndex = 23;
            // 
            // amarilloLbl
            // 
            this.amarilloLbl.BackColor = System.Drawing.Color.Yellow;
            this.amarilloLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amarilloLbl.Location = new System.Drawing.Point(675, 534);
            this.amarilloLbl.Name = "amarilloLbl";
            this.amarilloLbl.Size = new System.Drawing.Size(28, 29);
            this.amarilloLbl.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(527, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 62);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tantoporciento
            // 
            this.Tantoporciento.AutoSize = true;
            this.Tantoporciento.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tantoporciento.Location = new System.Drawing.Point(29, 276);
            this.Tantoporciento.Name = "Tantoporciento";
            this.Tantoporciento.Size = new System.Drawing.Size(221, 21);
            this.Tantoporciento.TabIndex = 15;
            this.Tantoporciento.TabStop = true;
            this.Tantoporciento.Text = "% partidas ganadas con ese color";
            this.Tantoporciento.UseVisualStyleBackColor = true;
            this.Tantoporciento.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // labcolor
            // 
            this.labcolor.AutoSize = true;
            this.labcolor.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcolor.Location = new System.Drawing.Point(26, 186);
            this.labcolor.Name = "labcolor";
            this.labcolor.Size = new System.Drawing.Size(35, 17);
            this.labcolor.TabIndex = 13;
            this.labcolor.Text = "Color";
            this.labcolor.Click += new System.EventHandler(this.Labcolor_Click);
            // 
            // color_dame
            // 
            this.color_dame.Location = new System.Drawing.Point(67, 186);
            this.color_dame.Name = "color_dame";
            this.color_dame.Size = new System.Drawing.Size(126, 20);
            this.color_dame.TabIndex = 12;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(124, 56);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(126, 20);
            this.contraseña.TabIndex = 11;
            this.contraseña.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Contraseña_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
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
            this.Ganador.Location = new System.Drawing.Point(27, 222);
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
            this.LOGIN.Location = new System.Drawing.Point(76, 82);
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
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(67, 155);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(126, 20);
            this.Fecha.TabIndex = 9;
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(27, 249);
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
            this.button3.Location = new System.Drawing.Point(12, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1012, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Añadir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Añadir.ResumeLayout(false);
            this.Añadir.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tablero.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox Añadir;
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
        private System.Windows.Forms.Label numeroLbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Label amarilloLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn listacon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InvitadortextBox3;
        private System.Windows.Forms.Button Rechazarbtn;
        private System.Windows.Forms.Button Aceptarbtn;
        private System.Windows.Forms.Label Invitacion_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Jugarbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

