using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoProgramación
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			 DialogResult resultado = MessageBox.Show("¿Estás seguro que quieres salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    
    		if (resultado == DialogResult.Yes)
    		{
        		this.Close();
    		}
		}
		
		void BtnNuevoJuegoClick(object sender, EventArgs e)
		{
				FormAgregarUsuario Usuario = new FormAgregarUsuario();
				Usuario.Show();
				this.Hide();	
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			pic_logo.Image = Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\foco.jpg");
		}
		
		void BtnInsigniasClick(object sender, EventArgs e)
		{
				FormInsignias insignias = new FormInsignias();
				insignias.Show();
				this.Hide();
		}
		
		void BtnCargarJuegoClick(object sender, EventArgs e)
		{
				FormCargarUsuario Usuario = new FormCargarUsuario();
				Usuario.Show();
				this.Hide();				
		}
	}
}
