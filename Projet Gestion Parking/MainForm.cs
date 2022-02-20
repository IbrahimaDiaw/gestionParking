/*
 * Created by SharpDevelop.
 * User: ElMaby
 * Date: 13/06/2019
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Projet_Gestion_Parking
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static Gestion gestion;
		Timer timer;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			gestion = new Gestion();
			longueurPlace.Enabled = false;
			largeurPlace.Enabled = false;
			btnAjouterPlace.Enabled = false;
			longueur.Enabled = false;
			largeur.Enabled = false;
			temps.Enabled = false;
			ajouterVoiture.Enabled = false;
			demarrer.Enabled = false;
			arreter.Enabled = false;
			this.timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += new System.EventHandler(timerTick);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void timerTick(object sender, EventArgs e){
			for(int i = 0; i < gestion.listeVoituresEntrees.Count; i++){
				if(gestion.listeVoituresEntrees.ElementAt(i).tempsTermine())
					effectuerSortie(gestion.listeVoituresEntrees.ElementAt(i).numero);
			}
			if(gestion.placeLibre()){
				int [] resultat = gestion.effectuerEntree();
				if(resultat != null){
					statistique.Items.Add("Voiture numéro "+resultat[2]+" placé à la place numéro : "+resultat[1]);
					gestionDesVoitures();
					gestionDesPlaces();
				}
			}
		}
		
		public void ajouterPlace(Place p){
			ListBox place = new ListBox();
			place.Items.Add("Place N° : "+p.numero);
			place.Items.Add("Longueur : "+p.longueur);
			place.Items.Add("Largeur : "+p.largeur);
			place.Items.Add("Occupée : [L : "+p.espaceOccupee[0]+", l : "+p.espaceOccupee[1]+"]");
			place.Width = 150;
			parking.Controls.Add(place);
			//parking.Refresh();
		}
		
		public void gestionDesPlaces(){
			parking.Controls.Clear();
			for(int i = 0; i < gestion.listePlaces.Count; i++){
				ajouterPlace(gestion.listePlaces.ElementAt(i));
			}
			parking.Refresh();
		}
		
		public void gestionDesVoitures(){
			panelListeVoitures.Controls.Clear();
			for(int i = 0; i < gestion.listeVoitures.Count; i++){
				addVoiture(gestion.listeVoitures.ElementAt(i));
			}
			panelListeVoitures.Refresh();
		}
		
		void DefinirClick(object sender, EventArgs e)
		{
			try{
				int nombrePlaceV = int.Parse(nombrePlace.Text);
				Gestion.nombrePlace = nombrePlaceV;
				nombrePlace.Enabled = false;
				definir.Enabled = false;
				longueurPlace.Enabled = true;
				largeurPlace.Enabled = true;
				btnAjouterPlace.Enabled = true;
				longueur.Enabled = true;
				largeur.Enabled = true;
				temps.Enabled = true;
				ajouterVoiture.Enabled = true;
				demarrer.Enabled = true;
				arreter.Enabled = true;
				longueurPlace.Focus();
			}
			catch(Exception ex){
				MessageBox.Show("Veuillez entrer une bonne valeur");
			}			
		}
		
		void AjouterVoitureClick(object sender, EventArgs e)
		{
			if(Gestion.nombrePlace == 0){
				MessageBox.Show("Veuillez d'abord ajouter des places");
				return;
			}
			try{
				int numeroV = Voiture.numerosVoiture++,
					longueurV = int.Parse(longueur.Text),
					largeurV = int.Parse(largeur.Text),
					tempsV = int.Parse(temps.Text);
				Voiture v = new Voiture(numeroV, longueurV, largeurV, tempsV);
				gestion.ajouterVoiture(v);
				addVoiture(v);
				MessageBox.Show("Voiture ajoutée avec succes");
				longueur.Text = "";
				largeur.Text = "";
				temps.Text = "";
				//voitures.Items.Add(numeroV);
			}
			catch(Exception ex){
				MessageBox.Show("Veuillez entrer des données valides");
				MessageBox.Show(ex.Message);
			}
		}
		
		void addVoiture(Voiture v){
			ListBox voiture = new ListBox();
			voiture.Items.Add("Voiture N° : "+v.numero);
			voiture.Items.Add("Longueur : "+v.longueur);
			voiture.Items.Add("Largeur : "+v.largeur);
			voiture.Items.Add("Temps de séjour : "+v.temps);
			panelListeVoitures.Controls.Add(voiture);
		}
		
		void BtnAjouterPlaceClick(object sender, EventArgs e)
		{
			try{
				int numeroP = Place.numerosPlace++,
					longueurP = int.Parse(longueurPlace.Text),
					largeurP = int.Parse(largeurPlace.Text);
				Place p = new Place(numeroP, longueurP, largeurP);
				gestion.ajouterPlace(p);
				if(Gestion.nombrePlace == gestion.listePlaces.Count){
					longueurPlace.Enabled = false;
					largeurPlace.Enabled = false;
					btnAjouterPlace.Enabled = false;
				}
				MessageBox.Show("Place ajoutée avec succes");
				longueurPlace.Text = "";
				largeurPlace.Text = "";
				gestionDesPlaces();
			}
			catch(Exception ex){
				MessageBox.Show("Veuillez entrer des données valides");
				//MessageBox.Show(ex.StackTrace);
			}			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.timer.Start();
		}
		
		public void effectuerSortie(int numero){
			if(gestion.sortie(numero)){
				//voitures.Items.Remove(numero);
				//MessageBox.Show("sortie");
				gestionDesPlaces();
				statistique.Items.Add("La voiture numéro "+numero+" est sortie du parking");
			}
			else{
				MessageBox.Show("Erreur de sortie");
			}
		}
		
		void ArreterClick(object sender, EventArgs e)
		{
			timer.Stop();
		}
	}
}
