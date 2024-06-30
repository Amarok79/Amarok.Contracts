// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


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
            Check.That(exception.Message).Contains("Specified argument was out of the range of valid values.", "PARAM");

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
}
