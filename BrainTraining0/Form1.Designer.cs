namespace BrainTraining0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btStart = new System.Windows.Forms.Button();
            this.numTiempo = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.btInfo = new System.Windows.Forms.Button();
            this.listaNiveles = new System.Windows.Forms.ComboBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(36, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 50);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(258, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 50);
            this.lblTime.TabIndex = 1;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(45, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(50, 50);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "0";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(258, 109);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(50, 50);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "0";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperador
            // 
            this.lblOperador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOperador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(155, 109);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(50, 50);
            this.lblOperador.TabIndex = 4;
            this.lblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(132, 219);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            this.txt1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt1_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(132, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Text = "name";
            this.txtName.Visible = false;
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.RoyalBlue;
            this.gb1.Controls.Add(this.btGuardar);
            this.gb1.Controls.Add(this.lblTime);
            this.gb1.Controls.Add(this.txtName);
            this.gb1.Controls.Add(this.lbl1);
            this.gb1.Controls.Add(this.txt1);
            this.gb1.Controls.Add(this.lbl3);
            this.gb1.Controls.Add(this.lbl5);
            this.gb1.Controls.Add(this.lblOperador);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.ForeColor = System.Drawing.Color.White;
            this.gb1.Location = new System.Drawing.Point(406, 81);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(336, 261);
            this.gb1.TabIndex = 7;
            this.gb1.TabStop = false;
            this.gb1.Text = "Juego";
            this.gb1.Visible = false;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btGuardar.Enabled = false;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(255, 179);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 39);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "Guardar Resultado";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Visible = false;
            this.btGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Location = new System.Drawing.Point(217, 18);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(342, 46);
            this.titulo.TabIndex = 8;
            this.titulo.Text = "BRAIN TRAINING";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb2
            // 
            this.gb2.BackColor = System.Drawing.Color.RoyalBlue;
            this.gb2.Controls.Add(this.btStart);
            this.gb2.Controls.Add(this.numTiempo);
            this.gb2.Controls.Add(this.lblTiempo);
            this.gb2.Controls.Add(this.lblNiveles);
            this.gb2.Controls.Add(this.btInfo);
            this.gb2.Controls.Add(this.listaNiveles);
            this.gb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb2.ForeColor = System.Drawing.Color.White;
            this.gb2.Location = new System.Drawing.Point(12, 81);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(359, 261);
            this.gb2.TabIndex = 9;
            this.gb2.TabStop = false;
            this.gb2.Text = "MENÚ";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btStart.Enabled = false;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(149, 208);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(78, 31);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // numTiempo
            // 
            this.numTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTiempo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTiempo.Location = new System.Drawing.Point(164, 152);
            this.numTiempo.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTiempo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTiempo.Name = "numTiempo";
            this.numTiempo.Size = new System.Drawing.Size(46, 26);
            this.numTiempo.TabIndex = 5;
            this.numTiempo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTiempo.ValueChanged += new System.EventHandler(this.numTiempo_ValueChanged);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(120, 129);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(131, 20);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "Tiempo de Juego";
            // 
            // lblNiveles
            // 
            this.lblNiveles.AutoSize = true;
            this.lblNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveles.Location = new System.Drawing.Point(120, 61);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(134, 20);
            this.lblNiveles.TabIndex = 2;
            this.lblNiveles.Text = "Nivel de Dificultad";
            // 
            // btInfo
            // 
            this.btInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btInfo.Image = global::BrainTraining0.Properties.Resources.iconInfo1;
            this.btInfo.Location = new System.Drawing.Point(307, 10);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(46, 44);
            this.btInfo.TabIndex = 1;
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // listaNiveles
            // 
            this.listaNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaNiveles.FormattingEnabled = true;
            this.listaNiveles.Items.AddRange(new object[] {
            "Necesita mejorar",
            "Casi un hombre",
            "Curtido en mil batallas",
            "Nicola Tesla,¿eres tú?"});
            this.listaNiveles.Location = new System.Drawing.Point(70, 84);
            this.listaNiveles.Name = "listaNiveles";
            this.listaNiveles.Size = new System.Drawing.Size(230, 21);
            this.listaNiveles.TabIndex = 0;
            this.listaNiveles.SelectedIndexChanged += new System.EventHandler(this.listaNiveles_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(754, 354);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.ComboBox listaNiveles;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.NumericUpDown numTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Button btStart;
    }
}

