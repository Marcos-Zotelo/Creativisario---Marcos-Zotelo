using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoProgramación
{
	public partial class FormInsignias : Form
	{
		public FormInsignias()
		{
			InitializeComponent();
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
		
		void Pic_InsCreatividadClick(object sender, EventArgs e)
		{
			pic_InsCreatividad.Image = Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\Insignias\insignia curiosidad.jpg");	
			label3.Text=("Es el primer paso del proceso creativo, el motor que impulsa la exploración, el descubrimiento y el deseo de conocer más.");		
		}
		
		void Pic_InsObservacionClick(object sender, EventArgs e)
		{
			pic_InsObservacion.Image= Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\Insignias\insignia observacion.png");
			label1.Text=("Es el acto consciente de percibir, analizar y comprender el entorno que nos rodea para obtener información, inspiración y nuevas perspectivas.");
		}
		
		void Pic_InsFmentalClick(object sender, EventArgs e)
		{
			pic_InsFmental.Image = Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\Insignias\Insignia flexibilidad mental.png");
			label2.Text=("Es la capacidad de adaptarse, cambiar de perspectiva y generar ideas innovadoras al conectar conceptos.");
		}
		
		void Pic_InsPersistenciaClick(object sender, EventArgs e)
		{
			pic_InsPersistencia.Image = Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\Insignias\insignia persistencia.jpg");
			label4.Text=("Es la capacidad de continuar trabajando en un proyecto, idea o problema a pesar de los obstáculos que se presentan.");
		}
		
		void Pic_InsRproblemasClick(object sender, EventArgs e)
		{
			pic_InsRproblemas.Image=Image.FromFile(@"C:\Users\'\Documents\ProyectoProgramación\ProyectoProgramación\bin\Debug\img\Insignias\insignia resolucion de problemas.png");
			label5.Text=("Utilizando los enfoques creativos aprendidos, se llega a la solución del problema, con un resultado satisfactorio y original.");
		}	
	}
}
