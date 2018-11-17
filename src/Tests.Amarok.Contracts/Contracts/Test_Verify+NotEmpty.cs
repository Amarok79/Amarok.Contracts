/* Copyright(c) 2018, Olaf Kober
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
		[Test]
		public void NotEmpty_DoesNotThrow()
		{
			Check.ThatCode(() => Verify.NotEmpty("foo", "name"))
				.DoesNotThrow();
			Check.ThatCode(() => Verify.NotEmpty(" ", "name"))
				.DoesNotThrow();
		}

		[Test]
		public void NotEmpty_Throws_For_Null()
		{
			var exception = Check.ThatCode(() => Verify.NotEmpty(null, "name"))
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
		public void NotEmpty_Throws_For_EmptyString()
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


		[Test]
		public void DebugNotEmpty_DoesNotThrow()
		{
			Check.ThatCode(() => Verify.Debug.NotEmpty("foo", "name"))
				.DoesNotThrow();
			Check.ThatCode(() => Verify.Debug.NotEmpty(" ", "name"))
				.DoesNotThrow();
		}

		[Test]
		public void DebugNotEmpty_Throws_For_Null()
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
		public void DebugNotEmpty_Throws_For_EmptyString()
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
}
