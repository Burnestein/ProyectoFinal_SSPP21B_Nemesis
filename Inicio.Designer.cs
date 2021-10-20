
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
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxContraseña = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblSesionIniciada = new System.Windows.Forms.Label();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.LlbCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsslDerechosReservados = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Location = new System.Drawing.Point(286, 169);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.ReadOnly = true;
            this.TbxUsuario.Size = new System.Drawing.Size(204, 22);
            this.TbxUsuario.TabIndex = 0;
            this.TbxUsuario.Text = "IsaacSlovensko";
            // 
            // TbxContraseña
            // 
            this.TbxContraseña.Location = new System.Drawing.Point(286, 224);
            this.TbxContraseña.Name = "TbxContraseña";
            this.TbxContraseña.ReadOnly = true;
            this.TbxContraseña.Size = new System.Drawing.Size(204, 22);
            this.TbxContraseña.TabIndex = 1;
            this.TbxContraseña.Text = "************";
            this.TbxContraseña.UseSystemPasswordChar = true;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(283, 149);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(283, 204);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(81, 17);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblSesionIniciada
            // 
            this.LblSesionIniciada.AutoSize = true;
            this.LblSesionIniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSesionIniciada.ForeColor = System.Drawing.Color.YellowGreen;
            this.LblSesionIniciada.Location = new System.Drawing.Point(496, 227);
            this.LblSesionIniciada.Name = "LblSesionIniciada";
            this.LblSesionIniciada.Size = new System.Drawing.Size(105, 17);
            this.LblSesionIniciada.TabIndex = 4;
            this.LblSesionIniciada.Text = "Sesión activa";
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(286, 252);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(122, 36);
            this.BtnIniciarSesion.TabIndex = 5;
            this.BtnIniciarSesion.Text = "Iniciar Sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // LlbCerrarSesion
            // 
            this.LlbCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LlbCerrarSesion.AutoSize = true;
            this.LlbCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.LlbCerrarSesion.Location = new System.Drawing.Point(693, 392);
            this.LlbCerrarSesion.Name = "LlbCerrarSesion";
            this.LlbCerrarSesion.Size = new System.Drawing.Size(95, 17);
            this.LlbCerrarSesion.TabIndex = 6;
            this.LlbCerrarSesion.TabStop = true;
            this.LlbCerrarSesion.Text = "Cerrar Sesión";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslDerechosReservados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsslDerechosReservados
            // 
            this.TsslDerechosReservados.Name = "TsslDerechosReservados";
            this.TsslDerechosReservados.Size = new System.Drawing.Size(496, 20);
            this.TsslDerechosReservados.Text = "Copyright © 2021 Todos los Derechos Reservados - Slovensko Labs Corp. ";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LlbCerrarSesion);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.LblSesionIniciada);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TbxContraseña);
            this.Controls.Add(this.TbxUsuario);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital San Chárbel";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxContraseña;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblSesionIniciada;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.LinkLabel LlbCerrarSesion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TsslDerechosReservados;
    }
}

