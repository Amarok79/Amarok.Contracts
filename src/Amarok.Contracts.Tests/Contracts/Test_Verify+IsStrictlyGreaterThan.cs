// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class IsStrictlyGreaterThan_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyGreaterThan(101, 100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(100, 100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message)
                .StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan)
                .And.Contains("Values exceeding the exclusive lower limit are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(100);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(99, 100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(99);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class IsStrictlyGreaterThan_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyGreaterThan(101, (Int64)100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(100, (Int64)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(100);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(99, (Int64)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(99);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class IsStrictlyGreaterThan_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyGreaterThan(101, (Double)100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(100, (Double)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(100);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyGreaterThan(99, (Double)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(99);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class IsStrictlyGreaterThan_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyGreaterThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name"))
                .DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(
                    () => Verify.IsStrictlyGreaterThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name")
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(100));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(
                    () => Verify.IsStrictlyGreaterThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name")
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(99));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }
    }


    [TestFixture]
    public class Debug_IsStrictlyGreaterThan_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(101, 100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(100, 100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(100);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(99, 100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(99);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyGreaterThan_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(101, (Int64)100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(100, (Int64)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(100);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(99, (Int64)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(99);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyGreaterThan_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(101, (Double)100, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(100, (Double)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(100);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyGreaterThan(99, (Double)100, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(99);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyGreaterThan_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.Debug.IsStrictlyGreaterThan(TimeSpan.FromTicks(101), TimeSpan.FromTicks(100), "name")
                )
                .DoesNotThrow();
        }

        [Test]
        public void Throws_Equal()
        {
            var exception = Check.ThatCode(
                    () => Verify.Debug.IsStrictlyGreaterThan(TimeSpan.FromTicks(100), TimeSpan.FromTicks(100), "name")
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(100));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }

        [Test]
        public void Throws_Greater()
        {
            var exception = Check.ThatCode(
                    () => Verify.Debug.IsStrictlyGreaterThan(TimeSpan.FromTicks(99), TimeSpan.FromTicks(100), "name")
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsStrictlyGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(99));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }
    }
}
