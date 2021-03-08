using System;
using System.Collections.Generic;
using System.Text;

namespace TPSQLI
{
	class Point
	{
		private double Abs { get; set; }
		private double Ord { get; set; }


		public Point(double abs, double ord)
		{
			Abs = abs;
			Ord = ord;
		}

		override public string ToString()
		{

			return String.Format("({0}, {1})", Abs, Ord);
		}

		public double CalculerDistance(Point p)
		{

			var distanceSquare = Math.Pow(p.Abs - Abs, 2) + Math.Pow(p.Ord - Ord, 2);
			return Math.Sqrt(distanceSquare);
		}

		public Point CalculerMilieu(Point p)
		{
			return new Point((p.Abs + Abs) / 2, (p.Ord + Ord) / 2);
		}

		public static Point operator +(Point p1, Point p2)
		{
			return new Point(p1.Abs + p2.Abs, p1.Ord + p2.Ord);
		}

		public static Point operator /(Point p1, double q)
		{
			if (q != 0)
			{

				return new Point(p1.Abs / q, p1.Ord / q);
			}

			return p1;

		}
	}
}
