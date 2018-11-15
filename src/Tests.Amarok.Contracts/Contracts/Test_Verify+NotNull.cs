/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

using System;
using NCrunch.Framework;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public class Test_Verify
	{
		[TestFixture]
		public class NotNull
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.NotNull(new Object(), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.NotNull((Object)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.Not.IsEmpty();
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class NotNull_Debug
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.NotNull(new Object(), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
#if DEBUG
				var exception = Check.ThatCode(() => Verify.Debug.NotNull((Object)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.Not.IsEmpty();
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
#else
				Check.ThatCode(() => Verify.Debug.NotNull((Object)null, "name"))
					.DoesNotThrow();
#endif
			}
		}

		[TestFixture]
		public class NotNull_Configurable
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Configurable.NotNull(new Object(), "name"))
					.DoesNotThrow();
			}

			[Test, Serial]
			public void Throws_On()
			{
				Verify.Configurable.IsEnabled = true;
				try
				{
					var exception = Check.ThatCode(() => Verify.Configurable.NotNull((Object)null, "name"))
						.Throws<ArgumentNullException>()
						.Value;

					Check.That(exception.Message)
						.Not.IsEmpty();
					Check.That(exception.ParamName)
						.IsEqualTo("name");
					Check.That(exception.InnerException)
						.IsNull();
				}
				finally
				{
					Verify.Configurable.IsEnabled = false;
				}
			}

			[Test, Serial]
			public void Throws_Off()
			{
				Verify.Configurable.IsEnabled = false;
				try
				{
					Check.ThatCode(() => Verify.Configurable.NotNull((Object)null, "name"))
						.DoesNotThrow();
				}
				finally
				{
					Verify.Configurable.IsEnabled = false;
				}
			}
		}
	}
}
