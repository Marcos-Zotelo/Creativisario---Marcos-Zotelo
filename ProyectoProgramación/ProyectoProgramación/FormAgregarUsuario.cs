using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoProgramación
{
	public partial class FormAgregarUsuario : Form
	{
		ClassConexion miConexion;
		
		public FormAgregarUsuario()
		{
			
			InitializeComponent();
			
		}
		
		void Btn_ingresoClick(object sender, EventArgs e)
		{  
		    string nombreUsuario = txt_user.Text;
		    string qry = "exec sp_AgregarUsuario '"+ nombreUsuario+ "'";		    
		    miConexion.EjecutarSentencia(qry);		  

		    string IdQuery = "exec ObtenerIdUsuario '"+ nombreUsuario+ "'";
		    object idResult = miConexion.ObtenerIdUsuario(IdQuery);
		    string id = idResult.ToString();
		    
		    Formnivel1 nivel1 = new Formnivel1(Convert.ToInt32(id));
		    nivel1.Show();
		    this.Hide();
		}
		
		void Btn_menuClick(object sender, EventArgs e)
		{
			DialogResult resultado = MessageBox.Show("Desea regresar al menu?", "Salir", MessageBoxButtons.YesNo);
						
			if(resultado == DialogResult.Yes)
			{
			    MainForm mainForm = new MainForm();
		    	mainForm.Show();
		    	this.Close();
			}				
		}
		
		void FormUsuarioLoad(object sender, EventArgs e)
		{
		    miConexion = new ClassConexion();
		    miConexion.CrearConexion();
		}
	}
}
