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
