// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class IsInRange_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsInRange(100, 100, 200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsInRange(200, 100, 200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(99, 100, 200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message)
                .StartsWith(ExceptionResources.ArgumentIsGreaterThan)
                .And.Contains("Values exceeding the inclusive lower limit are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(99);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(201, 100, 200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(201);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class IsInRange_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsInRange(100, 100, (Int64)200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsInRange(200, 100, (Int64)200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(99, 100, (Int64)200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(99);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(201, 100, (Int64)200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(201);

            Check.That((Int64)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class IsInRange_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsInRange(100, 100, (Double)200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.IsInRange(200, 100, (Double)200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(99, 100, (Double)200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(99);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.IsInRange(201, 100, (Double)200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(201);

            Check.That((Double)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class IsInRange_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.IsInRange(
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .DoesNotThrow();

            Check.ThatCode(
                    () => Verify.IsInRange(
                        TimeSpan.FromTicks(200),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(
                    () => Verify.IsInRange(
                        TimeSpan.FromTicks(99),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(99));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(
                    () => Verify.IsInRange(
                        TimeSpan.FromTicks(201),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(201));

            Check.That((TimeSpan)exception.UpperLimit).IsEqualTo(TimeSpan.FromTicks(200));
        }
    }

    [TestFixture]
    public class Debug_IsInRange_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsInRange(100, 100, 200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsInRange(200, 100, 200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(99, 100, 200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(99);

            Check.That((Int32)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(201, 100, 200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(201);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class Debug_IsInRange_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsInRange(100, 100, (Int64)200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsInRange(200, 100, (Int64)200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(99, 100, (Int64)200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(99);

            Check.That((Int64)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(201, 100, (Int64)200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int64)exception.ActualValue).IsEqualTo(201);

            Check.That((Int64)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class Debg_IsInRange_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsInRange(100, 100, (Double)200, "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsInRange(200, 100, (Double)200, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(99, 100, (Double)200, "name"))
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(99);

            Check.That((Double)exception.LowerLimit).IsEqualTo(100);
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInRange(201, 100, (Double)200, "name"))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((Double)exception.ActualValue).IsEqualTo(201);

            Check.That((Double)exception.UpperLimit).IsEqualTo(200);
        }
    }

    [TestFixture]
    public class Debug_IsInRange_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.Debug.IsInRange(
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .DoesNotThrow();

            Check.ThatCode(
                    () => Verify.Debug.IsInRange(
                        TimeSpan.FromTicks(200),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .DoesNotThrow();
        }

        [Test]
        public void Throws_ExceedsLowerLimit()
        {
            var exception = Check.ThatCode(
                    () => Verify.Debug.IsInRange(
                        TimeSpan.FromTicks(99),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .Throws<ArgumentExceedsLowerLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsGreaterThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(99));

            Check.That((TimeSpan)exception.LowerLimit).IsEqualTo(TimeSpan.FromTicks(100));
        }

        [Test]
        public void Throws_ExceedsUpperLimit()
        {
            var exception = Check.ThatCode(
                    () => Verify.Debug.IsInRange(
                        TimeSpan.FromTicks(201),
                        TimeSpan.FromTicks(100),
                        TimeSpan.FromTicks(200),
                        "name"
                    )
                )
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();

            Check.That((TimeSpan)exception.ActualValue).IsEqualTo(TimeSpan.FromTicks(201));

            Check.That((TimeSpan)exception.UpperLimit).IsEqualTo(TimeSpan.FromTicks(200));
        }
    }
}
