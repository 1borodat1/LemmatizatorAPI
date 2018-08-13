namespace Lemmatozator.Lemma
{
	public class LemmaBase
    {

		#region Properties: Public

		public string Lemma {
			get;
			protected set;
		}

		public string Word {
			get;
			protected set;
		}

		#endregion

		#region Constructor

		public LemmaBase(string lemma, string word) {
			Word = word;
			Lemma = lemma;
		}

		#endregion

	}
}
