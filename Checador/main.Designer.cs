namespace Checador {
    partial class Checador {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checador));
            lbl_fecha = new Label();
            lbl_hora = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            lbl_info_asis = new Label();
            tbox_NumerodeEmpleado = new TextBox();
            Bt_Registrar_Asistencia = new Button();
            pb_Modo_Admin = new Button();
            SuspendLayout();
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha.Location = new Point(104, 154);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(235, 28);
            lbl_fecha.TabIndex = 0;
            lbl_fecha.Text = "lunes, 1 de enero de 0000";
            // 
            // lbl_hora
            // 
            lbl_hora.AutoSize = true;
            lbl_hora.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_hora.Location = new Point(12, 154);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(86, 28);
            lbl_hora.TabIndex = 1;
            lbl_hora.Text = "00:00:00";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // lbl_info_asis
            // 
            lbl_info_asis.AutoSize = true;
            lbl_info_asis.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info_asis.Location = new Point(12, 40);
            lbl_info_asis.Name = "lbl_info_asis";
            lbl_info_asis.Size = new Size(208, 20);
            lbl_info_asis.TabIndex = 3;
            lbl_info_asis.Text = "Ingrese Número de Empleado";
            // 
            // tbox_NumerodeEmpleado
            // 
            tbox_NumerodeEmpleado.Location = new Point(226, 41);
            tbox_NumerodeEmpleado.Name = "tbox_NumerodeEmpleado";
            tbox_NumerodeEmpleado.Size = new Size(207, 23);
            tbox_NumerodeEmpleado.TabIndex = 4;
            // 
            // Bt_Registrar_Asistencia
            // 
            Bt_Registrar_Asistencia.BackColor = Color.Lime;
            Bt_Registrar_Asistencia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Bt_Registrar_Asistencia.Location = new Point(452, 34);
            Bt_Registrar_Asistencia.Name = "Bt_Registrar_Asistencia";
            Bt_Registrar_Asistencia.Size = new Size(166, 35);
            Bt_Registrar_Asistencia.TabIndex = 5;
            Bt_Registrar_Asistencia.Text = "Registrar Asistencia";
            Bt_Registrar_Asistencia.UseVisualStyleBackColor = false;
            Bt_Registrar_Asistencia.Click += Bt_Registrar_Asistencia_Click;
            // 
            // pb_Modo_Admin
            // 
            pb_Modo_Admin.BackColor = SystemColors.ActiveBorder;
            pb_Modo_Admin.Location = new Point(509, 153);
            pb_Modo_Admin.Name = "pb_Modo_Admin";
            pb_Modo_Admin.Size = new Size(126, 26);
            pb_Modo_Admin.TabIndex = 6;
            pb_Modo_Admin.Text = "Modo Administrador";
            pb_Modo_Admin.UseVisualStyleBackColor = false;
            pb_Modo_Admin.Click += pb_Modo_Admin_Click;
            // 
            // Checador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 191);
            Controls.Add(pb_Modo_Admin);
            Controls.Add(Bt_Registrar_Asistencia);
            Controls.Add(tbox_NumerodeEmpleado);
            Controls.Add(lbl_info_asis);
            Controls.Add(lbl_hora);
            Controls.Add(lbl_fecha);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Checador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checador";
            Load += Checador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_fecha;
        private Label lbl_hora;
        private System.Windows.Forms.Timer horafecha;
        private Label lbl_info_asis;
        private TextBox tbox_NumerodeEmpleado;
        private Button Bt_Registrar_Asistencia;
        private Button pb_Modo_Admin;
    }
}