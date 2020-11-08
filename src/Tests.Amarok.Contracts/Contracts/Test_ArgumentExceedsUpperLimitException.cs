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

#pragma warning disable S2187 // TestCases should contain tests

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
    [TestFixture, SetUICulture("en")]
    public class Test_ArgumentExceedsUpperLimitException
    {
        public class Construction
        {
            [Test]
            public void Succeed_With_DefaultConstructor()
            {
                // arrange
                var exception = new ArgumentExceedsUpperLimitException();

                // assert
                Check.That(exception.Message).Contains("Specified argument was out of the range of valid values.");
                Check.That(exception.InnerException).IsNull();
                Check.That(exception.ParamName).IsNull();
                Check.That(exception.ActualValue).IsNull();
                Check.That(exception.UpperLimit).IsNull();
            }

            [Test]
            public void Succeed_With_ParamName()
            {
                // arrange
                var exception = new ArgumentExceedsUpperLimitException("PARAM");

                // assert
                Check.That(exception.Message)
                     .Contains("Specified argument was out of the range of valid values.", "PARAM");

                Check.That(exception.InnerException).IsNull();
                Check.That(exception.ParamName).IsEqualTo("PARAM");
                Check.That(exception.ActualValue).IsNull();
                Check.That(exception.UpperLimit).IsNull();
            }

            [Test]
            public void Succeed_With_MessageInnerException()
            {
                // arrange
                var inner     = new ApplicationException();
                var exception = new ArgumentExceedsUpperLimitException("MSG", inner);

                // assert
                Check.That(exception.Message).Contains("MSG");
                Check.That(exception.InnerException).IsSameReferenceAs(inner);
                Check.That(exception.ParamName).IsNull();
                Check.That(exception.ActualValue).IsNull();
                Check.That(exception.UpperLimit).IsNull();
            }

            [Test]
            public void Succeed_With_ParamNameMessage()
            {
                // arrange
                var exception = new ArgumentExceedsUpperLimitException("PARAM", "MSG");

                // assert
                Check.That(exception.Message).Contains("MSG", "PARAM");
                Check.That(exception.InnerException).IsNull();
                Check.That(exception.ParamName).IsEqualTo("PARAM");
                Check.That(exception.ActualValue).IsNull();
                Check.That(exception.UpperLimit).IsNull();
            }

            [Test]
            public void Succeed_With_ParamNameValueLimitMessage()
            {
                // arrange
                var exception = new ArgumentExceedsUpperLimitException("PARAM", 123, 100, "MSG");

                // assert
                Check.That(exception.Message).Contains("MSG", "PARAM", "Actual value was 123.", "Upper limit: 100");
                Check.That(exception.InnerException).IsNull();
                Check.That(exception.ParamName).IsEqualTo("PARAM");
                Check.That(exception.ActualValue).IsEqualTo(123);
                Check.That(exception.UpperLimit).IsEqualTo(100);
            }
        }

        public class Serialization
        {
            [Test]
            public void Succeed_With_BinarySerialization()
            {
                // arrange
                var exception1 = new ArgumentExceedsUpperLimitException("PARAM", 123, 100, "MSG");
                var formatter  = new BinaryFormatter();
                var stream     = new MemoryStream();
                formatter.Serialize(stream, exception1);
                stream.Position = 0;
                var exception2 = (ArgumentExceedsUpperLimitException) formatter.Deserialize(stream);

                // assert
                Check.That(exception2).Not.IsSameReferenceAs(exception1);
                Check.That(exception2.Message).Contains("MSG", "PARAM", "Actual value was 123.", "Upper limit: 100");
                Check.That(exception2.InnerException).IsNull();
                Check.That(exception2.ParamName).IsEqualTo("PARAM");
                Check.That(exception2.ActualValue).IsEqualTo(123);
                Check.That(exception2.UpperLimit).IsEqualTo(100);
            }

            [Test]
            public void Succeed_With_BinarySerialization_2()
            {
                // arrange
                var inner      = new ApplicationException();
                var exception1 = new ArgumentExceedsUpperLimitException("MSG", inner);
                var formatter  = new BinaryFormatter();
                var stream     = new MemoryStream();
                formatter.Serialize(stream, exception1);
                stream.Position = 0;
                var exception2 = (ArgumentExceedsUpperLimitException) formatter.Deserialize(stream);

                // assert
                Check.That(exception2).Not.IsSameReferenceAs(exception1);
                Check.That(exception2.Message).Contains("MSG");
                Check.That(exception2.InnerException).IsInstanceOf<ApplicationException>();
                Check.That(exception2.ParamName).IsNull();
                Check.That(exception2.ActualValue).IsNull();
                Check.That(exception2.UpperLimit).IsNull();
            }
        }
    }
}
