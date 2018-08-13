using LemmaSharp.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lemmatozator
{
    public sealed class Lemmatizator
	{
		private static readonly Lemmatizator instance = new Lemmatizator();
		private static readonly Lemmatizer _lemmatizer;
		static Lemmatizator() {
			var stream = new FileStream(@"full7z-mlteast-ru.lem", FileMode.Open);
			using (stream) {
				_lemmatizer = new Lemmatizer(stream);
			}
		}
		private Lemmatizator() {
		}

		public static Lemmatizer GetInstance() {
			return _lemmatizer;
		}
	}
}
