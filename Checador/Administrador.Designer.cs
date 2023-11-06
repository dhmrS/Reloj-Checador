namespace Checador {
    partial class Administrador {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            Bt_nuevo_empleado = new Button();
            pb_Eliminar = new Button();
            SuspendLayout();
            // 
            // Bt_nuevo_empleado
            // 
            Bt_nuevo_empleado.BackColor = Color.FromArgb(224, 224, 224);
            Bt_nuevo_empleado.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Bt_nuevo_empleado.Location = new Point(59, 46);
            Bt_nuevo_empleado.Name = "Bt_nuevo_empleado";
            Bt_nuevo_empleado.Size = new Size(200, 40);
            Bt_nuevo_empleado.TabIndex = 3;
            Bt_nuevo_empleado.Text = "Ingresar Nuevo Empleado";
            Bt_nuevo_empleado.UseVisualStyleBackColor = false;
            Bt_nuevo_empleado.Click += Bt_nuevo_empleado_Click;
            // 
            // pb_Eliminar
            // 
            pb_Eliminar.BackColor = Color.FromArgb(255, 128, 128);
            pb_Eliminar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pb_Eliminar.Location = new Point(59, 110);
            pb_Eliminar.Name = "pb_Eliminar";
            pb_Eliminar.Size = new Size(200, 40);
            pb_Eliminar.TabIndex = 4;
            pb_Eliminar.Text = "Eliminar Usuario Existente";
            pb_Eliminar.UseVisualStyleBackColor = false;
            pb_Eliminar.Click += pb_Eliminar_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 234);
            Controls.Add(pb_Eliminar);
            Controls.Add(Bt_nuevo_empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            TopMost = true;
            Load += Administrador_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_nuevo_empleado;
        private Button pb_Eliminar;
    }
}