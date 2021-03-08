using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stagiaires
{
	class Stagiaire
	{
		public string nom { get; set; }
		public decimal[] notes { get; set; }

		public Stagiaire(string nom, decimal[] notes)
		{
			this.nom = nom;
			this.notes = notes;
		}

		public decimal CalculerMoyenne()
		{

			return notes.Sum()/ notes.Length;
		}


		decimal TrouverMax()
		{
			//decimal max = notes[0]; // on peut utiliser 0

			//foreach (decimal i in notes)
			//	if (i > max) max = i;

			//return max;


			return notes.Max();
		}

		decimal TrouverMin()
		{
			//decimal min = notes[0]; // on peut utiliser 20
			//foreach (decimal i in notes)
			//	if (i < min) min = i;

			//return min;

			return notes.Min();
		}
	}
}
