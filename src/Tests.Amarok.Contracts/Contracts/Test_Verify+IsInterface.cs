﻿/* MIT License
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
        public class IsInterface
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.IsInterface(typeof(IComparable), "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Null()
            {
                var exception = Check.ThatCode(() => Verify.IsInterface(null, "name"))
                   .Throws<ArgumentNullException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }

            [Test]
            public void Throws_For_Class()
            {
                var exception = Check.ThatCode(() => Verify.IsInterface(typeof(String), "name"))
                   .Throws<ArgumentException>()
                   .Value;

                Check.That(exception.Message)
                   .StartsWith(ExceptionResources.ArgumentIsInterface)
                   .And.Contains("Types representing concrete classes or value types are invalid.");

                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }

            [Test]
            public void Throws_For_ValueType()
            {
                var exception = Check.ThatCode(() => Verify.IsInterface(typeof(Int32), "name"))
                   .Throws<ArgumentException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsInterface);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }
        }

        [TestFixture]
        public class Debug_IsInterface
        {
            [Test]
            public void DoesNotThrow()
            {
                Check.ThatCode(() => Verify.Debug.IsInterface(typeof(IComparable), "name")).DoesNotThrow();
            }

            [Test]
            public void Throws_For_Null()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsInterface(null, "name"))
                   .Throws<ArgumentNullException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }

            [Test]
            public void Throws_For_Class()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsInterface(typeof(String), "name"))
                   .Throws<ArgumentException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsInterface);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }

            [Test]
            public void Throws_For_ValueType()
            {
                var exception = Check.ThatCode(() => Verify.Debug.IsInterface(typeof(Int32), "name"))
                   .Throws<ArgumentException>()
                   .Value;

                Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsInterface);
                Check.That(exception.ParamName).IsEqualTo("name");
                Check.That(exception.InnerException).IsNull();
            }
        }
    }
}
