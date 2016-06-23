using System;
using FluentAssertions;
using NUnit.Framework;

namespace JonSkeetQuiz {

	public class ReferenceGeneric<T> where T : class { }

	public class EvilClassBase {
		public string EvilMethod<T>() {
			return "int?";
		}
	}

	public class EvilClass: EvilClassBase {
		public string EvilMethod<T>(ReferenceGeneric<T> arg = null) where T : class {
			return "string";
		}

		public string EvilMethod<T>(T? arg = null) where T : struct {
			return "int";
		}
	}

	public class Question3 {
		[Test]
		public void Run() {
			var evil = new EvilClass();
			evil.EvilMethod<string>().Should().Be("string");
			evil.EvilMethod<int>().Should().Be("int");
			evil.EvilMethod<int?>().Should().Be("int?");

		}
	}
}

