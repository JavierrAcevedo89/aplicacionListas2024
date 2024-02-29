namespace aplicacionListas
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
            txtBoxPelicula = new TextBox();
            listBoxPeliculas = new ListBox();
            label1 = new Label();
            btnPelicula = new Button();
            label2 = new Label();
            txtBoxGenero = new TextBox();
            label3 = new Label();
            txtBoxDuracion = new TextBox();
            label4 = new Label();
            txtBoxClasi = new TextBox();
            listBoxUsuarios = new ListBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBoxNombre = new TextBox();
            btnUsuario = new Button();
            listBoxRentas = new ListBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtBoxPelicula
            // 
            txtBoxPelicula.Location = new Point(143, 106);
            txtBoxPelicula.Name = "txtBoxPelicula";
            txtBoxPelicula.Size = new Size(150, 31);
            txtBoxPelicula.TabIndex = 0;
            // 
            // listBoxPeliculas
            // 
            listBoxPeliculas.FormattingEnabled = true;
            listBoxPeliculas.ItemHeight = 25;
            listBoxPeliculas.Location = new Point(90, 333);
            listBoxPeliculas.Name = "listBoxPeliculas";
            listBoxPeliculas.Size = new Size(259, 229);
            listBoxPeliculas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 109);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 2;
            label1.Text = "Película";
            // 
            // btnPelicula
            // 
            btnPelicula.Location = new Point(264, 254);
            btnPelicula.Name = "btnPelicula";
            btnPelicula.Size = new Size(154, 41);
            btnPelicula.TabIndex = 3;
            btnPelicula.Text = "Agregar Película";
            btnPelicula.UseVisualStyleBackColor = true;
            btnPelicula.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 182);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 5;
            label2.Text = "Género";
            // 
            // txtBoxGenero
            // 
            txtBoxGenero.Location = new Point(143, 179);
            txtBoxGenero.Name = "txtBoxGenero";
            txtBoxGenero.Size = new Size(150, 31);
            txtBoxGenero.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 182);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 9;
            label3.Text = "Duración";
            // 
            // txtBoxDuracion
            // 
            txtBoxDuracion.Location = new Point(446, 179);
            txtBoxDuracion.Name = "txtBoxDuracion";
            txtBoxDuracion.Size = new Size(150, 31);
            txtBoxDuracion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 109);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 7;
            label4.Text = "Clasificación";
            // 
            // txtBoxClasi
            // 
            txtBoxClasi.Location = new Point(446, 109);
            txtBoxClasi.Name = "txtBoxClasi";
            txtBoxClasi.Size = new Size(150, 31);
            txtBoxClasi.TabIndex = 6;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.ItemHeight = 25;
            listBoxUsuarios.Location = new Point(679, 333);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(259, 229);
            listBoxUsuarios.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 24);
            label5.Name = "label5";
            label5.Size = new Size(129, 25);
            label5.TabIndex = 11;
            label5.Text = "Datos Películas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(761, 24);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 12;
            label6.Text = "Datos Usuarios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(679, 112);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 14;
            label7.Text = "Nombre";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(778, 109);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(150, 31);
            txtBoxNombre.TabIndex = 13;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(749, 254);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(154, 41);
            btnUsuario.TabIndex = 15;
            btnUsuario.Text = "Agregar Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // listBoxRentas
            // 
            listBoxRentas.FormattingEnabled = true;
            listBoxRentas.ItemHeight = 25;
            listBoxRentas.Location = new Point(1283, 83);
            listBoxRentas.Name = "listBoxRentas";
            listBoxRentas.Size = new Size(379, 479);
            listBoxRentas.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(1052, 254);
            button1.Name = "button1";
            button1.Size = new Size(154, 41);
            button1.TabIndex = 17;
            button1.Text = "Registrar Renta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 582);
            label8.Name = "label8";
            label8.Size = new Size(253, 25);
            label8.TabIndex = 18;
            label8.Text = "Seleccionar título de la película";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(679, 582);
            label9.Name = "label9";
            label9.Size = new Size(163, 25);
            label9.TabIndex = 19;
            label9.Text = "Seleccionar usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1735, 669);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(listBoxRentas);
            Controls.Add(btnUsuario);
            Controls.Add(label7);
            Controls.Add(txtBoxNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBoxUsuarios);
            Controls.Add(label3);
            Controls.Add(txtBoxDuracion);
            Controls.Add(label4);
            Controls.Add(txtBoxClasi);
            Controls.Add(label2);
            Controls.Add(txtBoxGenero);
            Controls.Add(btnPelicula);
            Controls.Add(label1);
            Controls.Add(listBoxPeliculas);
            Controls.Add(txtBoxPelicula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPelicula;
        private ListBox listBoxPeliculas;
        private Label label1;
        private Button btnPelicula;
        private Label label2;
        private TextBox txtBoxGenero;
        private Label label3;
        private TextBox txtBoxDuracion;
        private Label label4;
        private TextBox txtBoxClasi;
        private ListBox listBoxUsuarios;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBoxNombre;
        private Button btnUsuario;
        private ListBox listBoxRentas;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}
