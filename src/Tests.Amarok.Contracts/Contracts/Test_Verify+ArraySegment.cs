/* MIT License
 * 
 * Copyright (c) 2020, Olaf Kober
 * https://github.com/Amarok79/Amarok.Contracts
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
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
		public class ArraySegment_Array_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2))
					.DoesNotThrow();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment((Byte[])null, 0))
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
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], -1))
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
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 3))
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
		public class ArraySegment_Array_Offset_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 2))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 3))
					.ThrowsAny();

				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 2))
					.ThrowsAny();

				Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2, 0))
					.ThrowsAny();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment((Byte[])null, 0, 0))
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
			public void ThrowsForNegativeOffset()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], -1, 0))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("offset");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}

			[Test]
			public void ThrowsForNegativeCount()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, -1))
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
			public void ThrowsForOffsetTooBig()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2, 0))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("offset");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(2);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(2);
			}

			[Test]
			public void ThrowsForCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 3))
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

			[Test]
			public void ThrowsForOffsetPlusCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 2))
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
		public class Debug_ArraySegment_Array_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2))
					.DoesNotThrow();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment((Byte[])null, 0))
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
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], -1))
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
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 3))
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
		public class Debug_ArraySegment_Array_Offset_Count
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 2))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 3))
					.ThrowsAny();

				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 0))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 1))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 2))
					.ThrowsAny();

				Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2, 0))
					.ThrowsAny();
			}

			[Test]
			public void ThrowsForNull()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment((Byte[])null, 0, 0))
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
			public void ThrowsForNegativeOffset()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], -1, 0))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("offset");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}

			[Test]
			public void ThrowsForNegativeCount()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, -1))
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
			public void ThrowsForOffsetTooBig()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2, 0))
					.Throws<ArgumentExceedsUpperLimitException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsLessThan);
				Check.That(exception.ParamName)
					.IsEqualTo("offset");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(2);
				Check.That((Int32)exception.UpperLimit)
					.IsEqualTo(2);
			}

			[Test]
			public void ThrowsForCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 3))
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

			[Test]
			public void ThrowsForOffsetPlusCountTooBig()
			{
				var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 2))
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
