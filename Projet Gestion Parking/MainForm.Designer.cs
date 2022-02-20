/*
 * Created by SharpDevelop.
 * User: ElMaby
 * Date: 13/06/2019
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projet_Gestion_Parking
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelListeVoitures = new System.Windows.Forms.FlowLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.temps = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.ajouterVoiture = new System.Windows.Forms.Button();
			this.largeur = new System.Windows.Forms.TextBox();
			this.longueur = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.arreter = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.demarrer = new System.Windows.Forms.Button();
			this.parking = new System.Windows.Forms.FlowLayoutPanel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnAjouterPlace = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.definir = new System.Windows.Forms.Button();
			this.nombrePlace = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.largeurPlace = new System.Windows.Forms.TextBox();
			this.longueurPlace = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.statistique = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.panelListeVoitures);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 681);
			this.panel1.TabIndex = 0;
			// 
			// panelListeVoitures
			// 
			this.panelListeVoitures.Location = new System.Drawing.Point(3, 30);
			this.panelListeVoitures.Name = "panelListeVoitures";
			this.panelListeVoitures.Size = new System.Drawing.Size(219, 648);
			this.panelListeVoitures.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(3, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(219, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "LISTE D\'ATTENTE";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel3.Controls.Add(this.temps);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.ajouterVoiture);
			this.panel3.Controls.Add(this.largeur);
			this.panel3.Controls.Add(this.longueur);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(243, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(323, 143);
			this.panel3.TabIndex = 2;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3Paint);
			// 
			// temps
			// 
			this.temps.Location = new System.Drawing.Point(94, 87);
			this.temps.Name = "temps";
			this.temps.Size = new System.Drawing.Size(210, 20);
			this.temps.TabIndex = 10;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(2, 90);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(62, 23);
			this.label12.TabIndex = 9;
			this.label12.Text = "Temps";
			// 
			// ajouterVoiture
			// 
			this.ajouterVoiture.BackColor = System.Drawing.Color.White;
			this.ajouterVoiture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ajouterVoiture.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ajouterVoiture.Location = new System.Drawing.Point(132, 115);
			this.ajouterVoiture.Name = "ajouterVoiture";
			this.ajouterVoiture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ajouterVoiture.Size = new System.Drawing.Size(75, 23);
			this.ajouterVoiture.TabIndex = 8;
			this.ajouterVoiture.Text = "AJOUTER";
			this.ajouterVoiture.UseVisualStyleBackColor = false;
			this.ajouterVoiture.Click += new System.EventHandler(this.AjouterVoitureClick);
			// 
			// largeur
			// 
			this.largeur.Location = new System.Drawing.Point(94, 57);
			this.largeur.Name = "largeur";
			this.largeur.Size = new System.Drawing.Size(210, 20);
			this.largeur.TabIndex = 7;
			// 
			// longueur
			// 
			this.longueur.Location = new System.Drawing.Point(94, 28);
			this.longueur.Name = "longueur";
			this.longueur.Size = new System.Drawing.Size(210, 20);
			this.longueur.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(4, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(316, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ajouter une nouvelle voiture";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(3, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Largeur";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Longueur";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel4.Controls.Add(this.arreter);
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Controls.Add(this.demarrer);
			this.panel4.Location = new System.Drawing.Point(572, 12);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(286, 143);
			this.panel4.TabIndex = 3;
			// 
			// arreter
			// 
			this.arreter.BackColor = System.Drawing.Color.White;
			this.arreter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.arreter.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.arreter.Location = new System.Drawing.Point(60, 78);
			this.arreter.Name = "arreter";
			this.arreter.Size = new System.Drawing.Size(179, 36);
			this.arreter.TabIndex = 9;
			this.arreter.Text = "ARRETER";
			this.arreter.UseVisualStyleBackColor = false;
			this.arreter.Click += new System.EventHandler(this.ArreterClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Location = new System.Drawing.Point(292, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(323, 143);
			this.panel2.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(94, 78);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(210, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(94, 36);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(210, 20);
			this.textBox2.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(138, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "AJOUTER";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ajouter une nouvelle voiture";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(3, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Largeur";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(3, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "Longueur";
			// 
			// demarrer
			// 
			this.demarrer.BackColor = System.Drawing.Color.White;
			this.demarrer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.demarrer.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.demarrer.Location = new System.Drawing.Point(60, 21);
			this.demarrer.Name = "demarrer";
			this.demarrer.Size = new System.Drawing.Size(179, 35);
			this.demarrer.TabIndex = 1;
			this.demarrer.Text = "DEMARRER";
			this.demarrer.UseVisualStyleBackColor = false;
			this.demarrer.Click += new System.EventHandler(this.Button3Click);
			// 
			// parking
			// 
			this.parking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.parking.Location = new System.Drawing.Point(243, 170);
			this.parking.Name = "parking";
			this.parking.Size = new System.Drawing.Size(615, 532);
			this.parking.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel5.Controls.Add(this.btnAjouterPlace);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Controls.Add(this.definir);
			this.panel5.Controls.Add(this.nombrePlace);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Controls.Add(this.largeurPlace);
			this.panel5.Controls.Add(this.longueurPlace);
			this.panel5.Controls.Add(this.label8);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Controls.Add(this.label10);
			this.panel5.Location = new System.Drawing.Point(868, 12);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(329, 310);
			this.panel5.TabIndex = 6;
			// 
			// btnAjouterPlace
			// 
			this.btnAjouterPlace.BackColor = System.Drawing.Color.White;
			this.btnAjouterPlace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjouterPlace.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouterPlace.Location = new System.Drawing.Point(147, 268);
			this.btnAjouterPlace.Name = "btnAjouterPlace";
			this.btnAjouterPlace.Size = new System.Drawing.Size(75, 23);
			this.btnAjouterPlace.TabIndex = 18;
			this.btnAjouterPlace.Text = "AJOUTER";
			this.btnAjouterPlace.UseVisualStyleBackColor = false;
			this.btnAjouterPlace.Click += new System.EventHandler(this.BtnAjouterPlaceClick);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Location = new System.Drawing.Point(1, 112);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(326, 12);
			this.panel6.TabIndex = 17;
			// 
			// definir
			// 
			this.definir.BackColor = System.Drawing.Color.White;
			this.definir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.definir.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.definir.Location = new System.Drawing.Point(128, 58);
			this.definir.Name = "definir";
			this.definir.Size = new System.Drawing.Size(144, 23);
			this.definir.TabIndex = 16;
			this.definir.Text = "Définir";
			this.definir.UseVisualStyleBackColor = false;
			this.definir.Click += new System.EventHandler(this.DefinirClick);
			// 
			// nombrePlace
			// 
			this.nombrePlace.Location = new System.Drawing.Point(128, 16);
			this.nombrePlace.Name = "nombrePlace";
			this.nombrePlace.Size = new System.Drawing.Size(144, 20);
			this.nombrePlace.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(4, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(123, 23);
			this.label11.TabIndex = 14;
			this.label11.Text = "Nombre de places";
			// 
			// largeurPlace
			// 
			this.largeurPlace.Location = new System.Drawing.Point(106, 222);
			this.largeurPlace.Name = "largeurPlace";
			this.largeurPlace.Size = new System.Drawing.Size(210, 20);
			this.largeurPlace.TabIndex = 13;
			// 
			// longueurPlace
			// 
			this.longueurPlace.Location = new System.Drawing.Point(106, 180);
			this.longueurPlace.Name = "longueurPlace";
			this.longueurPlace.Size = new System.Drawing.Size(210, 20);
			this.longueurPlace.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(4, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(322, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "Ajouter une nouvelle place";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(15, 225);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 23);
			this.label9.TabIndex = 9;
			this.label9.Text = "Largeur";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(15, 183);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "Longueur";
			// 
			// statistique
			// 
			this.statistique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.statistique.FormattingEnabled = true;
			this.statistique.Location = new System.Drawing.Point(867, 328);
			this.statistique.Name = "statistique";
			this.statistique.Size = new System.Drawing.Size(330, 368);
			this.statistique.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 705);
			this.Controls.Add(this.statistique);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.parking);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Projet Gestion Parking";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button arreter;
		private System.Windows.Forms.ListBox statistique;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox temps;
		private System.Windows.Forms.Button btnAjouterPlace;
		private System.Windows.Forms.Button ajouterVoiture;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox longueurPlace;
		private System.Windows.Forms.TextBox largeurPlace;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox nombrePlace;
		private System.Windows.Forms.Button definir;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel panelListeVoitures;
		private System.Windows.Forms.FlowLayoutPanel parking;
		private System.Windows.Forms.Button demarrer;
		private System.Windows.Forms.TextBox longueur;
		private System.Windows.Forms.TextBox largeur;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		
		void Panel3Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			
		}
	}
}
