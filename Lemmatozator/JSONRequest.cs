using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemmatozator.Controllers
{
    public class JSONRequest
    {
		public List<KeyWord> Exacts {
			get; set;
		}

		public List<KeyWord> Adjustable {
			get; set;
		}

		public List<KeyWord> Additionally {
			get; set;
		}

		public string Content {
			get; set;
		}
	}
}
