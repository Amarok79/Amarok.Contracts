/* Copyright(c) 2019, Olaf Kober
 * Licensed under GNU Greaterer General Public License v3.0 (LPGL-3.0).
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
		public class IsGreaterThan_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsGreaterThan((Int32)101, (Int32)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsGreaterThan((Int32)100, (Int32)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsGreaterThan((Int32)99, (Int32)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Int32)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsGreaterThan_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsGreaterThan((Int64)101, (Int64)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsGreaterThan((Int64)100, (Int64)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsGreaterThan((Int64)99, (Int64)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Int64)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsGreaterThan_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsGreaterThan((Double)101, (Double)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsGreaterThan((Double)100, (Double)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsGreaterThan((Double)99, (Double)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Double)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsGreaterThan_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsGreaterThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsGreaterThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsGreaterThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(99));
				Check.That((TimeSpan)exception.LowerLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}
		}


		[TestFixture]
		public class Debug_IsGreaterThan_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int32)101, (Int32)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int32)100, (Int32)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int32)99, (Int32)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Int32)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsGreaterThan_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int64)101, (Int64)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int64)100, (Int64)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsGreaterThan((Int64)99, (Int64)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Int64)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsGreaterThan_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Double)101, (Double)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsGreaterThan((Double)100, (Double)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsGreaterThan((Double)99, (Double)100, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(99);
				Check.That((Double)exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsGreaterThan_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsGreaterThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsGreaterThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsGreaterThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(99));
				Check.That((TimeSpan)exception.LowerLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}
		}
	}
}
