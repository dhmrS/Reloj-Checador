namespace Checador {
    partial class Nuevo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
            pb_Guardar_Nuevo_Empleado = new Button();
            tbox_Nombre = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            tbox_Apellido = new TextBox();
            lbl_Numero_de_Empleado = new Label();
            tbox_Numero_de_Empleado = new TextBox();
            SuspendLayout();
            // 
            // pb_Guardar_Nuevo_Empleado
            // 
            pb_Guardar_Nuevo_Empleado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            pb_Guardar_Nuevo_Empleado.Location = new Point(87, 213);
            pb_Guardar_Nuevo_Empleado.Name = "pb_Guardar_Nuevo_Empleado";
            pb_Guardar_Nuevo_Empleado.Size = new Size(189, 52);
            pb_Guardar_Nuevo_Empleado.TabIndex = 0;
            pb_Guardar_Nuevo_Empleado.Text = "Registrar";
            pb_Guardar_Nuevo_Empleado.UseVisualStyleBackColor = true;
            pb_Guardar_Nuevo_Empleado.Click += pb_Guardar_Nuevo_Empleado_Click;
            // 
            // tbox_Nombre
            // 
            tbox_Nombre.Location = new Point(164, 47);
            tbox_Nombre.Name = "tbox_Nombre";
            tbox_Nombre.Size = new Size(136, 23);
            tbox_Nombre.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nombre.Location = new Point(75, 47);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(81, 25);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Apellido.Location = new Point(75, 86);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(82, 25);
            lbl_Apellido.TabIndex = 4;
            lbl_Apellido.Text = "Apellido";
            // 
            // tbox_Apellido
            // 
            tbox_Apellido.Location = new Point(163, 88);
            tbox_Apellido.Name = "tbox_Apellido";
            tbox_Apellido.Size = new Size(136, 23);
            tbox_Apellido.TabIndex = 3;
            // 
            // lbl_Numero_de_Empleado
            // 
            lbl_Numero_de_Empleado.AutoSize = true;
            lbl_Numero_de_Empleado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Numero_de_Empleado.Location = new Point(15, 130);
            lbl_Numero_de_Empleado.Name = "lbl_Numero_de_Empleado";
            lbl_Numero_de_Empleado.Size = new Size(142, 25);
            lbl_Numero_de_Empleado.TabIndex = 6;
            lbl_Numero_de_Empleado.Text = "Num Empleado";
            // 
            // tbox_Numero_de_Empleado
            // 
            tbox_Numero_de_Empleado.Location = new Point(163, 130);
            tbox_Numero_de_Empleado.Name = "tbox_Numero_de_Empleado";
            tbox_Numero_de_Empleado.Size = new Size(136, 23);
            tbox_Numero_de_Empleado.TabIndex = 5;
            // 
            // Nuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 297);
            Controls.Add(lbl_Numero_de_Empleado);
            Controls.Add(tbox_Numero_de_Empleado);
            Controls.Add(lbl_Apellido);
            Controls.Add(tbox_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(tbox_Nombre);
            Controls.Add(pb_Guardar_Nuevo_Empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Nuevo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRAR NUEVO EMPLEADO";
            TopMost = true;
            Load += Nuevo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pb_Guardar_Nuevo_Empleado;
        private TextBox tbox_Nombre;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private TextBox tbox_Apellido;
        private Label lbl_Numero_de_Empleado;
        private TextBox tbox_Numero_de_Empleado;
    }
}