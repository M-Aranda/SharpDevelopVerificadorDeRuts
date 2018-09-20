/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/18/2018
 * Time: 11:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VerificadorDeRuts.Utilidades;

namespace VerificadorDeRuts
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 
		Util ut;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ut= new Util();
			
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnVerificarClick(object sender, EventArgs e)
		{
			
			String rut=txtRut.Text;
			
			String digito=ut.GetDigito(rut);
			Char []r=rut.ToCharArray();
			MessageBox.Show(r.Last().ToString());
			Boolean valido=ut.IsRutOk(rut,digito);
			if(valido==false){
				MessageBox.Show("El rut ingresado no es valido. El numero verificador debiese ser "+digito);
			}else if (valido==true){
				MessageBox.Show("Rut es valido "+digito);
			}
			
		}
	}
}
