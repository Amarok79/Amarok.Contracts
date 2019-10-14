/* Copyright(c) 2019, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public partial class Test_Verify
	{
		[TestFixture]
		public class NotEmptyOrWhiteSpace_String
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.NotEmptyOrWhiteSpace("foo", "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.NotEmptyOrWhiteSpace(" x ", "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.NotEmptyOrWhiteSpace((String)null, "name"))
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
				var exception = Check.ThatCode(() => Verify.NotEmptyOrWhiteSpace(String.Empty, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyString);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_WhitespaceString()
			{
				var exception = Check.ThatCode(() => Verify.NotEmptyOrWhiteSpace(" ", "name"))
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
		public class Debug_NotEmptyOrWhiteSpace_String
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.NotEmptyOrWhiteSpace("foo", "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.NotEmptyOrWhiteSpace(" x ", "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotEmptyOrWhiteSpace(null, "name"))
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
				var exception = Check.ThatCode(() => Verify.Debug.NotEmptyOrWhiteSpace(String.Empty, "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentEmptyString);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws_For_WhitespaceString()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotEmptyOrWhiteSpace(" ", "name"))
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
	}
}
