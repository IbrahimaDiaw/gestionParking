/*
 * Created by SharpDevelop.
 * User: ElMaby
 * Date: 13/06/2019
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projet_Gestion_Parking
{
	/// <summary>
	/// Description of Place.
	/// </summary>
	public class Place
	{
		public static int numerosPlace = 1;
		public int numero;
		public int longueur;
		public int largeur;
		public int [] espaceOccupee;
		
		public Place(int numero, int longueur, int largeur)
		{
			this.numero = numero;
			this.longueur = longueur;
			this.largeur = largeur;
			this.espaceOccupee = new int[2];
			this.espaceOccupee[0] = 0;
			this.espaceOccupee[1] = 0;
		}
		
		public void placerVoiture(Voiture v){
			this.espaceOccupee[0] += v.longueur;
			this.espaceOccupee[1] += v.largeur;
		}
		
		public void deplacerVoiture(Voiture v){
			this.espaceOccupee[0] -= v.longueur;
			this.espaceOccupee[1] -= v.largeur;
		}
		
		public bool estPlacable(Voiture v){
			if((this.longueur - this.espaceOccupee[0] >= v.longueur) && (this.largeur - this.espaceOccupee[1] >= v.largeur))
				return true;
			
			return false;
		}
		
		public bool placeDisponible(){
			if((this.longueur > this.espaceOccupee[0]) && (this.largeur > this.espaceOccupee[1]))
				return true;
			
			return false;
		}
		
		public int[] espaceRestante(Voiture v){
			int [] restante = new int[2];
			restante[0] = this.longueur - this.espaceOccupee[0] - v.longueur;
			restante[1] = this.largeur - this.espaceOccupee[1] - v.largeur;
			return restante;
		}
	}
}