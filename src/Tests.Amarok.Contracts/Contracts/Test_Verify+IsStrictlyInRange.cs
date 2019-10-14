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
		public class IsStrictlyInRange_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsStrictlyInRange((Int32)101, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsStrictlyInRange((Int32)199, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Int32)100, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Int32)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Int32)200, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsStrictlyInRange_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsStrictlyInRange((Int64)101, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsStrictlyInRange((Int64)199, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Int64)100, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Int64)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Int64)200, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsStrictlyInRange_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsStrictlyInRange((Double)101, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsStrictlyInRange((Double)199, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Double)100, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Double)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange((Double)200, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsStrictlyInRange_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsStrictlyInRange(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsStrictlyInRange(TimeSpan.FromTicks(199), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(100));
				Check.That((TimeSpan)exception.LowerLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsStrictlyInRange(TimeSpan.FromTicks(200), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(200));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(200));
			}
		}

		[TestFixture]
		public class Debug_IsStrictlyInRange_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int32)101, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int32)199, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int32)100, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Int32)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int32)200, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debug_IsStrictlyInRange_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int64)101, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int64)199, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int64)100, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Int64)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Int64)200, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debg_IsStrictlyInRange_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Double)101, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Double)199, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Double)100, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(100);
				Check.That((Double)exception.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange((Double)200, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(200);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debug_IsStrictlyInRange_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsStrictlyInRange(TimeSpan.FromTicks(199), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsLowerLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(100));
				Check.That((TimeSpan)exception.LowerLimit)
					.IsEqualTo(TimeSpan.FromTicks(100));
			}

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyInRange(TimeSpan.FromTicks(200), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsStrictlyLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(200));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(200));
			}
		}
	}
}
