using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoProgramación
{
	public partial class FormCargarUsuario : Form
	{
		ClassConexion miConexion;

		public FormCargarUsuario()
		{

			InitializeComponent();	
	
		}
		
		void Btn_ingresoClick(object sender, EventArgs e)
		{
		    string nombreUsuario = txt_user.Text;
		    
		    if (miConexion.CrearConexion())
		    {
		        if (miConexion.ValidarUsuario(nombreUsuario))
		        {
		            int nivel = miConexion.ObtenerNivelUsuario(nombreUsuario);
		            string IdQuery = "exec ObtenerIdUsuario '"+ nombreUsuario+ "'";
		    		object idResult = miConexion.ObtenerIdUsuario(IdQuery);
		    		string id = idResult.ToString();
		            if (nivel != 0)
		            {
		            	switch (nivel)
	           {
	               case 1:
	                   Formnivel1 nivel1 = new Formnivel1(Convert.ToInt32(id));
	                   nivel1.Show();
	                   this.Hide();
	                   break;
	               case 2:
	                   Formnivel2 nivel2 = new Formnivel2(Convert.ToInt32(id));
	                   nivel2.Show();
	                   this.Hide();
	                   break;
	               case 3:
	                   Formnivel3 nivel3 = new Formnivel3(Convert.ToInt32(id));
	                   nivel3.Show();
	                   this.Hide();
	                   break;
	                case 4:
	                   Formnivel4 nivel4 = new Formnivel4(Convert.ToInt32(id));
	                   nivel4.Show();
	                   this.Hide();
	                   break;
	                case 5:
	                    Formnivel5 nivel5 = new Formnivel5(Convert.ToInt32(id));
	                    nivel5.Show();
	                    this.Hide();
	                    break;
	               default:
	                   MessageBox.Show("Nivel no reconocido");
	                   break;
	           }
		            	MessageBox.Show("Usuario: " + nombreUsuario + " - Nivel: " + nivel, "Usuario cargado");
		            }
		            else
		            {
		                MessageBox.Show("No se pudo obtener el nivel del usuario", "Error");
		            }
		        }
		        else
		        {
		            MessageBox.Show("El usuario que has ingresado no existe");
		        }
		    }
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
		
		void FormCargarUsuarioLoad(object sender, EventArgs e)
		{
			miConexion = new ClassConexion();
			miConexion.CrearConexion();				
		}
	}
}
	
