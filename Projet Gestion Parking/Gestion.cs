/*
 * Created by SharpDevelop.
 * User: ElMaby
 * Date: 13/06/2019
 * Time: 21:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet_Gestion_Parking
{
	/// <summary>
	/// Description of Gestion.
	/// </summary>
	public class Gestion
	{
		public static int nombrePlace = 0;
		public LinkedList<Place> listePlaces = new LinkedList<Place>();
		public LinkedList<Voiture> listeVoitures = new LinkedList<Voiture>();
		public LinkedList<Voiture> listeVoituresEntrees = new LinkedList<Voiture>();
		
		public Gestion()
		{
			
		}
		
		public void ajouterVoiture(Voiture v){
			this.listeVoitures.AddLast(v);
		}
		
		public bool ajouterPlace(Place p){
			if(this.listePlaces.Count < nombrePlace){
				this.listePlaces.AddLast(p);
				return true;
			}
			return false;
		}
		
		public bool peutEntrer(Voiture v){
			for(int i = 0; i < listePlaces.Count; i++){
				if(listePlaces.ElementAt(i).estPlacable(v) == true){
					return true;
				}
			}
			
			return false;
		}
		
		public int entree(Voiture v){
			int i = meilleurePlace(v);
			if(listePlaces.ElementAt(i).estPlacable(v) == true){
				listePlaces.ElementAt(i).placerVoiture(v);
				return listePlaces.ElementAt(i).numero;
			}
			return 0;
		}
		
		public int meilleurePlace(Voiture v){
			int place = 0;
			int lgRestante, laRestante;
			lgRestante = listePlaces.ElementAt(0).longueur;
			laRestante = listePlaces.ElementAt(0).largeur;
			for(int i = 0; i < listePlaces.Count; i++){
				if(listePlaces.ElementAt(i).estPlacable(v)){
					int [] restante = listePlaces.ElementAt(i).espaceRestante(v);
					if((restante[0] < lgRestante && restante[1] <= laRestante) || (restante[0] <= lgRestante && restante[1] < laRestante))
						place=i;
				}
			}
			return place;
		}
		
		public bool placeLibre(){
			for(int i = 0; i < listePlaces.Count; i++){
				if(listePlaces.ElementAt(i).placeDisponible())
					return true;
			}
			return false;
		}
		
		public bool sortie(int numero){
			for(int i = 0; i < listeVoituresEntrees.Count; i++){
				if(listeVoituresEntrees.ElementAt(i).numero == numero){
					for(int j = 0; j < listePlaces.Count; j++){
						if(listePlaces.ElementAt(j).numero == listeVoituresEntrees.ElementAt(i).numeroPlace){
							listePlaces.ElementAt(j).deplacerVoiture(listeVoituresEntrees.ElementAt(i));
							listeVoituresEntrees.Remove(listeVoituresEntrees.ElementAt(i));
							return true;
						}
					}
				}
			}
			
			return false;
		}
		
		public int[] effectuerEntree(){
			int[] placee = new int[3];
			for(int i = 0; i < listeVoitures.Count; i++){
				Voiture v = listeVoitures.ElementAt(i);
				if(peutEntrer(v)){
					int place = entree(v);
					if(place != 0){
						listeVoitures.ElementAt(i).estDansParking = true;
						listeVoitures.ElementAt(i).numeroPlace = place;
						listeVoitures.ElementAt(i).timer.Start();
						listeVoituresEntrees.AddLast(listeVoitures.ElementAt(i));
						listeVoitures.Remove(listeVoitures.ElementAt(i));
						placee[0] = i;
						placee[1] = place;
						placee[2] = v.numero;
						return placee;
					}
				}
			}
			return null;
		}
	}
}