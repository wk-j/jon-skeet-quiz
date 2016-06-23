using NUnit.Framework;
using System;
namespace JonSkeetQuiz {

	public class Question21 {
		[Test()]
		public void Question11() {

			object x = new String(new char[0]);
			object y = new String(new char[0]);
			Assert.True(x == y);
		}

		[Test()]
		public void Question12() {
			object x = new int?();
			object y = new int?();
			Assert.True(x == y);
		}

		[Test()]
		public void Question3() {
			var x = new int?();
			string text = x.ToString();
			Assert.Throws<NullReferenceException>(() => x.GetType());
		}
	}
}


