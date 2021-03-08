using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stagiaires
{
	class Formation
	{
		private string intitule { get; set; }
		private int NbrJours { get; set; }
		private Stagiaire[] Stagiaires { get; set; }

		public Formation(string intitule, int nbrJours, Stagiaire[] stagiaires)
		{
			this.intitule = (string)intitule.Clone();
			NbrJours = nbrJours;
			Stagiaires = (Stagiaire[])stagiaires.Clone();
		}

		public decimal CalculerMoyenneFormation()
		{
			return Stagiaires.Sum(s => s.CalculerMoyenne()) / Stagiaires.Length;
		}

		public int GetIndexMax()
		{

			int indexMax = 0;
			for (int i = 0; i < Stagiaires.Length; ++i)
			{
				if (Stagiaires[i].CalculerMoyenne() > Stagiaires[indexMax].CalculerMoyenne())
				{
					indexMax = i;
				}
			}

			return indexMax;
		}

		// On fait reference a GetIndexMax
		public string AfficherNomMax()
		{
			return Stagiaires[GetIndexMax()].nom;
		}

		public decimal AfficherMinMax()
		{
			return Stagiaires[GetIndexMax()].notes.Min();
		}

		public decimal TrouverMoyenneParNom(string nom)
		{
			return Stagiaires.FirstOrDefault(s => s.nom == nom).CalculerMoyenne();
		}


	}
}
