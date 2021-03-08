using System;
using System.Collections.Generic;
using System.Text;

namespace Personnes
{
	class Adresse
	{
		public string Rue { get; set; }
		public string Ville { get; set; }
		public string codePostale { get; set; }

		public Adresse(string rue, string ville, string codePostale)
		{
			Rue = rue;
			Ville = ville;
			this.codePostale = codePostale;
		}
	}
}
