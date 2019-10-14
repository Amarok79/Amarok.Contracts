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
		public class IsLessThan_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsLessThan((Int32)100, (Int32)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsLessThan((Int32)99, (Int32)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsLessThan((Int32)101, (Int32)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsLessThan_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsLessThan((Int64)100, (Int64)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsLessThan((Int64)99, (Int64)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsLessThan((Int64)101, (Int64)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsLessThan_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsLessThan((Double)100, (Double)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsLessThan((Double)99, (Double)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsLessThan((Double)101, (Double)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class IsLessThan_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsLessThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsLessThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsLessThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(101));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}
		}


		[TestFixture]
		public class Debug_IsLessThan_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsLessThan((Int32)100, (Int32)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsLessThan((Int32)99, (Int32)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsLessThan((Int32)101, (Int32)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsLessThan_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsLessThan((Int64)100, (Int64)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsLessThan((Int64)99, (Int64)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsLessThan((Int64)101, (Int64)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsLessThan_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsLessThan((Double)100, (Double)100, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsLessThan((Double)99, (Double)100, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsLessThan((Double)101, (Double)100, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(101);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(100);
			}
		}

		[TestFixture]
		public class Debug_IsLessThan_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsLessThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsLessThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsLessThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(101));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}
		}
	}
}
