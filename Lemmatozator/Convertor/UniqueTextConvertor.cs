using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lemmatozator.Convertor
{
    public class UniqueTextConvertor: BaseTextConvertor
    {
		public UniqueTextConvertor(List<KeyWord> keyWords) : base(keyWords) { }

		public override string Convert(string content) {
			foreach (var key in KeyWords) {
				var regex = new Regex(key.Key);
				var match = regex.Match(content);
				if (match.Success) {
					var con = regex.Replace(content, "<span>" + key.Key + "</span>");
					return con;
				}
			}
			
			return string.Empty;
		}
	}
}
