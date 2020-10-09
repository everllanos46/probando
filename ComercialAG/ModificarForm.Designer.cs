namespace ComercialAG
{
    partial class ModificarForm
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
            this.modificarBtn = new System.Windows.Forms.Button();
            this.tipoBox = new System.Windows.Forms.ComboBox();
            this.rutaBox = new System.Windows.Forms.ComboBox();
            this.montoTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.generoBox = new System.Windows.Forms.ComboBox();
            this.ocupacionTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.cedulaTxt = new System.Windows.Forms.TextBox();
            this.segundoApellidoTxt = new System.Windows.Forms.TextBox();
            this.primerApellidoTxt = new System.Windows.Forms.TextBox();
            this.segundoNombreTxt = new System.Windows.Forms.TextBox();
            this.primerNombreTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 31);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(710, 3);
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
            this.button2.Location = new System.Drawing.Point(752, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarBtn.Location = new System.Drawing.Point(373, 367);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(175, 31);
            this.modificarBtn.TabIndex = 51;
            this.modificarBtn.Text = "Modificar Préstamo";
            this.modificarBtn.UseVisualStyleBackColor = true;
            // 
            // tipoBox
            // 
            this.tipoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBox.FormattingEnabled = true;
            this.tipoBox.Items.AddRange(new object[] {
            "DIARIO",
            "SEMANAL",
            "QUINCENAL",
            "MENSUAL"});
            this.tipoBox.Location = new System.Drawing.Point(139, 335);
            this.tipoBox.Name = "tipoBox";
            this.tipoBox.Size = new System.Drawing.Size(125, 21);
            this.tipoBox.TabIndex = 50;
            // 
            // rutaBox
            // 
            this.rutaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rutaBox.FormattingEnabled = true;
            this.rutaBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.rutaBox.Location = new System.Drawing.Point(641, 54);
            this.rutaBox.Name = "rutaBox";
            this.rutaBox.Size = new System.Drawing.Size(125, 21);
            this.rutaBox.TabIndex = 49;
            // 
            // montoTxt
            // 
            this.montoTxt.Location = new System.Drawing.Point(139, 307);
            this.montoTxt.Name = "montoTxt";
            this.montoTxt.Size = new System.Drawing.Size(125, 20);
            this.montoTxt.TabIndex = 48;
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(139, 281);
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(125, 20);
            this.telefonoTxt.TabIndex = 47;
            // 
            // generoBox
            // 
            this.generoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoBox.FormattingEnabled = true;
            this.generoBox.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.generoBox.Location = new System.Drawing.Point(139, 251);
            this.generoBox.Name = "generoBox";
            this.generoBox.Size = new System.Drawing.Size(125, 21);
            this.generoBox.TabIndex = 46;
            // 
            // ocupacionTxt
            // 
            this.ocupacionTxt.Location = new System.Drawing.Point(139, 221);
            this.ocupacionTxt.Name = "ocupacionTxt";
            this.ocupacionTxt.Size = new System.Drawing.Size(125, 20);
            this.ocupacionTxt.TabIndex = 45;
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(139, 185);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(125, 20);
            this.direccionTxt.TabIndex = 44;
            // 
            // cedulaTxt
            // 
            this.cedulaTxt.Enabled = false;
            this.cedulaTxt.Location = new System.Drawing.Point(139, 156);
            this.cedulaTxt.Name = "cedulaTxt";
            this.cedulaTxt.Size = new System.Drawing.Size(125, 20);
            this.cedulaTxt.TabIndex = 43;
            // 
            // segundoApellidoTxt
            // 
            this.segundoApellidoTxt.Location = new System.Drawing.Point(139, 130);
            this.segundoApellidoTxt.Name = "segundoApellidoTxt";
            this.segundoApellidoTxt.Size = new System.Drawing.Size(125, 20);
            this.segundoApellidoTxt.TabIndex = 42;
            // 
            // primerApellidoTxt
            // 
            this.primerApellidoTxt.Location = new System.Drawing.Point(139, 105);
            this.primerApellidoTxt.Name = "primerApellidoTxt";
            this.primerApellidoTxt.Size = new System.Drawing.Size(125, 20);
            this.primerApellidoTxt.TabIndex = 41;
            // 
            // segundoNombreTxt
            // 
            this.segundoNombreTxt.Location = new System.Drawing.Point(139, 79);
            this.segundoNombreTxt.Name = "segundoNombreTxt";
            this.segundoNombreTxt.Size = new System.Drawing.Size(125, 20);
            this.segundoNombreTxt.TabIndex = 40;
            // 
            // primerNombreTxt
            // 
            this.primerNombreTxt.Location = new System.Drawing.Point(139, 52);
            this.primerNombreTxt.Name = "primerNombreTxt";
            this.primerNombreTxt.Size = new System.Drawing.Size(125, 20);
            this.primerNombreTxt.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(602, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Ruta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tipo Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Monto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Ocupación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Segundo Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Primer Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Segundo Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Primer Nombre:";
            // 
            // ModificarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.tipoBox);
            this.Controls.Add(this.rutaBox);
            this.Controls.Add(this.montoTxt);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.generoBox);
            this.Controls.Add(this.ocupacionTxt);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.cedulaTxt);
            this.Controls.Add(this.segundoApellidoTxt);
            this.Controls.Add(this.primerApellidoTxt);
            this.Controls.Add(this.segundoNombreTxt);
            this.Controls.Add(this.primerNombreTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarForm";
            this.Text = "ModificarForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.ComboBox tipoBox;
        private System.Windows.Forms.ComboBox rutaBox;
        private System.Windows.Forms.TextBox montoTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.ComboBox generoBox;
        private System.Windows.Forms.TextBox ocupacionTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox cedulaTxt;
        private System.Windows.Forms.TextBox segundoApellidoTxt;
        private System.Windows.Forms.TextBox primerApellidoTxt;
        private System.Windows.Forms.TextBox segundoNombreTxt;
        private System.Windows.Forms.TextBox primerNombreTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}