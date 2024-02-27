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
            listBoxMostrar = new ListBox();
            label1 = new Label();
            btnAgregar = new Button();
            label2 = new Label();
            txtBoxGenero = new TextBox();
            label3 = new Label();
            txtBoxDuracion = new TextBox();
            label4 = new Label();
            txtBoxClasi = new TextBox();
            SuspendLayout();
            // 
            // txtBoxPelicula
            // 
            txtBoxPelicula.Location = new Point(199, 42);
            txtBoxPelicula.Name = "txtBoxPelicula";
            txtBoxPelicula.Size = new Size(150, 31);
            txtBoxPelicula.TabIndex = 0;
            // 
            // listBoxMostrar
            // 
            listBoxMostrar.FormattingEnabled = true;
            listBoxMostrar.ItemHeight = 25;
            listBoxMostrar.Location = new Point(41, 273);
            listBoxMostrar.Name = "listBoxMostrar";
            listBoxMostrar.Size = new Size(802, 229);
            listBoxMostrar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 2;
            label1.Text = "Película";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(431, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 5;
            label2.Text = "Género";
            // 
            // txtBoxGenero
            // 
            txtBoxGenero.Location = new Point(199, 115);
            txtBoxGenero.Name = "txtBoxGenero";
            txtBoxGenero.Size = new Size(150, 31);
            txtBoxGenero.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 118);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 9;
            label3.Text = "Duración";
            // 
            // txtBoxDuracion
            // 
            txtBoxDuracion.Location = new Point(548, 115);
            txtBoxDuracion.Name = "txtBoxDuracion";
            txtBoxDuracion.Size = new Size(150, 31);
            txtBoxDuracion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 45);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 7;
            label4.Text = "Clasificación";
            // 
            // txtBoxClasi
            // 
            txtBoxClasi.Location = new Point(548, 45);
            txtBoxClasi.Name = "txtBoxClasi";
            txtBoxClasi.Size = new Size(150, 31);
            txtBoxClasi.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 582);
            Controls.Add(label3);
            Controls.Add(txtBoxDuracion);
            Controls.Add(label4);
            Controls.Add(txtBoxClasi);
            Controls.Add(label2);
            Controls.Add(txtBoxGenero);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(listBoxMostrar);
            Controls.Add(txtBoxPelicula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxPelicula;
        private ListBox listBoxMostrar;
        private Label label1;
        private Button btnAgregar;
        private Label label2;
        private TextBox txtBoxGenero;
        private Label label3;
        private TextBox txtBoxDuracion;
        private Label label4;
        private TextBox txtBoxClasi;
    }
}
