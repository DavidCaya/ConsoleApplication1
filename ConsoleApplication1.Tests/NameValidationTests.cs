using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApplication1.Library;

using NUnit.Framework;

namespace ConsoleApplication1.Tests
{
	[TestFixture]
	public class ValidatingUserName_HasNumber
	{
		[Test]
		public void NameIsInvalid()
		{
			string name = "test_123";
			Assert.That(name.Validate(), Is.False);

			name = "123 test";
			Assert.That(name.Validate(), Is.False);

			name = "test 123'bleh";
			Assert.That(name.Validate(), Is.False);
		}
	}

	[TestFixture]
	public class ValidatingUserName_HasNoNumber
	{
		[Test]
		public void NameIsValid()
		{
			string name = "test_name";
			Assert.That(name.Validate(), Is.True);

			name = "name test";
			Assert.That(name.Validate(), Is.True);

			name = "test a'test";
			Assert.That(name.Validate(), Is.True);
		}
	}
}
