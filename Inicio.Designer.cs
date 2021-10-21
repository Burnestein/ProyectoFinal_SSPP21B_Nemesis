
namespace ProyectoFinal_SSPP21B_Nemesis
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LblSesionIniciada = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TbxContraseña = new System.Windows.Forms.TextBox();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsslDerechosReservados = new System.Windows.Forms.ToolStripStatusLabel();
            this.LlbCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.BtnIniciarSesion);
            this.panel1.Controls.Add(this.LblSesionIniciada);
            this.panel1.Controls.Add(this.LblContraseña);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.TbxContraseña);
            this.panel1.Controls.Add(this.TbxUsuario);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.LlbCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(261, 233);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(122, 36);
            this.BtnIniciarSesion.TabIndex = 25;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // LblSesionIniciada
            // 
            this.LblSesionIniciada.AutoSize = true;
            this.LblSesionIniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSesionIniciada.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblSesionIniciada.Location = new System.Drawing.Point(471, 208);
            this.LblSesionIniciada.Name = "LblSesionIniciada";
            this.LblSesionIniciada.Size = new System.Drawing.Size(105, 17);
            this.LblSesionIniciada.TabIndex = 24;
            this.LblSesionIniciada.Text = "Sesión activa";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(258, 185);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(81, 17);
            this.LblContraseña.TabIndex = 23;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(258, 130);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 22;
            this.LblUsuario.Text = "Usuario";
            // 
            // TbxContraseña
            // 
            this.TbxContraseña.Location = new System.Drawing.Point(261, 205);
            this.TbxContraseña.Name = "TbxContraseña";
            this.TbxContraseña.ReadOnly = true;
            this.TbxContraseña.Size = new System.Drawing.Size(204, 22);
            this.TbxContraseña.TabIndex = 21;
            this.TbxContraseña.Text = "************";
            this.TbxContraseña.UseSystemPasswordChar = true;
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Location = new System.Drawing.Point(261, 150);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.ReadOnly = true;
            this.TbxUsuario.Size = new System.Drawing.Size(204, 22);
            this.TbxUsuario.TabIndex = 20;
            this.TbxUsuario.Text = "IsaacSlovensko";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslDerechosReservados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsslDerechosReservados
            // 
            this.TsslDerechosReservados.Name = "TsslDerechosReservados";
            this.TsslDerechosReservados.Size = new System.Drawing.Size(496, 20);
            this.TsslDerechosReservados.Text = "Copyright © 2021 Todos los Derechos Reservados - Slovensko Labs Corp. ";
            // 
            // LlbCerrarSesion
            // 
            this.LlbCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LlbCerrarSesion.AutoSize = true;
            this.LlbCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.LlbCerrarSesion.Location = new System.Drawing.Point(693, 398);
            this.LlbCerrarSesion.Name = "LlbCerrarSesion";
            this.LlbCerrarSesion.Size = new System.Drawing.Size(95, 17);
            this.LlbCerrarSesion.TabIndex = 14;
            this.LlbCerrarSesion.TabStop = true;
            this.LlbCerrarSesion.Text = "Cerrar Sesión";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Recursos - Hospital Chárbel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TsslDerechosReservados;
        private System.Windows.Forms.LinkLabel LlbCerrarSesion;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Label LblSesionIniciada;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TbxContraseña;
        private System.Windows.Forms.TextBox TbxUsuario;
    }
}

