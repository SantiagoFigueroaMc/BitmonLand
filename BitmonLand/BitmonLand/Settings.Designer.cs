namespace BitmonLand
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.checkBox_ver_simulacion = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnas_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.fila_nUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_agua = new System.Windows.Forms.NumericUpDown();
            this.label_agua = new System.Windows.Forms.Label();
            this.numericUpDown_arena = new System.Windows.Forms.NumericUpDown();
            this.label_arena = new System.Windows.Forms.Label();
            this.numericUpDown_volcan = new System.Windows.Forms.NumericUpDown();
            this.label_volcan = new System.Windows.Forms.Label();
            this.numericUpDown_nieve = new System.Windows.Forms.NumericUpDown();
            this.label_nieve = new System.Windows.Forms.Label();
            this.numericUpDown_pasto = new System.Windows.Forms.NumericUpDown();
            this.label_pasto = new System.Windows.Forms.Label();
            this.numericUpDown_bitmons = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown_meses = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_velocidad = new System.Windows.Forms.NumericUpDown();
            this.label_velocidad = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.progressBar_pasto = new System.Windows.Forms.ProgressBar();
            this.progressBar_nieve = new System.Windows.Forms.ProgressBar();
            this.progressBar_volcan = new System.Windows.Forms.ProgressBar();
            this.progressBar_arena = new System.Windows.Forms.ProgressBar();
            this.progressBar_agua = new System.Windows.Forms.ProgressBar();
            this.button_pro_options = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.columnas_nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fila_nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_agua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volcan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nieve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bitmons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_meses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_velocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // button_iniciar
            // 
            this.button_iniciar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_iniciar.Location = new System.Drawing.Point(253, 155);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(126, 23);
            this.button_iniciar.TabIndex = 0;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = true;
            this.button_iniciar.Visible = false;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(253, 129);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(126, 23);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Resetear";
            this.toolTip1.SetToolTip(this.button_reset, "Establecer configuración de fábrica");
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // checkBox_ver_simulacion
            // 
            this.checkBox_ver_simulacion.AutoSize = true;
            this.checkBox_ver_simulacion.Location = new System.Drawing.Point(264, 36);
            this.checkBox_ver_simulacion.Name = "checkBox_ver_simulacion";
            this.checkBox_ver_simulacion.Size = new System.Drawing.Size(94, 17);
            this.checkBox_ver_simulacion.TabIndex = 2;
            this.checkBox_ver_simulacion.Text = "Ver simulación";
            this.toolTip1.SetToolTip(this.checkBox_ver_simulacion, "Mostrar graficamente cada paso de la simulación.");
            this.checkBox_ver_simulacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Columnas";
            // 
            // columnas_nUpDown
            // 
            this.columnas_nUpDown.Location = new System.Drawing.Point(71, 7);
            this.columnas_nUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.columnas_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnas_nUpDown.Name = "columnas_nUpDown";
            this.columnas_nUpDown.Size = new System.Drawing.Size(49, 20);
            this.columnas_nUpDown.TabIndex = 4;
            this.toolTip1.SetToolTip(this.columnas_nUpDown, "Cantidad de columnas");
            this.columnas_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.columnas_nUpDown.ValueChanged += new System.EventHandler(this.columnas_nUpDown_ValueChanged);
            // 
            // fila_nUpDown
            // 
            this.fila_nUpDown.Location = new System.Drawing.Point(71, 33);
            this.fila_nUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.fila_nUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fila_nUpDown.Name = "fila_nUpDown";
            this.fila_nUpDown.Size = new System.Drawing.Size(49, 20);
            this.fila_nUpDown.TabIndex = 6;
            this.toolTip1.SetToolTip(this.fila_nUpDown, "Cantidad de filas");
            this.fila_nUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fila_nUpDown.ValueChanged += new System.EventHandler(this.fila_nUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filas";
            // 
            // numericUpDown_agua
            // 
            this.numericUpDown_agua.DecimalPlaces = 2;
            this.numericUpDown_agua.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_agua.Location = new System.Drawing.Point(71, 59);
            this.numericUpDown_agua.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_agua.Name = "numericUpDown_agua";
            this.numericUpDown_agua.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_agua.TabIndex = 8;
            this.numericUpDown_agua.Visible = false;
            this.numericUpDown_agua.ValueChanged += new System.EventHandler(this.numericUpDown_agua_ValueChanged);
            // 
            // label_agua
            // 
            this.label_agua.AutoSize = true;
            this.label_agua.Location = new System.Drawing.Point(12, 61);
            this.label_agua.Name = "label_agua";
            this.label_agua.Size = new System.Drawing.Size(32, 13);
            this.label_agua.TabIndex = 7;
            this.label_agua.Text = "Agua";
            this.label_agua.Visible = false;
            // 
            // numericUpDown_arena
            // 
            this.numericUpDown_arena.DecimalPlaces = 2;
            this.numericUpDown_arena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_arena.Location = new System.Drawing.Point(71, 163);
            this.numericUpDown_arena.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arena.Name = "numericUpDown_arena";
            this.numericUpDown_arena.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_arena.TabIndex = 10;
            this.numericUpDown_arena.Visible = false;
            this.numericUpDown_arena.ValueChanged += new System.EventHandler(this.numericUpDown_arena_ValueChanged);
            // 
            // label_arena
            // 
            this.label_arena.AutoSize = true;
            this.label_arena.Location = new System.Drawing.Point(12, 165);
            this.label_arena.Name = "label_arena";
            this.label_arena.Size = new System.Drawing.Size(35, 13);
            this.label_arena.TabIndex = 9;
            this.label_arena.Text = "Arena";
            this.label_arena.Visible = false;
            // 
            // numericUpDown_volcan
            // 
            this.numericUpDown_volcan.DecimalPlaces = 2;
            this.numericUpDown_volcan.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_volcan.Location = new System.Drawing.Point(71, 137);
            this.numericUpDown_volcan.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_volcan.Name = "numericUpDown_volcan";
            this.numericUpDown_volcan.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_volcan.TabIndex = 12;
            this.numericUpDown_volcan.Visible = false;
            this.numericUpDown_volcan.ValueChanged += new System.EventHandler(this.numericUpDown_volcan_ValueChanged);
            // 
            // label_volcan
            // 
            this.label_volcan.AutoSize = true;
            this.label_volcan.Location = new System.Drawing.Point(12, 139);
            this.label_volcan.Name = "label_volcan";
            this.label_volcan.Size = new System.Drawing.Size(40, 13);
            this.label_volcan.TabIndex = 11;
            this.label_volcan.Text = "Volcán";
            this.label_volcan.Visible = false;
            // 
            // numericUpDown_nieve
            // 
            this.numericUpDown_nieve.DecimalPlaces = 2;
            this.numericUpDown_nieve.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_nieve.Location = new System.Drawing.Point(71, 111);
            this.numericUpDown_nieve.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_nieve.Name = "numericUpDown_nieve";
            this.numericUpDown_nieve.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_nieve.TabIndex = 14;
            this.numericUpDown_nieve.Visible = false;
            this.numericUpDown_nieve.ValueChanged += new System.EventHandler(this.numericUpDown_nieve_ValueChanged);
            // 
            // label_nieve
            // 
            this.label_nieve.AutoSize = true;
            this.label_nieve.Location = new System.Drawing.Point(12, 113);
            this.label_nieve.Name = "label_nieve";
            this.label_nieve.Size = new System.Drawing.Size(35, 13);
            this.label_nieve.TabIndex = 13;
            this.label_nieve.Text = "Nieve";
            this.label_nieve.Visible = false;
            // 
            // numericUpDown_pasto
            // 
            this.numericUpDown_pasto.DecimalPlaces = 2;
            this.numericUpDown_pasto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_pasto.Location = new System.Drawing.Point(71, 85);
            this.numericUpDown_pasto.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_pasto.Name = "numericUpDown_pasto";
            this.numericUpDown_pasto.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_pasto.TabIndex = 16;
            this.numericUpDown_pasto.Visible = false;
            this.numericUpDown_pasto.ValueChanged += new System.EventHandler(this.numericUpDown_pasto_ValueChanged);
            // 
            // label_pasto
            // 
            this.label_pasto.AutoSize = true;
            this.label_pasto.Location = new System.Drawing.Point(12, 87);
            this.label_pasto.Name = "label_pasto";
            this.label_pasto.Size = new System.Drawing.Size(34, 13);
            this.label_pasto.TabIndex = 15;
            this.label_pasto.Text = "Pasto";
            this.label_pasto.Visible = false;
            // 
            // numericUpDown_bitmons
            // 
            this.numericUpDown_bitmons.Location = new System.Drawing.Point(309, 7);
            this.numericUpDown_bitmons.Name = "numericUpDown_bitmons";
            this.numericUpDown_bitmons.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_bitmons.TabIndex = 18;
            this.toolTip1.SetToolTip(this.numericUpDown_bitmons, "Cantidad de bitmons al inicio del programa.\r\n");
            this.numericUpDown_bitmons.ValueChanged += new System.EventHandler(this.numericUpDown_bitmons_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bitmons";
            this.toolTip1.SetToolTip(this.label8, "Cantidad de bitmons al inicio del programa.");
            // 
            // numericUpDown_meses
            // 
            this.numericUpDown_meses.Location = new System.Drawing.Point(185, 7);
            this.numericUpDown_meses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_meses.Name = "numericUpDown_meses";
            this.numericUpDown_meses.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_meses.TabIndex = 20;
            this.toolTip1.SetToolTip(this.numericUpDown_meses, "Cantidad de meses a simular.");
            this.numericUpDown_meses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_meses.ValueChanged += new System.EventHandler(this.numericUpDown_meses_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Meses";
            this.toolTip1.SetToolTip(this.label9, "Cantidad de meses a simular.");
            // 
            // numericUpDown_velocidad
            // 
            this.numericUpDown_velocidad.DecimalPlaces = 2;
            this.numericUpDown_velocidad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_velocidad.Location = new System.Drawing.Point(185, 33);
            this.numericUpDown_velocidad.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_velocidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_velocidad.Name = "numericUpDown_velocidad";
            this.numericUpDown_velocidad.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown_velocidad.TabIndex = 22;
            this.toolTip1.SetToolTip(this.numericUpDown_velocidad, "Meses por segundo");
            this.numericUpDown_velocidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_velocidad.Visible = false;
            this.numericUpDown_velocidad.ValueChanged += new System.EventHandler(this.numericUpDown_velocidad_ValueChanged);
            // 
            // label_velocidad
            // 
            this.label_velocidad.AutoSize = true;
            this.label_velocidad.Location = new System.Drawing.Point(126, 35);
            this.label_velocidad.Name = "label_velocidad";
            this.label_velocidad.Size = new System.Drawing.Size(54, 13);
            this.label_velocidad.TabIndex = 21;
            this.label_velocidad.Text = "Velocidad";
            this.toolTip1.SetToolTip(this.label_velocidad, "Meses por segundo");
            this.label_velocidad.Visible = false;
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(253, 103);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(126, 23);
            this.button_guardar.TabIndex = 23;
            this.button_guardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.button_guardar, "Guarda la configuración actual, revisando que los valores sean válidos");
            this.button_guardar.UseVisualStyleBackColor = true;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // progressBar_pasto
            // 
            this.progressBar_pasto.Location = new System.Drawing.Point(126, 85);
            this.progressBar_pasto.Name = "progressBar_pasto";
            this.progressBar_pasto.Size = new System.Drawing.Size(100, 20);
            this.progressBar_pasto.TabIndex = 24;
            this.progressBar_pasto.Visible = false;
            // 
            // progressBar_nieve
            // 
            this.progressBar_nieve.Location = new System.Drawing.Point(126, 111);
            this.progressBar_nieve.Name = "progressBar_nieve";
            this.progressBar_nieve.Size = new System.Drawing.Size(100, 20);
            this.progressBar_nieve.TabIndex = 25;
            this.progressBar_nieve.Visible = false;
            // 
            // progressBar_volcan
            // 
            this.progressBar_volcan.Location = new System.Drawing.Point(126, 137);
            this.progressBar_volcan.Name = "progressBar_volcan";
            this.progressBar_volcan.Size = new System.Drawing.Size(100, 20);
            this.progressBar_volcan.TabIndex = 26;
            this.progressBar_volcan.Visible = false;
            // 
            // progressBar_arena
            // 
            this.progressBar_arena.Location = new System.Drawing.Point(126, 163);
            this.progressBar_arena.Name = "progressBar_arena";
            this.progressBar_arena.Size = new System.Drawing.Size(100, 20);
            this.progressBar_arena.TabIndex = 27;
            this.progressBar_arena.Visible = false;
            // 
            // progressBar_agua
            // 
            this.progressBar_agua.Location = new System.Drawing.Point(126, 59);
            this.progressBar_agua.Name = "progressBar_agua";
            this.progressBar_agua.Size = new System.Drawing.Size(100, 20);
            this.progressBar_agua.TabIndex = 28;
            this.progressBar_agua.Visible = false;
            // 
            // button_pro_options
            // 
            this.button_pro_options.Location = new System.Drawing.Point(253, 74);
            this.button_pro_options.Name = "button_pro_options";
            this.button_pro_options.Size = new System.Drawing.Size(126, 23);
            this.button_pro_options.TabIndex = 29;
            this.button_pro_options.Text = "Ver más opciones";
            this.button_pro_options.UseVisualStyleBackColor = true;
            this.button_pro_options.Click += new System.EventHandler(this.button_pro_options_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 191);
            this.Controls.Add(this.button_pro_options);
            this.Controls.Add(this.progressBar_agua);
            this.Controls.Add(this.progressBar_arena);
            this.Controls.Add(this.progressBar_volcan);
            this.Controls.Add(this.progressBar_nieve);
            this.Controls.Add(this.progressBar_pasto);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.numericUpDown_velocidad);
            this.Controls.Add(this.label_velocidad);
            this.Controls.Add(this.numericUpDown_meses);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown_bitmons);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_pasto);
            this.Controls.Add(this.label_pasto);
            this.Controls.Add(this.numericUpDown_nieve);
            this.Controls.Add(this.label_nieve);
            this.Controls.Add(this.numericUpDown_volcan);
            this.Controls.Add(this.label_volcan);
            this.Controls.Add(this.numericUpDown_arena);
            this.Controls.Add(this.label_arena);
            this.Controls.Add(this.numericUpDown_agua);
            this.Controls.Add(this.label_agua);
            this.Controls.Add(this.fila_nUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnas_nUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_ver_simulacion);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_iniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.columnas_nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fila_nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_agua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_volcan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nieve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_bitmons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_meses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_velocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.CheckBox checkBox_ver_simulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown columnas_nUpDown;
        private System.Windows.Forms.NumericUpDown fila_nUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_agua;
        private System.Windows.Forms.Label label_agua;
        private System.Windows.Forms.NumericUpDown numericUpDown_arena;
        private System.Windows.Forms.Label label_arena;
        private System.Windows.Forms.NumericUpDown numericUpDown_volcan;
        private System.Windows.Forms.Label label_volcan;
        private System.Windows.Forms.NumericUpDown numericUpDown_nieve;
        private System.Windows.Forms.Label label_nieve;
        private System.Windows.Forms.NumericUpDown numericUpDown_pasto;
        private System.Windows.Forms.Label label_pasto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDown_bitmons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_meses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_velocidad;
        private System.Windows.Forms.Label label_velocidad;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.ProgressBar progressBar_pasto;
        private System.Windows.Forms.ProgressBar progressBar_nieve;
        private System.Windows.Forms.ProgressBar progressBar_volcan;
        private System.Windows.Forms.ProgressBar progressBar_arena;
        private System.Windows.Forms.ProgressBar progressBar_agua;
        private System.Windows.Forms.Button button_pro_options;
    }
}