/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#define DEBUG

using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public partial class Test_Verify
	{
		[TestFixture]
		public class NotEmpty_String
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.NotEmpty("foo", "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.NotEmpty(" ", "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.NotEmpty((String)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyString()
			{
				var exception = Check.ThatCode(() => Verify.NotEmpty(String.Empty, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyString);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class Debug_NotEmpty_String
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.NotEmpty("foo", "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.NotEmpty(" ", "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyString()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(String.Empty, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyString);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class NotEmpty_Enumerable
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.NotEmpty(new[] { 123, 456 }, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.NotEmpty(CreateNonEmptyEnumerable(), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.NotEmpty((IEnumerable<Int32>)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyReadOnlyCollection()
			{
				var collection = new Int32[0];

				var exception = Check.ThatCode(() => Verify.NotEmpty(collection, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyCollection);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyEnumerable()
			{
				var collection = CreateEmptyEnumerable();

				var exception = Check.ThatCode(() => Verify.NotEmpty(collection, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyCollection);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class Debug_NotEmpty_Enumerable
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.NotEmpty(new[] { 123, 456 }, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.NotEmpty(CreateNonEmptyEnumerable(), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotEmpty((IEnumerable<Int32>)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyReadOnlyCollection()
			{
				var collection = new Int32[0];

				var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(collection, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyCollection);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_EmptyEnumerable()
			{
				var collection = CreateEmptyEnumerable();

				var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(collection, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyCollection);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}


		private static IEnumerable<Int32> CreateEmptyEnumerable()
		{
			yield break;
		}
		private static IEnumerable<Int32> CreateNonEmptyEnumerable()
		{
			yield return 123;
			yield return 456;
		}
	}
}
