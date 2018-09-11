namespace Modificar_Fecha_menu
{
    partial class Frm_Modificar_Fecha_Menu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Fecha_Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.btn_periodo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_tipo_menu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttipo_menu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.grilla_fechas = new System.Windows.Forms.DataGridView();
            this.V = new System.Windows.Forms.DataGridViewImageColumn();
            this.M = new System.Windows.Forms.DataGridViewImageColumn();
            this.Tipo_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes_termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_periodo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fechas)).BeginInit();
            this.SuspendLayout();
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(445, -5);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(59, 59);
            this.Ayuda.TabIndex = 0;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            this.Ayuda.Load += new System.EventHandler(this.ayudaSprNet1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.btn_periodo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtperiodo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btn_tipo_menu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttipo_menu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 82);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(345, 47);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(111, 20);
            this.txtfecha.TabIndex = 219;
            this.txtfecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfecha_KeyPress);
            // 
            // btn_periodo
            // 
            this.btn_periodo.Image = ((System.Drawing.Image)(resources.GetObject("btn_periodo.Image")));
            this.btn_periodo.Location = new System.Drawing.Point(644, 45);
            this.btn_periodo.Name = "btn_periodo";
            this.btn_periodo.Size = new System.Drawing.Size(27, 23);
            this.btn_periodo.TabIndex = 218;
            this.btn_periodo.UseVisualStyleBackColor = true;
            this.btn_periodo.Click += new System.EventHandler(this.btn_periodo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 217;
            this.label15.Text = "Periodo Vigente";
            // 
            // txtperiodo
            // 
            this.txtperiodo.BackColor = System.Drawing.Color.White;
            this.txtperiodo.Location = new System.Drawing.Point(558, 46);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(80, 20);
            this.txtperiodo.TabIndex = 216;
            this.txtperiodo.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txtperiodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtperiodo_KeyPress);
            this.txtperiodo.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(265, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 215;
            this.label14.Text = "Fecha Inicio";
            // 
            // btn_tipo_menu
            // 
            this.btn_tipo_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_menu.Image")));
            this.btn_tipo_menu.Location = new System.Drawing.Point(215, 44);
            this.btn_tipo_menu.Name = "btn_tipo_menu";
            this.btn_tipo_menu.Size = new System.Drawing.Size(27, 23);
            this.btn_tipo_menu.TabIndex = 183;
            this.btn_tipo_menu.UseVisualStyleBackColor = true;
            this.btn_tipo_menu.Click += new System.EventHandler(this.btn_tipo_menu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Menú";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(702, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Configuración de Menú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttipo_menu
            // 
            this.txttipo_menu.BackColor = System.Drawing.Color.White;
            this.txttipo_menu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttipo_menu.Location = new System.Drawing.Point(77, 47);
            this.txttipo_menu.Name = "txttipo_menu";
            this.txttipo_menu.Size = new System.Drawing.Size(132, 20);
            this.txttipo_menu.TabIndex = 3;
            this.txttipo_menu.Enter += new System.EventHandler(this.CambiarColor_TextEnter);
            this.txttipo_menu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_menu_KeyPress);
            this.txttipo_menu.Leave += new System.EventHandler(this.CambiarBlanco_TextLeave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(10, 5);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 212;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(306, 5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 47);
            this.btn_limpiar.TabIndex = 211;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = global::Modificar_Fecha_menu.Properties.Resources.save;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(196, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(104, 47);
            this.btn_guardar.TabIndex = 210;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(9, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(702, 25);
            this.label13.TabIndex = 215;
            this.label13.Text = "Detalle ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grilla_fechas
            // 
            this.grilla_fechas.AllowUserToAddRows = false;
            this.grilla_fechas.AllowUserToDeleteRows = false;
            this.grilla_fechas.AllowUserToResizeColumns = false;
            this.grilla_fechas.AllowUserToResizeRows = false;
            this.grilla_fechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilla_fechas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_fechas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grilla_fechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_fechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.V,
            this.M,
            this.Tipo_menu,
            this.Fecha_inicio,
            this.Mes_termino,
            this.Periodo,
            this.Cod_periodo1,
            this.Cod_menu,
            this.Vigente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grilla_fechas.DefaultCellStyle = dataGridViewCellStyle2;
            this.grilla_fechas.Location = new System.Drawing.Point(9, 168);
            this.grilla_fechas.Name = "grilla_fechas";
            this.grilla_fechas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grilla_fechas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grilla_fechas.RowHeadersVisible = false;
            this.grilla_fechas.Size = new System.Drawing.Size(701, 194);
            this.grilla_fechas.TabIndex = 216;
            this.grilla_fechas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_fechas_CellContentDoubleClick);
            this.grilla_fechas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_fechas_CellPainting);
            // 
            // V
            // 
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            // 
            // M
            // 
            this.M.FillWeight = 131.2489F;
            this.M.HeaderText = "M";
            this.M.Image = global::Modificar_Fecha_menu.Properties.Resources.ver_ficha;
            this.M.MinimumWidth = 8;
            this.M.Name = "M";
            this.M.ReadOnly = true;
            // 
            // Tipo_menu
            // 
            this.Tipo_menu.DataPropertyName = "Tipo_menu";
            this.Tipo_menu.FillWeight = 131.2489F;
            this.Tipo_menu.HeaderText = "Tipo Menú";
            this.Tipo_menu.MinimumWidth = 150;
            this.Tipo_menu.Name = "Tipo_menu";
            this.Tipo_menu.ReadOnly = true;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "Fecha_inicio";
            this.Fecha_inicio.FillWeight = 131.2489F;
            this.Fecha_inicio.HeaderText = "Fecha Inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            // 
            // Mes_termino
            // 
            this.Mes_termino.DataPropertyName = "Mes_termino";
            this.Mes_termino.FillWeight = 131.2489F;
            this.Mes_termino.HeaderText = "Mes Termino";
            this.Mes_termino.Name = "Mes_termino";
            this.Mes_termino.ReadOnly = true;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.FillWeight = 131.2489F;
            this.Periodo.HeaderText = "Periodo Meses";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Cod_periodo1
            // 
            this.Cod_periodo1.DataPropertyName = "Cod_periodo1";
            this.Cod_periodo1.HeaderText = "Cod Periodo";
            this.Cod_periodo1.Name = "Cod_periodo1";
            this.Cod_periodo1.ReadOnly = true;
            this.Cod_periodo1.Visible = false;
            // 
            // Cod_menu
            // 
            this.Cod_menu.DataPropertyName = "Cod_menu";
            this.Cod_menu.HeaderText = "Cod_menu";
            this.Cod_menu.Name = "Cod_menu";
            this.Cod_menu.ReadOnly = true;
            this.Cod_menu.Visible = false;
            // 
            // Vigente
            // 
            this.Vigente.DataPropertyName = "VIGENTE";
            this.Vigente.FillWeight = 40.60914F;
            this.Vigente.HeaderText = "Vigente";
            this.Vigente.Name = "Vigente";
            this.Vigente.ReadOnly = true;
            this.Vigente.Visible = false;
            // 
            // Frm_Modificar_Fecha_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 374);
            this.Controls.Add(this.grilla_fechas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Ayuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Modificar_Fecha_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Fecha Menu";
            this.Load += new System.EventHandler(this.Frm_Modificar_Fecha_Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_fechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.Button btn_periodo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_tipo_menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttipo_menu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView grilla_fechas;
        private System.Windows.Forms.DataGridViewImageColumn V;
        private System.Windows.Forms.DataGridViewImageColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes_termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_periodo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigente;
    }
}

