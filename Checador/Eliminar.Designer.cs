namespace Checador {
    partial class borrar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrar));
            pb_Eliminar_Empleado = new Button();
            tbox_num_emple_p_elminar = new TextBox();
            lbl_num_empleado_eliminar = new Label();
            SuspendLayout();
            // 
            // pb_Eliminar_Empleado
            // 
            pb_Eliminar_Empleado.BackColor = Color.Red;
            pb_Eliminar_Empleado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pb_Eliminar_Empleado.ForeColor = Color.White;
            pb_Eliminar_Empleado.Location = new Point(161, 111);
            pb_Eliminar_Empleado.Name = "pb_Eliminar_Empleado";
            pb_Eliminar_Empleado.Size = new Size(228, 34);
            pb_Eliminar_Empleado.TabIndex = 0;
            pb_Eliminar_Empleado.Text = "ELIMINAR EMPLEADO";
            pb_Eliminar_Empleado.UseVisualStyleBackColor = false;
            pb_Eliminar_Empleado.Click += pb_Eliminar_Empleado_Click;
            // 
            // tbox_num_emple_p_elminar
            // 
            tbox_num_emple_p_elminar.Location = new Point(248, 51);
            tbox_num_emple_p_elminar.Name = "tbox_num_emple_p_elminar";
            tbox_num_emple_p_elminar.Size = new Size(207, 23);
            tbox_num_emple_p_elminar.TabIndex = 6;
            // 
            // lbl_num_empleado_eliminar
            // 
            lbl_num_empleado_eliminar.AutoSize = true;
            lbl_num_empleado_eliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_num_empleado_eliminar.Location = new Point(12, 50);
            lbl_num_empleado_eliminar.Name = "lbl_num_empleado_eliminar";
            lbl_num_empleado_eliminar.Size = new Size(208, 20);
            lbl_num_empleado_eliminar.TabIndex = 5;
            lbl_num_empleado_eliminar.Text = "Ingrese Número de Empleado";
            // 
            // borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(563, 172);
            Controls.Add(tbox_num_emple_p_elminar);
            Controls.Add(lbl_num_empleado_eliminar);
            Controls.Add(pb_Eliminar_Empleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "borrar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Empleado";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pb_Eliminar_Empleado;
        private TextBox tbox_num_emple_p_elminar;
        private Label lbl_num_empleado_eliminar;
    }
}