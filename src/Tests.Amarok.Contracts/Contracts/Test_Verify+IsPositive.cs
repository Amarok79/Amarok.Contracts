// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class IsPositive_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsPositive(0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(Int32.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsPositive(-1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsPositive)
               .And.Contains("Negative values are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class IsPositive_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsPositive((Int64)0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive((Int64)1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(Int64.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsPositive((Int64)(-1), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class IsPositive_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsPositive(0.0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(0.1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(Double.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsPositive(-0.1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(-0.1);
        }
    }

    [TestFixture]
    public class IsPositive_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsPositive(TimeSpan.Zero, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(TimeSpan.FromMilliseconds(1), "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsPositive(TimeSpan.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsPositive(TimeSpan.FromTicks(-1), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(-1));
        }
    }


    [TestFixture]
    public class Debug_IsPositive_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsPositive(0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(Int32.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsPositive(-1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class Debug_IsPositive_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsPositive((Int64)0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive((Int64)1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(Int64.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsPositive((Int64)(-1), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class Debug_IsPositive_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsPositive(0.0, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(0.1, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(Double.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsPositive(-0.1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(-0.1);
        }
    }

    [TestFixture]
    public class Debug_IsPositive_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.Zero, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.FromMilliseconds(1), "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.MaxValue, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsPositive(TimeSpan.FromTicks(-1), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(-1));
        }
    }
}
