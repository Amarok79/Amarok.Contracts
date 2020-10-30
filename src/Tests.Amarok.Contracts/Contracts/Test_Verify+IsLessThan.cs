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

#pragma warning disable S1905 // Redundant casts should not be used

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
					.StartsWith(ExceptionResources.ArgumentIsLessThan)
					.And
					.Contains("Values exceeding the inclusive upper limit are invalid.");
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
