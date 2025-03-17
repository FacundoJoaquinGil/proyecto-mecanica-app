namespace app_taller_mecanica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panelPresupuesto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPresupuesto.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuesto.Location = new System.Drawing.Point(201, 458);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(111, 43);
            this.btnPresupuesto.TabIndex = 1;
            this.btnPresupuesto.Text = "Crear Un Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(581, 458);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(111, 43);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Regitro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelPresupuesto
            // 
            this.panelPresupuesto.Controls.Add(this.panelRegistro);
            this.panelPresupuesto.Controls.Add(this.label1);
            this.panelPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.panelPresupuesto.Name = "panelPresupuesto";
            this.panelPresupuesto.Size = new System.Drawing.Size(934, 561);
            this.panelPresupuesto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL PRESUPUESTO";
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(934, 561);
            this.panelRegistro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panel REGISTRO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelPresupuesto);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPresupuesto.ResumeLayout(false);
            this.panelPresupuesto.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panelPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label label2;
    }
}

