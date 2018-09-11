using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Modificar_Fecha_menu
{
    public partial class Frm_Modificar_Fecha_Menu : Form
    {

        #region Variables

        #region Variables Staticas

        static int cod_periodo = 0;
        static int cod_tipo_menu = 0;
        static string vigencia = "";
        #endregion

        #region Datatables

        DataTable dt_fechas = new DataTable();
        DataTable dt_periodo = new DataTable();
        DataTable dt_tipo_menu = new DataTable();

        #endregion

        #region Datos Conexion

        ConectarFalp CnnFalp;
        Configuration Config;
        string User = string.Empty;
        string[] Conexion = { "", "", "" };
        string PCK = "PCK_NUT001I";
        string PCK1 = "PCK_NUT001M";

        #endregion

        #endregion

        public Frm_Modificar_Fecha_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Fecha_Menu_Load(object sender, EventArgs e)
        {
            conectar();
            Cargar_grilla_fechas();
            bloquear();
        }

        private void ayudaSprNet1_Load(object sender, EventArgs e)
        {

        }


        #region Cargar


        #region Cargar Conexion

        void conectar()
        {

            if (!(CnnFalp != null))
            {

                ExeConfigurationFileMap FileMap = new ExeConfigurationFileMap();
                FileMap.ExeConfigFilename = Application.StartupPath + @"\..\WF.config";
                Config = ConfigurationManager.OpenMappedExeConfiguration(FileMap, ConfigurationUserLevel.None);

                CnnFalp = new ConectarFalp(Config.AppSettings.Settings["dbServer"].Value,//ConfigurationManager.AppSettings["dbServer"],
                                           Config.AppSettings.Settings["dbUser"].Value,//ConfigurationManager.AppSettings["dbUser"],
                                           Config.AppSettings.Settings["dbPass"].Value,//ConfigurationManager.AppSettings["dbPass"],
                                           ConectarFalp.TipoBase.Oracle);

                if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir(); // abre la conexion

                Conexion[0] = Config.AppSettings.Settings["dbServer"].Value;
                Conexion[2] = Config.AppSettings.Settings["dbUser"].Value;
                Conexion[1] = Config.AppSettings.Settings["dbPass"].Value;
            }



            // this.Text = this.Text + " [Versión: " + Application.ProductVersion + "] [Conectado: " + Conexion[0] + "]";
            //User = ValidaMenu.LeeUsuarioMenu();
            User = "SICI";
            LblUsuario.Text = "Usuario: " + User;
            //LblUsuario.Text = "Usuario: " + User;
        }

        #endregion

        #region Cargar Grilla

        #region Listar Grilla

        void Cargar_grilla_fechas()
        {


            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();
            dt_fechas.Clear();
            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK1 + ".P_CARGAR_CONFIG_FECHAS");

            dt_fechas.Load(CnnFalp.ExecuteReader());

            if (dt_fechas.Rows.Count > 0)
            {
                grilla_fechas.AutoGenerateColumns = false;
                grilla_fechas.DataSource = dt_fechas;
                ocultar_grilla();
                agregarimagen();

            }

            CnnFalp.Cerrar();
            //ocultar_grilla_menu();
        }

        #endregion

        #region Agregar Imagen

        void agregarimagen()
        {
            foreach (DataGridViewRow row in grilla_fechas.Rows)
            {

                string ve = Convert.ToString(row.Cells["Vigente"].Value);
                DataGridViewImageCell Imagen = row.Cells["V"] as DataGridViewImageCell;

                if (ve == "S")
                {
                    Imagen.Value = (System.Drawing.Image)Modificar_Fecha_menu.Properties.Resources.Check;
                }
                else
                {
                    Imagen.Value = (System.Drawing.Image)Modificar_Fecha_menu.Properties.Resources.Delete;

                }

            }

        }

        #endregion

        #region Ocultar Columnas

        void ocultar_grilla()
        {
            grilla_fechas.AutoResizeColumns();
            grilla_fechas.Columns["Cod_periodo1"].Visible = false;

            //grilla_menu.Columns["ELIMINAR"].Visible = false;
        }

        #endregion

        #region Ordenar Columnas

        #endregion

        #region Pintar Grilla

        private void grilla_fechas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                e.PaintBackground(e.ClipBounds, false);
                Font drawFont = new Font("Trebuchet MS", 8, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;
                StrFormat.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawImage(Properties.Resources.HeaderGV, e.CellBounds);
                e.Graphics.DrawString(grilla_fechas.Columns[e.ColumnIndex].HeaderText, drawFont, drawBrush, e.CellBounds, StrFormat);

                e.Handled = true;
                drawBrush.Dispose();
            }
        }

        #endregion

        #region Pintar Extraer grilla

        private void grilla_fechas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtperiodo.Enabled = true;
                btn_periodo.Enabled = true;
                txtfecha.Enabled = true;
                btn_guardar.Enabled = true;

                if (e.ColumnIndex == 0)
                {
                    DialogResult opc = MessageBox.Show("Estimado usuario, esta seguro Cambiar la vigencia de la Configuración seleccionado?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (opc == DialogResult.Yes)
                    {
                       
                        cod_tipo_menu = Convert.ToInt32(grilla_fechas.Rows[e.RowIndex].Cells["Cod_menu"].Value);
                 
                        txttipo_menu.Text = grilla_fechas.Rows[e.RowIndex].Cells["Tipo_menu"].Value.ToString();
                        txtfecha.Text = grilla_fechas.Rows[e.RowIndex].Cells["Fecha_inicio"].Value.ToString();
                        cod_periodo = Convert.ToInt32(grilla_fechas.Rows[e.RowIndex].Cells["Cod_periodo1"].Value);
                        txtperiodo.Text = grilla_fechas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString();
                        vigencia = grilla_fechas.Rows[e.RowIndex].Cells["Vigente"].Value.ToString();

                        foreach (DataRow fila in dt_fechas.Select(" Cod_Menu= " + cod_tipo_menu))
                        {

                            string v = fila["VIGENTE"].ToString();
                            if (v == "S")
                            {

                                fila["VIGENTE"] = "N";
                                vigencia = "N";
                            }
                            else
                            {

                                fila["VIGENTE"] = "S";
                                vigencia = "S";
                            }
                            dt_fechas.AcceptChanges();
                            agregarimagen();
                        

                        }




                    }


                    //   eliminar_alimnetos_menu(cod_distribucion, cod_alimento);
                    //  grilla_menu.DataSource = new DataView(dt_menu, "VIGENCIA ='S'", "", DataViewRowState.CurrentRows);
                }

                else
                {
                    if (e.ColumnIndex == 1)
                    {


                        DialogResult opc = MessageBox.Show("Estimado usuario, Desea modificar la configuración ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (opc == DialogResult.Yes)
                        {
                        

                            cod_tipo_menu = Convert.ToInt32(grilla_fechas.Rows[e.RowIndex].Cells["Cod_menu"].Value);
                            txttipo_menu.Text = grilla_fechas.Rows[e.RowIndex].Cells["Tipo_menu"].Value.ToString();
                            txtfecha.Text = grilla_fechas.Rows[e.RowIndex].Cells["Fecha_inicio"].Value.ToString();
                            cod_periodo = Convert.ToInt32(grilla_fechas.Rows[e.RowIndex].Cells["Cod_periodo1"].Value);
                            txtperiodo.Text = grilla_fechas.Rows[e.RowIndex].Cells["Periodo"].Value.ToString();
                            vigencia = grilla_fechas.Rows[e.RowIndex].Cells["Vigente"].Value.ToString();
                        }

                      
                    }

                }
            }
        }


        #endregion

        #endregion


        #endregion

        #region Botones


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Validar_Campos())
            {
                DialogResult resp = MessageBox.Show("Estimado Usuario, Esta seguro Cambiar la Configuración del Tipo Menú ?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    Guardar_Menu();
                    limpiar();
                    Cargar_grilla_fechas();
                    bloquear();

                }
                else
                {

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            bloquear();
        }

        private void btn_tipo_menu_Click(object sender, EventArgs e)
        {
            txttipo_menu.Text = "";
            Cargar_tipo_menu();
            if (cod_tipo_menu == 0)
            {
                txtperiodo.Enabled = false;
                txttipo_menu.Focus();
                Cargar_tipo_menu();

            }
            else
            {
                txtperiodo.Enabled = true;
                txtfecha.Focus();
            }
        }

        private void btn_periodo_Click(object sender, EventArgs e)
        {
            txtperiodo.Text = "";
            Cargar_periodo();
            if (cod_periodo == 0)
            {
                btn_guardar.Enabled = false;
                txtperiodo.Focus();
                Cargar_periodo();

            }
            else
            {
                btn_guardar.Enabled = true;
                btn_guardar.Focus();
            }
        }

        #endregion

        #region Metodos


        #region Limpiar
        protected void limpiar()
        {
            txtfecha.Text = "";
            txttipo_menu.Text = "";
            txtperiodo.Text = "";
            cod_periodo = 0;
            cod_tipo_menu = 0;
            Cargar_grilla_fechas();
        }

        #endregion

        #region Cargar tipo menu

        protected void Cargar_tipo_menu()
        {
            Cargar_datos_tipo_menu(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_tipo_menu = Convert.ToInt32(Ayuda.Fields(0));
                txttipo_menu.Text = Ayuda.Fields(1);
            }
            else
            {
                if(cod_tipo_menu==0)
                {
                    txttipo_menu.Text = "";
                }
            }


        }

        void Cargar_datos_tipo_menu(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Tipo de Menú";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_MENU";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txttipo_menu.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }

        #endregion

        #region Cargar periodo vigente

        protected void Cargar_periodo()
        {
            Cargar_datos_periodo(ref Ayuda);

            if (!Ayuda.EOF())
            {
                cod_periodo = Convert.ToInt32(Ayuda.Fields(0));
                txtperiodo.Text = Ayuda.Fields(1);
            }
            else
            {
                if (cod_periodo == 0)
                {
                    txtperiodo.Text = "";
                }
            }


        }

        void Cargar_datos_periodo(ref AyudaSpreadNet.AyudaSprNet Ayuda)
        {
            string[] NomCol = { "Código", "Descripción" };
            int[] AnchoCol = { 80, 350 };
            Ayuda.Nombre_BD_Datos = Conexion[0];
            Ayuda.Pass = Conexion[1];
            Ayuda.User = Conexion[2];
            Ayuda.TipoBase = 1;
            Ayuda.NombreColumnas = NomCol;
            Ayuda.AnchoColumnas = AnchoCol;
            Ayuda.TituloConsulta = "Ingresar Periodo";
            Ayuda.Package = PCK;
            Ayuda.Procedimiento = "P_CARGAR_TIPO_PERIODO";
            Ayuda.Generar_ParametroBD("PIN_DESCRIPCION", txtperiodo.Text.ToUpper(), DbType.String, ParameterDirection.Input);
            Ayuda.EjecutarSql();

        }

        #endregion

        #region Guardar

        protected void Guardar_Menu()
        {

            if (CnnFalp.Estado == ConnectionState.Closed) CnnFalp.Abrir();

            CnnFalp.CrearCommand(CommandType.StoredProcedure, PCK1 + ".P_MODIFICAR_CONFIG_FECHA");

            CnnFalp.ParametroBD("PIN_TIPO_MENU", Convert.ToInt32(cod_tipo_menu), DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_FECHA_INICIO", txtfecha.Text, DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_PERIODO", Convert.ToInt32(cod_periodo), DbType.Int64, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_USUARIO", User.ToUpper().Trim(), DbType.String, ParameterDirection.Input);
            CnnFalp.ParametroBD("PIN_VIGENCIA", vigencia.ToUpper().Trim(), DbType.String, ParameterDirection.Input);

            int registro = CnnFalp.ExecuteNonQuery();


            if (registro >= -1)
            {
                MessageBox.Show("Estimado usuario, Sea  Modificado correctamente la información.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_grilla_fechas();
                limpiar();

            }
            else
            {
            }

        }

        #endregion


        protected void bloquear()
        {
            txttipo_menu.Enabled = false;
            txtfecha.Enabled = false;
            txtperiodo.Enabled = false;
            btn_periodo.Enabled = false;
            btn_tipo_menu.Enabled = false;
            btn_guardar.Enabled = false;
        }

        #endregion



        #region Validaciones


        protected Boolean Validar_Campos()
        {
            Boolean var = false;

            if (txttipo_menu.Text == "" && cod_tipo_menu == 0)
            {
                MessageBox.Show("Estimado usuario, El Campo Tipo Menú se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttipo_menu.Focus();
            }
            else
            {
                if (txtperiodo.Text == "" && cod_periodo == 0)
                {
                    MessageBox.Show("Estimado usuario, El Campo Periodo se encuentra vacio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtperiodo.Focus();
                }
                else
                {
                  
                       var = true;
  
                }
            }

            return var;
        }



        private void txttipo_menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;

                return;
            }
            if (e.KeyChar == (char)13)
            {
                Cargar_tipo_menu();
                if (cod_tipo_menu == 0)
                {
                    txtperiodo.Enabled = false;
                    txttipo_menu.Focus();
                    Cargar_tipo_menu();

                }
                else
                {
                    txtperiodo.Enabled = true;
                    txtfecha.Focus();
                }
           
            }
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtperiodo.Focus();
            }
        }

        private void txtperiodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)13)
            {
                Cargar_periodo();
                if (cod_periodo == 0)
                {
                    btn_guardar.Enabled = false;
                    txtperiodo.Focus();
                    Cargar_periodo();

                }
                else
                {
                    btn_guardar.Enabled = true;
                    btn_guardar.Focus();
                }
            }
           
        }


        private void CambiarBlanco_TextLeave(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.White;

        }

        private void CambiarColor_TextEnter(object sender, EventArgs e)
        {
            TextBox GB = (TextBox)sender;
            GB.BackColor = Color.FromArgb(255, 224, 192);
        }
        #endregion

    

       

     
      


      
    }
}
