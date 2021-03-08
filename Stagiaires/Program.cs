using System;

namespace Stagiaires
{
	class Program
	{
		static void Main(string[] args)
		{
			Stagiaire stagiaire1 = new Stagiaire("Mehdi1", new decimal[]{ 7,7,8});
			Stagiaire stagiaire2 = new Stagiaire("Mehdi2", new decimal[]{ 3,9,8});
			Stagiaire stagiaire3 = new Stagiaire("Mehdi3", new decimal[]{ 6,5,8});


			Stagiaire[] stagiaires = new Stagiaire[] { stagiaire1, stagiaire2, stagiaire3 };

			Formation formation = new Formation("SQLI SC", 30, stagiaires);


			Console.WriteLine($"Moyen Formation : {formation.CalculerMoyenneFormation():F2}");


			Console.WriteLine($"Moyenne Mehdi1 : {formation.TrouverMoyenneParNom("Mehdi1"):F2}");
			Console.WriteLine($"Moyenne Mehdi2 : {formation.TrouverMoyenneParNom("Mehdi2"):F2}");
			Console.WriteLine($"Moyenne Mehdi3 : {formation.TrouverMoyenneParNom("Mehdi3"):F2}");


			Console.WriteLine($"Index Max : {formation.GetIndexMax()}");

			Console.WriteLine($"Nom Max : {formation.AfficherNomMax()}");

			Console.WriteLine($"Min Max : {formation.AfficherMinMax()}");

		}
	}
}
