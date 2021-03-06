using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigStarCollectiblesWebApp.Models {
	public class MonsterCard {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Slogan { get; set; }
		public int EyeCount { get; set; }
		public bool Spikes { get; set; }
		public bool Antenna { get; set; }
		public string Family { get; set; }

		public string Description { get; set; }
		public decimal ListPrice { get; set; }
		public decimal AskingPrice { get; set; }
		public decimal Discount { get { return AskingPrice *.45M; } }
		public decimal SalePrice { get { return AskingPrice - Discount; } }
		public string ImageUri { get; set; }
		public string ShortDescription { get; set; }
		public int PopularityIndex { get; set; }



		public bool IsDiscounted
		{
			get { return PopularityIndex < 450; }

		}

	}
}
