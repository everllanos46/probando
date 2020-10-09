namespace Interfaz
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsuarioTxt = new System.Windows.Forms.TextBox();
            this.Contrasenalbl = new System.Windows.Forms.Label();
            this.ContrasenaTxt = new System.Windows.Forms.TextBox();
            this.EntrarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.Location = new System.Drawing.Point(49, 71);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(240, 20);
            this.UsuarioTxt.TabIndex = 1;
            // 
            // Contrasenalbl
            // 
            this.Contrasenalbl.AutoSize = true;
            this.Contrasenalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenalbl.Location = new System.Drawing.Point(118, 131);
            this.Contrasenalbl.Name = "Contrasenalbl";
            this.Contrasenalbl.Size = new System.Drawing.Size(92, 20);
            this.Contrasenalbl.TabIndex = 2;
            this.Contrasenalbl.Text = "Contraseña";
            // 
            // ContrasenaTxt
            // 
            this.ContrasenaTxt.Location = new System.Drawing.Point(50, 173);
            this.ContrasenaTxt.Name = "ContrasenaTxt";
            this.ContrasenaTxt.Size = new System.Drawing.Size(238, 20);
            this.ContrasenaTxt.TabIndex = 3;
            // 
            // EntrarBtn
            // 
            this.EntrarBtn.Location = new System.Drawing.Point(113, 234);
            this.EntrarBtn.Name = "EntrarBtn";
            this.EntrarBtn.Size = new System.Drawing.Size(113, 25);
            this.EntrarBtn.TabIndex = 4;
            this.EntrarBtn.Text = "Entrar";
            this.EntrarBtn.UseVisualStyleBackColor = true;
            this.EntrarBtn.Click += new System.EventHandler(this.EntrarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 305);
            this.Controls.Add(this.EntrarBtn);
            this.Controls.Add(this.ContrasenaTxt);
            this.Controls.Add(this.Contrasenalbl);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTxt;
        private System.Windows.Forms.Label Contrasenalbl;
        private System.Windows.Forms.TextBox ContrasenaTxt;
        private System.Windows.Forms.Button EntrarBtn;
    }
}

