/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/18/2018
 * Time: 11:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VerificadorDeRuts
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVerificar;
		private System.Windows.Forms.Label lblRut;
		private System.Windows.Forms.TextBox txtRut;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnVerificar = new System.Windows.Forms.Button();
			this.lblRut = new System.Windows.Forms.Label();
			this.txtRut = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnVerificar
			// 
			this.btnVerificar.Location = new System.Drawing.Point(217, 14);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(75, 23);
			this.btnVerificar.TabIndex = 0;
			this.btnVerificar.Text = "Verificar";
			this.btnVerificar.UseVisualStyleBackColor = true;
			this.btnVerificar.Click += new System.EventHandler(this.BtnVerificarClick);
			// 
			// lblRut
			// 
			this.lblRut.Location = new System.Drawing.Point(12, 13);
			this.lblRut.Name = "lblRut";
			this.lblRut.Size = new System.Drawing.Size(69, 23);
			this.lblRut.TabIndex = 1;
			this.lblRut.Text = "RUT:";
			// 
			// txtRut
			// 
			this.txtRut.Location = new System.Drawing.Point(96, 16);
			this.txtRut.Name = "txtRut";
			this.txtRut.Size = new System.Drawing.Size(100, 20);
			this.txtRut.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 110);
			this.Controls.Add(this.txtRut);
			this.Controls.Add(this.lblRut);
			this.Controls.Add(this.btnVerificar);
			this.Name = "MainForm";
			this.Text = "VerificadorDeRuts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
