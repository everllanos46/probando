namespace Interfaz
{
    partial class FormPrincipal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.PagosBtn = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.AgregarClienteBtn = new System.Windows.Forms.Button();
            this.ListaClienteBtn = new System.Windows.Forms.Button();
            this.PanelBtns = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.PanelBtns);
            this.panel1.Controls.Add(this.TotalBtn);
            this.panel1.Controls.Add(this.PagosBtn);
            this.panel1.Controls.Add(this.ClientesBtn);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 492);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(135, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 492);
            this.panel2.TabIndex = 1;
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Location = new System.Drawing.Point(2, 70);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(130, 23);
            this.ClientesBtn.TabIndex = 0;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = true;
            this.ClientesBtn.Click += new System.EventHandler(this.ClientesBtn_Click);
            // 
            // PagosBtn
            // 
            this.PagosBtn.Location = new System.Drawing.Point(3, 99);
            this.PagosBtn.Name = "PagosBtn";
            this.PagosBtn.Size = new System.Drawing.Size(127, 24);
            this.PagosBtn.TabIndex = 1;
            this.PagosBtn.Text = "Pagos";
            this.PagosBtn.UseVisualStyleBackColor = true;
            // 
            // TotalBtn
            // 
            this.TotalBtn.Location = new System.Drawing.Point(5, 129);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(126, 25);
            this.TotalBtn.TabIndex = 2;
            this.TotalBtn.Text = "Total";
            this.TotalBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarClienteBtn
            // 
            this.AgregarClienteBtn.Location = new System.Drawing.Point(1, 2);
            this.AgregarClienteBtn.Name = "AgregarClienteBtn";
            this.AgregarClienteBtn.Size = new System.Drawing.Size(120, 23);
            this.AgregarClienteBtn.TabIndex = 4;
            this.AgregarClienteBtn.Text = "Agregar";
            this.AgregarClienteBtn.UseVisualStyleBackColor = true;
            // 
            // ListaClienteBtn
            // 
            this.ListaClienteBtn.Location = new System.Drawing.Point(2, 29);
            this.ListaClienteBtn.Name = "ListaClienteBtn";
            this.ListaClienteBtn.Size = new System.Drawing.Size(117, 24);
            this.ListaClienteBtn.TabIndex = 5;
            this.ListaClienteBtn.Text = "Lista";
            this.ListaClienteBtn.UseVisualStyleBackColor = true;
            // 
            // PanelBtns
            // 
            this.PanelBtns.BackColor = System.Drawing.SystemColors.Control;
            this.PanelBtns.Controls.Add(this.AgregarClienteBtn);
            this.PanelBtns.Controls.Add(this.ListaClienteBtn);
            this.PanelBtns.Location = new System.Drawing.Point(8, 265);
            this.PanelBtns.Name = "PanelBtns";
            this.PanelBtns.Size = new System.Drawing.Size(123, 57);
            this.PanelBtns.TabIndex = 6;
            this.PanelBtns.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 492);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.panel1.ResumeLayout(false);
            this.PanelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelBtns;
        private System.Windows.Forms.Button AgregarClienteBtn;
        private System.Windows.Forms.Button ListaClienteBtn;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Button PagosBtn;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Panel panel2;
    }
}