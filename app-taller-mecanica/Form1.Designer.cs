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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtMano = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblMano = new System.Windows.Forms.Label();
            this.lblCombustible = new System.Windows.Forms.Label();
            this.txtCombustible = new System.Windows.Forms.TextBox();
            this.rtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtAceite = new System.Windows.Forms.TextBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblAceite = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtVahiculo = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnVolverPresupuesto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.btnVolverRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPresupuesto.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresupuesto.Location = new System.Drawing.Point(268, 564);
            this.btnPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(148, 53);
            this.btnPresupuesto.TabIndex = 1;
            this.btnPresupuesto.Text = "Crear Un Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(775, 564);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(148, 53);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Regitro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelPresupuesto
            // 
            this.panelPresupuesto.Controls.Add(this.btnHistorial);
            this.panelPresupuesto.Controls.Add(this.btnNuevo);
            this.panelPresupuesto.Controls.Add(this.btnGuardar);
            this.panelPresupuesto.Controls.Add(this.btnImprimir);
            this.panelPresupuesto.Controls.Add(this.txtTotal);
            this.panelPresupuesto.Controls.Add(this.txtSubtotal);
            this.panelPresupuesto.Controls.Add(this.txtMano);
            this.panelPresupuesto.Controls.Add(this.lblTotal);
            this.panelPresupuesto.Controls.Add(this.lblSubtotal);
            this.panelPresupuesto.Controls.Add(this.lblMano);
            this.panelPresupuesto.Controls.Add(this.lblCombustible);
            this.panelPresupuesto.Controls.Add(this.txtCombustible);
            this.panelPresupuesto.Controls.Add(this.rtDescripcion);
            this.panelPresupuesto.Controls.Add(this.lblDescripcion);
            this.panelPresupuesto.Controls.Add(this.txtPatente);
            this.panelPresupuesto.Controls.Add(this.txtAceite);
            this.panelPresupuesto.Controls.Add(this.lblPatente);
            this.panelPresupuesto.Controls.Add(this.lblAceite);
            this.panelPresupuesto.Controls.Add(this.txtKm);
            this.panelPresupuesto.Controls.Add(this.txtAño);
            this.panelPresupuesto.Controls.Add(this.txtModelo);
            this.panelPresupuesto.Controls.Add(this.txtMarca);
            this.panelPresupuesto.Controls.Add(this.txtVahiculo);
            this.panelPresupuesto.Controls.Add(this.txtTitular);
            this.panelPresupuesto.Controls.Add(this.lblAño);
            this.panelPresupuesto.Controls.Add(this.lblModelo);
            this.panelPresupuesto.Controls.Add(this.lblMarca);
            this.panelPresupuesto.Controls.Add(this.label5);
            this.panelPresupuesto.Controls.Add(this.lblKm);
            this.panelPresupuesto.Controls.Add(this.lblVehiculo);
            this.panelPresupuesto.Controls.Add(this.lblTitular);
            this.panelPresupuesto.Controls.Add(this.lblDatos);
            this.panelPresupuesto.Controls.Add(this.btnVolverPresupuesto);
            this.panelPresupuesto.Controls.Add(this.label1);
            this.panelPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.panelPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.panelPresupuesto.Name = "panelPresupuesto";
            this.panelPresupuesto.Size = new System.Drawing.Size(1245, 690);
            this.panelPresupuesto.TabIndex = 3;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(752, 530);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(143, 27);
            this.txtTotal.TabIndex = 30;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(752, 485);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(143, 27);
            this.txtSubtotal.TabIndex = 29;
            // 
            // txtMano
            // 
            this.txtMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMano.Location = new System.Drawing.Point(752, 440);
            this.txtMano.Name = "txtMano";
            this.txtMano.Size = new System.Drawing.Size(143, 27);
            this.txtMano.TabIndex = 28;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(593, 525);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(593, 484);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(84, 25);
            this.lblSubtotal.TabIndex = 26;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblMano
            // 
            this.lblMano.AutoSize = true;
            this.lblMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMano.Location = new System.Drawing.Point(593, 442);
            this.lblMano.Name = "lblMano";
            this.lblMano.Size = new System.Drawing.Size(133, 25);
            this.lblMano.TabIndex = 25;
            this.lblMano.Text = "Mano de obra";
            // 
            // lblCombustible
            // 
            this.lblCombustible.AutoSize = true;
            this.lblCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustible.Location = new System.Drawing.Point(33, 282);
            this.lblCombustible.Name = "lblCombustible";
            this.lblCombustible.Size = new System.Drawing.Size(121, 25);
            this.lblCombustible.TabIndex = 24;
            this.lblCombustible.Text = "Combustible";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustible.Location = new System.Drawing.Point(228, 283);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(143, 27);
            this.txtCombustible.TabIndex = 23;
            // 
            // rtDescripcion
            // 
            this.rtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescripcion.Location = new System.Drawing.Point(37, 443);
            this.rtDescripcion.Name = "rtDescripcion";
            this.rtDescripcion.Size = new System.Drawing.Size(506, 174);
            this.rtDescripcion.TabIndex = 22;
            this.rtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(33, 403);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcion.TabIndex = 21;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(228, 235);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(143, 27);
            this.txtPatente.TabIndex = 20;
            // 
            // txtAceite
            // 
            this.txtAceite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAceite.Location = new System.Drawing.Point(228, 329);
            this.txtAceite.Name = "txtAceite";
            this.txtAceite.Size = new System.Drawing.Size(143, 27);
            this.txtAceite.TabIndex = 19;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(33, 237);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(79, 25);
            this.lblPatente.TabIndex = 18;
            this.lblPatente.Text = "Patente";
            // 
            // lblAceite
            // 
            this.lblAceite.AutoSize = true;
            this.lblAceite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceite.Location = new System.Drawing.Point(33, 328);
            this.lblAceite.Name = "lblAceite";
            this.lblAceite.Size = new System.Drawing.Size(67, 25);
            this.lblAceite.TabIndex = 17;
            this.lblAceite.Text = "Aceite";
            // 
            // txtKm
            // 
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKm.Location = new System.Drawing.Point(567, 139);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(143, 27);
            this.txtKm.TabIndex = 16;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(567, 187);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(143, 27);
            this.txtAño.TabIndex = 15;
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(567, 275);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(143, 27);
            this.txtModelo.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(567, 229);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(143, 27);
            this.txtMarca.TabIndex = 13;
            // 
            // txtVahiculo
            // 
            this.txtVahiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVahiculo.Location = new System.Drawing.Point(228, 187);
            this.txtVahiculo.Name = "txtVahiculo";
            this.txtVahiculo.Size = new System.Drawing.Size(143, 27);
            this.txtVahiculo.TabIndex = 12;
            // 
            // txtTitular
            // 
            this.txtTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitular.Location = new System.Drawing.Point(228, 136);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(188, 27);
            this.txtTitular.TabIndex = 11;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(461, 186);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(48, 25);
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "Año";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(461, 274);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 25);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(461, 229);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 25);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 7;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(457, 138);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(104, 25);
            this.lblKm.TabIndex = 6;
            this.lblKm.Text = "Kilometros";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(33, 186);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(128, 25);
            this.lblVehiculo.TabIndex = 5;
            this.lblVehiculo.Text = "Tipo vehiculo";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(33, 136);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(174, 25);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular del vehiculo";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(33, 89);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(155, 25);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "Datos del cliente";
            // 
            // btnVolverPresupuesto
            // 
            this.btnVolverPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPresupuesto.Location = new System.Drawing.Point(1051, 582);
            this.btnVolverPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverPresupuesto.Name = "btnVolverPresupuesto";
            this.btnVolverPresupuesto.Size = new System.Drawing.Size(123, 46);
            this.btnVolverPresupuesto.TabIndex = 2;
            this.btnVolverPresupuesto.Text = "Volver";
            this.btnVolverPresupuesto.UseVisualStyleBackColor = true;
            this.btnVolverPresupuesto.Click += new System.EventHandler(this.btnVolverPresupuesto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PANEL PRESUPUESTO";
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.btnVolverRegistro);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1245, 690);
            this.panelRegistro.TabIndex = 1;
            // 
            // btnVolverRegistro
            // 
            this.btnVolverRegistro.Location = new System.Drawing.Point(976, 581);
            this.btnVolverRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverRegistro.Name = "btnVolverRegistro";
            this.btnVolverRegistro.Size = new System.Drawing.Size(100, 28);
            this.btnVolverRegistro.TabIndex = 1;
            this.btnVolverRegistro.Text = "Volver";
            this.btnVolverRegistro.UseVisualStyleBackColor = true;
            this.btnVolverRegistro.Click += new System.EventHandler(this.btnVolverRegistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Panel REGISTRO";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(598, 582);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(123, 46);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(752, 582);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 46);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1051, 89);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(142, 63);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo Presupuesto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Location = new System.Drawing.Point(1051, 504);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(123, 46);
            this.btnHistorial.TabIndex = 34;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1245, 690);
            this.Controls.Add(this.panelPresupuesto);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1261, 728);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qqqq";
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
        private System.Windows.Forms.Button btnVolverRegistro;
        private System.Windows.Forms.Button btnVolverPresupuesto;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtVahiculo;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblAceite;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtAceite;
        private System.Windows.Forms.RichTextBox rtDescripcion;
        private System.Windows.Forms.Label lblCombustible;
        private System.Windows.Forms.TextBox txtCombustible;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtMano;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblMano;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnHistorial;
    }
}

