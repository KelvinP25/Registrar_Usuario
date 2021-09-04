
namespace RegistrarUsuarioFormsApp
{
    partial class RegistrarUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarUsuario));
            this.idLabel = new System.Windows.Forms.Label();
            this.claveLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.aliasLabel = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.aliastxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.clavetxt = new System.Windows.Forms.TextBox();
            this.conClaveTxt = new System.Windows.Forms.TextBox();
            this.conClaveLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tarifaTxt = new System.Windows.Forms.TextBox();
            this.nuevoBt = new System.Windows.Forms.Button();
            this.guardarBt = new System.Windows.Forms.Button();
            this.Bt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nivelBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(30, 98);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Location = new System.Drawing.Point(30, 256);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(45, 20);
            this.claveLabel.TabIndex = 1;
            this.claveLabel.Text = "Clave";
            this.claveLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(30, 206);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(70, 20);
            this.nomLabel.TabIndex = 2;
            this.nomLabel.Text = "Nombres";
            this.nomLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // aliasLabel
            // 
            this.aliasLabel.AutoSize = true;
            this.aliasLabel.Location = new System.Drawing.Point(30, 152);
            this.aliasLabel.Name = "aliasLabel";
            this.aliasLabel.Size = new System.Drawing.Size(41, 20);
            this.aliasLabel.TabIndex = 3;
            this.aliasLabel.Text = "Alias";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(107, 95);
            this.idtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(125, 27);
            this.idtxt.TabIndex = 4;
            // 
            // buscar
            // 
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar.Location = new System.Drawing.Point(248, 89);
            this.buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(39, 36);
            this.buscar.TabIndex = 5;
            this.buscar.Text = " ";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // aliastxt
            // 
            this.aliastxt.Location = new System.Drawing.Point(107, 145);
            this.aliastxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aliastxt.Name = "aliastxt";
            this.aliastxt.Size = new System.Drawing.Size(195, 27);
            this.aliastxt.TabIndex = 6;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(107, 204);
            this.nombretxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(302, 27);
            this.nombretxt.TabIndex = 7;
            // 
            // clavetxt
            // 
            this.clavetxt.Location = new System.Drawing.Point(107, 254);
            this.clavetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clavetxt.Name = "clavetxt";
            this.clavetxt.Size = new System.Drawing.Size(125, 27);
            this.clavetxt.TabIndex = 8;
            // 
            // conClaveTxt
            // 
            this.conClaveTxt.Location = new System.Drawing.Point(369, 254);
            this.conClaveTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.conClaveTxt.Name = "conClaveTxt";
            this.conClaveTxt.Size = new System.Drawing.Size(125, 27);
            this.conClaveTxt.TabIndex = 9;
            this.conClaveTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // conClaveLabel
            // 
            this.conClaveLabel.AutoSize = true;
            this.conClaveLabel.Location = new System.Drawing.Point(248, 256);
            this.conClaveLabel.Name = "conClaveLabel";
            this.conClaveLabel.Size = new System.Drawing.Size(115, 20);
            this.conClaveLabel.TabIndex = 10;
            this.conClaveLabel.Text = "Confirmar Clave";
            this.conClaveLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Costo x Hora";
            // 
            // tarifaTxt
            // 
            this.tarifaTxt.Location = new System.Drawing.Point(623, 254);
            this.tarifaTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tarifaTxt.Name = "tarifaTxt";
            this.tarifaTxt.Size = new System.Drawing.Size(125, 27);
            this.tarifaTxt.TabIndex = 12;
            // 
            // nuevoBt
            // 
            this.nuevoBt.Image = ((System.Drawing.Image)(resources.GetObject("nuevoBt.Image")));
            this.nuevoBt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevoBt.Location = new System.Drawing.Point(193, 344);
            this.nuevoBt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuevoBt.Name = "nuevoBt";
            this.nuevoBt.Size = new System.Drawing.Size(94, 59);
            this.nuevoBt.TabIndex = 13;
            this.nuevoBt.Text = "Nuevo";
            this.nuevoBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoBt.UseVisualStyleBackColor = true;
            // 
            // guardarBt
            // 
            this.guardarBt.Image = ((System.Drawing.Image)(resources.GetObject("guardarBt.Image")));
            this.guardarBt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarBt.Location = new System.Drawing.Point(336, 344);
            this.guardarBt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarBt.Name = "guardarBt";
            this.guardarBt.Size = new System.Drawing.Size(94, 59);
            this.guardarBt.TabIndex = 14;
            this.guardarBt.Text = "Guardar";
            this.guardarBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarBt.UseVisualStyleBackColor = true;
            // 
            // Bt
            // 
            this.Bt.Image = ((System.Drawing.Image)(resources.GetObject("Bt.Image")));
            this.Bt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bt.Location = new System.Drawing.Point(478, 344);
            this.Bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(94, 59);
            this.Bt.TabIndex = 15;
            this.Bt.Text = "Eliminar";
            this.Bt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Bt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(478, 204);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(270, 27);
            this.emailTxt.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nivel";
            // 
            // nivelBox
            // 
            this.nivelBox.FormattingEnabled = true;
            this.nivelBox.Items.AddRange(new object[] {
            "Administrador",
            "Empleado",
            "Gerente "});
            this.nivelBox.Location = new System.Drawing.Point(623, 145);
            this.nivelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nivelBox.Name = "nivelBox";
            this.nivelBox.Size = new System.Drawing.Size(125, 28);
            this.nivelBox.TabIndex = 19;
            this.nivelBox.Text = "Categoria";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(675, 94);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nivelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bt);
            this.Controls.Add(this.guardarBt);
            this.Controls.Add(this.nuevoBt);
            this.Controls.Add(this.tarifaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conClaveLabel);
            this.Controls.Add(this.conClaveTxt);
            this.Controls.Add(this.clavetxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.aliastxt);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.aliasLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.idLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarUsuario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label aliasLabel;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox aliastxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox clavetxt;
        private System.Windows.Forms.TextBox conClaveTxt;
        private System.Windows.Forms.Label conClaveLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tarifaTxt;
        private System.Windows.Forms.Button nuevoBt;
        private System.Windows.Forms.Button guardarBt;
        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nivelBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

