namespace Checador {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pb_Ingresar = new Button();
            lbl_Usuario = new Label();
            lbl_Contraseña = new Label();
            tbox_Usuario = new TextBox();
            tbox_Contraseña = new TextBox();
            SuspendLayout();
            // 
            // pb_Ingresar
            // 
            pb_Ingresar.BackColor = Color.FromArgb(192, 255, 255);
            pb_Ingresar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pb_Ingresar.Location = new Point(79, 233);
            pb_Ingresar.Name = "pb_Ingresar";
            pb_Ingresar.Size = new Size(164, 44);
            pb_Ingresar.TabIndex = 0;
            pb_Ingresar.Text = "Ingresar";
            pb_Ingresar.UseVisualStyleBackColor = false;
            pb_Ingresar.Click += pb_Ingresar_Click;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Usuario.Location = new Point(36, 67);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(62, 20);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Contraseña
            // 
            lbl_Contraseña.AutoSize = true;
            lbl_Contraseña.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Contraseña.Location = new Point(12, 118);
            lbl_Contraseña.Name = "lbl_Contraseña";
            lbl_Contraseña.Size = new Size(86, 20);
            lbl_Contraseña.TabIndex = 2;
            lbl_Contraseña.Text = "Contraseña:";
            // 
            // tbox_Usuario
            // 
            tbox_Usuario.Location = new Point(104, 64);
            tbox_Usuario.Name = "tbox_Usuario";
            tbox_Usuario.Size = new Size(154, 23);
            tbox_Usuario.TabIndex = 3;
            // 
            // tbox_Contraseña
            // 
            tbox_Contraseña.Location = new Point(104, 115);
            tbox_Contraseña.Name = "tbox_Contraseña";
            tbox_Contraseña.Size = new Size(154, 23);
            tbox_Contraseña.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 318);
            Controls.Add(tbox_Contraseña);
            Controls.Add(tbox_Usuario);
            Controls.Add(lbl_Contraseña);
            Controls.Add(lbl_Usuario);
            Controls.Add(pb_Ingresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pb_Ingresar;
        private Label lbl_Usuario;
        private Label lbl_Contraseña;
        private TextBox tbox_Usuario;
        private TextBox tbox_Contraseña;
    }
}