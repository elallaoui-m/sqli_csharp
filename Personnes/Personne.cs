using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
	class Personne
	{
		private string nom;
		public Sexe sexe { get; set; }
		public Adresse[] Adresses { get; set; }
		public string Nom { get => nom; set => nom = value; }

		public Personne(string nom, Sexe sexe, Adresse[] adresses)
		{
			Nom = nom;
			this.sexe = sexe;
			Adresses = adresses;
		}
	}




	enum Sexe
	{
		F, M
	}
}
