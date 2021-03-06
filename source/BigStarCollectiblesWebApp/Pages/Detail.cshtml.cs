using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigStarCollectiblesWebApp.Models;

namespace BigStarCollectiblesWebApp {
	public class DetailModel : PageModel {
		public void OnGet(int id) {

			//CurrentTourStop = new TailorMadeTours.Models.TourSource().TourStops.FirstOrDefault(x => x.StopNumber == stopNumber);
			MonsterCard = new CardSource().MonsterCards.FirstOrDefault(x => x.Id == id);
		}

		public MonsterCard MonsterCard { get; set; }
	}
}
