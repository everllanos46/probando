namespace ComercialAG
{
    partial class AdministradorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.rutasTxt = new System.Windows.Forms.Button();
            this.buscarTxt = new System.Windows.Forms.Button();
            this.CuentaTxt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 34);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(788, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Min";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(830, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.CuentaTxt);
            this.panel2.Controls.Add(this.buscarTxt);
            this.panel2.Controls.Add(this.rutasTxt);
            this.panel2.Controls.Add(this.ingresarBtn);
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 52);
            this.panel2.TabIndex = 2;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 85);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(878, 423);
            this.PanelPrincipal.TabIndex = 3;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarBtn.Location = new System.Drawing.Point(112, 7);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(125, 35);
            this.ingresarBtn.TabIndex = 0;
            this.ingresarBtn.Text = "Ingresar Préstamo";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // rutasTxt
            // 
            this.rutasTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rutasTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutasTxt.Location = new System.Drawing.Point(271, 7);
            this.rutasTxt.Name = "rutasTxt";
            this.rutasTxt.Size = new System.Drawing.Size(125, 35);
            this.rutasTxt.TabIndex = 1;
            this.rutasTxt.Text = "Ver rutas";
            this.rutasTxt.UseVisualStyleBackColor = true;
            this.rutasTxt.Click += new System.EventHandler(this.rutasTxt_Click);
            // 
            // buscarTxt
            // 
            this.buscarTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarTxt.Location = new System.Drawing.Point(449, 7);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(125, 35);
            this.buscarTxt.TabIndex = 2;
            this.buscarTxt.Text = "Buscar Préstamos";
            this.buscarTxt.UseVisualStyleBackColor = true;
            this.buscarTxt.Click += new System.EventHandler(this.buscarTxt_Click);
            // 
            // CuentaTxt
            // 
            this.CuentaTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CuentaTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CuentaTxt.Location = new System.Drawing.Point(625, 7);
            this.CuentaTxt.Name = "CuentaTxt";
            this.CuentaTxt.Size = new System.Drawing.Size(125, 35);
            this.CuentaTxt.TabIndex = 3;
            this.CuentaTxt.Text = "Cuentas";
            this.CuentaTxt.UseVisualStyleBackColor = true;
            this.CuentaTxt.Click += new System.EventHandler(this.CuentaTxt_Click);
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(878, 506);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorForm";
            this.Text = "AdministradorForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buscarTxt;
        private System.Windows.Forms.Button rutasTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button CuentaTxt;
    }
}