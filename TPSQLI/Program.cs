using System;

namespace TPSQLI
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1;
			Point p2;
			Point p3;

			double x, y;

			Console.WriteLine("Entrez les cordonnees du premier point :");
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);
			p1 = new Point(x, y);

			Console.WriteLine("Entrez les cordonnees du deuxieme point :");
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);
			p2 = new Point(x, y);

			Console.WriteLine("Entrez les cordonnees du troisieme point :");
			double.TryParse(Console.ReadLine(), out x);
			double.TryParse(Console.ReadLine(), out y);
			p3 = new Point(x, y);



			TroisPoints troisPoints = new TroisPoints(p1, p2, p3);

			Console.WriteLine(troisPoints);


			Console.WriteLine("Distance :");

			Console.WriteLine("Premier deuxieme :{0:N2}", p1.CalculerDistance(p2));
			Console.WriteLine("Premier troisieme :{0:N2} ", p1.CalculerDistance(p3));
			Console.WriteLine("Deuxieme troisime :{0:N2}", p2.CalculerDistance(p3));



			Console.WriteLine("Milieu :");
			Console.WriteLine("Milieu Premier deuxieme :{0}", p1.CalculerMilieu(p2));
			Console.WriteLine("Milieu Premier troisieme :{0} ", p1.CalculerMilieu(p3));
			Console.WriteLine("Milieu Deuxieme troisime :{0}", p2.CalculerMilieu(p3));




			Console.WriteLine("Sont alignes {0}", troisPoints.TesterAlignement() ? "Oui" : "Non");
			Console.WriteLine("Est Isocele {0}", troisPoints.EstIsocele() ? "Oui" : "Non");


		}
	}
}
