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
		public class IsValid_Array_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsValid(new Byte[2], 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsValid(new Byte[2], 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsValid(new Byte[2], 2))
					.DoesNotThrow();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.IsValid((Byte[])null, 0))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("array");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void ThrowsForNegativeCount()
			{
				var exception = Check.ThatCode(() => Verify.IsValid(new Byte[2], -1))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("count");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}

			[Test]
			public void ThrowsForCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.IsValid(new Byte[2], 3))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("count");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(3);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(2);
			}
		}

		[TestFixture]
		public class Debug_IsValid_Array_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsValid(new Byte[2], 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsValid(new Byte[2], 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsValid(new Byte[2], 2))
					.DoesNotThrow();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsValid((Byte[])null, 0))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentNull);
				Check.That(exception.ParamName)
					.IsEqualTo("array");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void ThrowsForNegativeCount()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsValid(new Byte[2], -1))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("count");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}

			[Test]
			public void ThrowsForCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsValid(new Byte[2], 3))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("count");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(3);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(2);
			}
		}
	}
}
