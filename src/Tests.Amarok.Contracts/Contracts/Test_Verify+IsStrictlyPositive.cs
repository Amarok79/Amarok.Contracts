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
        public class IsStrictlyPositive_Int32
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.IsStrictlyPositive(1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.IsStrictlyPositive(Int32.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message)
                   .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive)
                   .And.Contains("Zero or negative values are invalid.");

                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int32) exception.ActualValue).IsEqualTo(0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(-1, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int32) exception.ActualValue).IsEqualTo(-1);
            }
        }

        [TestFixture]
        public class IsStrictlyPositive_Int64
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) 1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.IsStrictlyPositive(Int64.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) 0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int64) exception.ActualValue).IsEqualTo(0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) ( -1 ), "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int64) exception.ActualValue).IsEqualTo(-1);
            }
        }

        [TestFixture]
        public class IsStrictlyPositive_Double
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.IsStrictlyPositive(0.1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.IsStrictlyPositive(Double.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(0.0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Double) exception.ActualValue).IsEqualTo(0.0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(-0.1, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Double) exception.ActualValue).IsEqualTo(-0.1);
            }
        }

        [TestFixture]
        public class IsStrictlyPositive_TimeSpan
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.FromMilliseconds(1), "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.Zero, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((TimeSpan) exception.ActualValue).IsEqualTo(TimeSpan.Zero);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.FromTicks(-1), "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((TimeSpan) exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(-1));
            }
        }


        [TestFixture]
        public class Debug_IsStrictlyPositive_Int32
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Int32.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int32) exception.ActualValue).IsEqualTo(0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(-1, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int32) exception.ActualValue).IsEqualTo(-1);
            }
        }

        [TestFixture]
        public class Debug_IsStrictlyPositive_Int64
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) 1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Int64.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) 0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int64) exception.ActualValue).IsEqualTo(0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) ( -1 ), "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Int64) exception.ActualValue).IsEqualTo(-1);
            }
        }

        [TestFixture]
        public class Debug_IsStrictlyPositive_Double
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0.1, "name")).DoesNotThrow();
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Double.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0.0, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Double) exception.ActualValue).IsEqualTo(0.0);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(-0.1, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((Double) exception.ActualValue).IsEqualTo(-0.1);
            }
        }

        [TestFixture]
        public class Debug_IsStrictlyPositive_TimeSpan
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.FromMilliseconds(1), "name"))
                   .DoesNotThrow();

                Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.MaxValue, "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Zero()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.Zero, "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((TimeSpan) exception.ActualValue).IsEqualTo(TimeSpan.Zero);
            }

            [Test]
            public void Throws_For_Negative()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.FromTicks(-1), "name"))
                   .Throws<ArgumentOutOfRangeException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
                Check.That((TimeSpan) exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(-1));
            }
        }
    }
}
