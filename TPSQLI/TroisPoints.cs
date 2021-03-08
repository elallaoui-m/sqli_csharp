using System;
using System.Collections.Generic;
using System.Text;

namespace TPSQLI
{
	class TroisPoints
	{
		private Point Premier { get; set; }
		private Point Deuxieme { get; set; }
		private Point Troisieme { get; set; }

		public double distance1_2 { get; set; }
		public double distance1_3 { get; set; }
		public double distance2_3 { get; set; }

		public TroisPoints(Point premier, Point deuxieme, Point troisieme)
		{
			Premier = premier;
			Deuxieme = deuxieme;
			Troisieme = troisieme;

			// On va calculer les distance a la construction car il seront utilise pas mal de fois
			 distance1_2 = Premier.CalculerDistance(Deuxieme);
			 distance1_3 = Premier.CalculerDistance(Troisieme);
			 distance2_3 = Deuxieme.CalculerDistance(Troisieme);
		}


		public bool TesterAlignement()
		{
			return distance1_2 == distance1_3 + distance2_3  // Premier_deuxieme = premier_troisieme + deuxieme_troisime;
				|| distance1_3 == distance1_2 + distance2_3  // premier_troisieme = Premier_deuxieme + deuxieme_troisime;
				|| distance2_3 == distance1_2 + distance1_3; // deuxieme_troisime = Premier_deuxieme + premier_troisieme;
		}

		public bool EstIsocele()
		{
			return distance1_2 == distance1_3 // Premier_deuxieme = premier_troisieme
				|| distance1_2 == distance2_3 // Premier_deuxieme = deuxieme_troisime
				|| distance2_3 == distance1_3; //deuxieme_troisime = premier_troisieme
		}

		public override string ToString()
		{
			return String.Format("Premier : {0} \nDeuxieme: {1} \nTroisieme : {2}", Premier, Deuxieme, Troisieme);
		}

	}
}
