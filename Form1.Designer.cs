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
            txtBoxIngresar = new TextBox();
            listBoxMostrar = new ListBox();
            label1 = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txtBoxIngresar
            // 
            txtBoxIngresar.Location = new Point(425, 126);
            txtBoxIngresar.Name = "txtBoxIngresar";
            txtBoxIngresar.Size = new Size(150, 31);
            txtBoxIngresar.TabIndex = 0;
            // 
            // listBoxMostrar
            // 
            listBoxMostrar.FormattingEnabled = true;
            listBoxMostrar.ItemHeight = 25;
            listBoxMostrar.Location = new Point(324, 276);
            listBoxMostrar.Name = "listBoxMostrar";
            listBoxMostrar.Size = new Size(251, 229);
            listBoxMostrar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 129);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 2;
            label1.Text = "Ingresar película";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(387, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 582);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(listBoxMostrar);
            Controls.Add(txtBoxIngresar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxIngresar;
        private ListBox listBoxMostrar;
        private Label label1;
        private Button btnAgregar;
    }
}
