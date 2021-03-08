using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Personnes
{
	class ListePersonnes
	{
		public Personne[] Personnes { get; set; } = new Personne[10];

		public Personne FindByNom(string NomPerson)
		{
			return Personnes.FirstOrDefault(p => p.Nom == NomPerson);
		}

		public bool FindByCodePostal(string cp) {

			return Personnes.Any(p => p.Adresses.Any(a => a.codePostale == cp));
		
		}

		public int CountPersonneVille(string ville) {

			return Personnes.Where(p => p.Adresses.Any(a => a.Ville == ville)).Count();	
		}

		public void EditPersonneNom(string oldNom, string newNom) {

			Personne personne = Personnes.Where(p => p.Nom == oldNom);
			personne.Nom = newNom;
			
		}
	}
}
