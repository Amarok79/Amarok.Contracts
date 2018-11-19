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
		[TestFixture]
		public class NotNull_Object
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.NotNull(new Object(), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.NotNull(123, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.NotNull((Object)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class Debug_NotNull_Object
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.Debug.NotNull(new Object(), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.NotNull(123, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.NotNull((Object)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}
	}
}
