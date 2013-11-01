/*
 * Creado por SharpDevelop.
 * Usuario: Alumnos
 * Fecha: 31/10/2013
 * Hora: 07:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int aciertos = 0;
		public string puntaje;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			pregunta1();
			pregunta2();
			pregunta3();
			pregunta4();
			puntajes();
			MessageBox.Show("Codigo:" + this.textBox1.Text + "\n"+
			                "Nombre:" + this.textBox2.Text + "\n"+
			                "Aciertos:" +this.aciertos.ToString() + "\n"+
			               	puntaje);
			
			
		}
		public void pregunta1(){
			
			if(this.radioButton1.Checked)
			{
				aciertos++;
			}
			
		}
		public void pregunta2(){
			
			if(this.ReinoUnido.Checked)
			{
				aciertos++;
			}
			if(this.Portugal.Checked)
			{
				aciertos++;
			}
			if(this.Macedonia.Checked)
			{
				aciertos++;
			}
		}
		public void pregunta3(){
			
			if(this.numericUpDown1.Text == "31")
			{
				aciertos++;
			}
			
		}
		public void pregunta4(){
			
			
			DateTime fecha = this.monthCalendar1.SelectionStart;
			
			if(fecha.ToShortDateString() == "07/05/1945")
			{
				aciertos++;
			}
		}
		public void puntajes(){
			
			switch (aciertos){
				
				case 0: puntaje = "¡CONTESTA AUNQUE SEA UNA CAON!";
					break;
				case 1: puntaje = "¿PEÑA ERES TU?";
					break;
				case 2: puntaje = "¿PILLOS ERES TU?";
					break;
				case 3: puntaje = "ESFUERZATE MAS";
					break;
				case 4: puntaje = "PUEDES HACERLO MEJOR";
					break;
				case 5: puntaje = "BUEN PUNTAJE";
					break;
				case 6: puntaje = "ERES UN DIOS!";
					break;
			}
			
		}
	}
}
