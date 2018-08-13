namespace Lemmatozator
{
    public class KeyWord
    {
		public int Count {
			get; private set;
		}

		public string Key {
			get; private set;
		}

		public KeyWord(string key, int count) {
			Key = key;
			Count = count;
		}
	}
}
