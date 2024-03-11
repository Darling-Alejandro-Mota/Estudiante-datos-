namespace Estudiante_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Matricula = new Label();
            Nombre = new Label();
            Apellido = new Label();
            Edad = new Label();
            Correo = new Label();
            btn_Limpiar = new Button();
            btn_Salir = new Button();
            btn_Ingresar = new Button();
            txt_Matricula = new TextBox();
            txt_Correo = new TextBox();
            txt_Edad = new TextBox();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            txt_datos = new TextBox();
            Datos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Matricula
            // 
            Matricula.AutoSize = true;
            Matricula.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Matricula.Location = new Point(12, 23);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(71, 17);
            Matricula.TabIndex = 0;
            Matricula.Text = "Matricula";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Nombre.Location = new Point(186, 124);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(61, 17);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Apellido.Location = new Point(186, 170);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(63, 17);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Edad.Location = new Point(186, 215);
            Edad.Name = "Edad";
            Edad.Size = new Size(41, 17);
            Edad.TabIndex = 3;
            Edad.Text = "Edad";
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Correo.Location = new Point(31, 54);
            Correo.Name = "Correo";
            Correo.Size = new Size(55, 17);
            Correo.TabIndex = 4;
            Correo.Text = "Correo";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.ControlLightLight;
            btn_Limpiar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Limpiar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Limpiar.Location = new Point(566, 138);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(122, 54);
            btn_Limpiar.TabIndex = 12;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.ControlLightLight;
            btn_Salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Salir.ForeColor = SystemColors.ActiveCaptionText;
            btn_Salir.Location = new Point(566, 215);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(122, 54);
            btn_Salir.TabIndex = 13;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = SystemColors.ControlLightLight;
            btn_Ingresar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Ingresar.ForeColor = SystemColors.ActiveCaptionText;
            btn_Ingresar.Location = new Point(565, 64);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(121, 54);
            btn_Ingresar.TabIndex = 14;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_Matricula.Location = new Point(114, 23);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(106, 25);
            txt_Matricula.TabIndex = 15;
            txt_Matricula.TextChanged += txt_Matricula_TextChanged;
            // 
            // txt_Correo
            // 
            txt_Correo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_Correo.Location = new Point(114, 54);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(106, 25);
            txt_Correo.TabIndex = 17;
            // 
            // txt_Edad
            // 
            txt_Edad.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_Edad.Location = new Point(269, 215);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(106, 25);
            txt_Edad.TabIndex = 18;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_Apellido.Location = new Point(269, 167);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(106, 25);
            txt_Apellido.TabIndex = 19;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_Nombre.Location = new Point(269, 121);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(106, 25);
            txt_Nombre.TabIndex = 20;
            // 
            // txt_datos
            // 
            txt_datos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            txt_datos.Location = new Point(277, 299);
            txt_datos.Name = "txt_datos";
            txt_datos.Size = new Size(411, 25);
            txt_datos.TabIndex = 21;
            txt_datos.TextChanged += txt_datos_TextChanged;
            // 
            // Datos
            // 
            Datos.AutoSize = true;
            Datos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            Datos.Location = new Point(201, 302);
            Datos.Name = "Datos";
            Datos.Size = new Size(46, 17);
            Datos.TabIndex = 22;
            Datos.Text = "Datos";
            Datos.Click += Datos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Bold);
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 34);
            label1.TabIndex = 23;
            label1.Text = "Estudiante";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Datos);
            Controls.Add(txt_datos);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Matricula);
            Controls.Add(btn_Ingresar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Limpiar);
            Controls.Add(Correo);
            Controls.Add(Edad);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Matricula);
            ForeColor = SystemColors.Desktop;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Matricula;
        private Label Nombre;
        private Label Apellido;
        private Label Edad;
        private Label Correo;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Button btn_Ingresar;
        private TextBox txt_Matricula;
        private TextBox txt_Correo;
        private TextBox txt_Edad;
        private TextBox txt_Apellido;
        private TextBox txt_Nombre;
        private Label Informacion;
        private TextBox txt_datos;
        private Label Datos;
        private Label label1;
    }
}