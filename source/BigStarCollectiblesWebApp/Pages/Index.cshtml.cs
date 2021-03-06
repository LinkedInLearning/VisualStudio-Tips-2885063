using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStarCollectiblesWebApp.Pages
{
	public class IndexModel : PageModel
	{
		public IndexModel()
		{
			this.MonsterCards = new Models.CardSource().MonsterCardsOrderedByName;
		}
	
		public void OnGet()
		{

		}
		public List<Models.MonsterCard> MonsterCards { get; set; }
	}
}
