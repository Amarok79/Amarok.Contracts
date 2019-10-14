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
		public class IsInRange_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsInRange((Int32)100, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsInRange((Int32)200, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Int32)99, (Int32)100, (Int32)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Int32)201, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsInRange_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsInRange((Int64)100, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsInRange((Int64)200, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Int64)99, (Int64)100, (Int64)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Int64)201, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsInRange_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsInRange((Double)100, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsInRange((Double)200, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Double)99, (Double)100, (Double)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange((Double)201, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class IsInRange_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsInRange(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsInRange(TimeSpan.FromTicks(200), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.IsInRange(TimeSpan.FromTicks(201), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(201));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(200));
			}
		}

		[TestFixture]
		public class Debug_IsInRange_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsInRange((Int32)100, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsInRange((Int32)200, (Int32)100, (Int32)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Int32)99, (Int32)100, (Int32)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Int32)201, (Int32)100, (Int32)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debug_IsInRange_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsInRange((Int64)100, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsInRange((Int64)200, (Int64)100, (Int64)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Int64)99, (Int64)100, (Int64)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Int64)201, (Int64)100, (Int64)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Int64)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debg_IsInRange_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsInRange((Double)100, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsInRange((Double)200, (Double)100, (Double)200, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Double)99, (Double)100, (Double)200, "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange((Double)201, (Double)100, (Double)200, "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(201);
				Check.That((Double)exception.UpperLimit)
					.IsEqualTo(200);
			}
		}

		[TestFixture]
		public class Debug_IsInRange_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsInRange(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsInRange(TimeSpan.FromTicks(200), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_ExceedsLowerLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
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

			[Test]
			public void Throws_ExceedsUpperLimit()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsInRange(TimeSpan.FromTicks(201), TimeSpan.FromTicks(100), TimeSpan.FromTicks(200), "name"))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(201));
				Check.That((TimeSpan)exception.UpperLimit)
					.IsEqualTo(TimeSpan.FromTicks(200));
			}
		}
	}
}
