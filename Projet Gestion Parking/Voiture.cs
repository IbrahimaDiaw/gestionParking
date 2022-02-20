/*
 * Created by SharpDevelop.
 * User: ElMaby
 * Date: 13/06/2019
 * Time: 21:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Projet_Gestion_Parking
{
	/// <summary>
	/// Description of Voiture.
	/// </summary>
	public class Voiture
	{
		public static int numerosVoiture = 1;
		public int numero;
		public int longueur;
		public int largeur;
		public bool estDansParking;
		public int numeroPlace;
		public int temps;
		public int tempsEcoule = 0;
		public Timer timer;
		
		public Voiture(int numero, int longueur, int largeur, int temps)
		{
			this.numero = numero;
			this.longueur = longueur;
			this.largeur = largeur;
			this.estDansParking = false;
			this.temps = temps;
			this.timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += new EventHandler(s_myTimer_Tick);
		}
		
		void s_myTimer_Tick(object sender, EventArgs e)
		{
			if (this.tempsEcoule < this.temps)
			{
				this.tempsEcoule++;
			}
			else{
				this.timer.Stop();
			}
		}
		
		public bool tempsTermine(){
			return (this.tempsEcoule == this.temps);
		}
	}
}