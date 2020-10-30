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
		public class IsPositive_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsPositive((Int32)0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive((Int32)1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive(Int32.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.IsPositive((Int32)(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive)
					.And
					.Contains("Negative values are invalid.");
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}
		}

		[TestFixture]
		public class IsPositive_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsPositive((Int64)0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive((Int64)1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive(Int64.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.IsPositive((Int64)(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(-1);
			}
		}

		[TestFixture]
		public class IsPositive_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsPositive((Double)0.0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive((Double)0.1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive(Double.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.IsPositive((Double)(-0.1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(-0.1);
			}
		}

		[TestFixture]
		public class IsPositive_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.IsPositive(TimeSpan.Zero, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive(TimeSpan.FromMilliseconds(1), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsPositive(TimeSpan.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.IsPositive(TimeSpan.FromTicks(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(-1));
			}
		}


		[TestFixture]
		public class Debug_IsPositive_Int32
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsPositive((Int32)0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive((Int32)1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive(Int32.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsPositive((Int32)(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int32)exception.ActualValue)
					.IsEqualTo(-1);
			}
		}

		[TestFixture]
		public class Debug_IsPositive_Int64
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsPositive((Int64)0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive((Int64)1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive(Int64.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsPositive((Int64)(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Int64)exception.ActualValue)
					.IsEqualTo(-1);
			}
		}

		[TestFixture]
		public class Debug_IsPositive_Double
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsPositive((Double)0.0, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive((Double)0.1, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive(Double.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsPositive((Double)(-0.1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((Double)exception.ActualValue)
					.IsEqualTo(-0.1);
			}
		}

		[TestFixture]
		public class Debug_IsPositive_TimeSpan
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.Zero, "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.FromMilliseconds(1), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.MaxValue, "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Negative()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.FromTicks(-1), "name"))
					.Throws<ArgumentOutOfRangeException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsPositive);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That((TimeSpan)exception.ActualValue)
					.IsEqualTo(TimeSpan.FromTicks(-1));
			}
		}
	}
}
