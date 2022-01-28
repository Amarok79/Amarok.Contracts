// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class IsStrictlyPositive_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyPositive(1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.IsStrictlyPositive(Int32.MaxValue, "name"))
               .DoesNotThrow();
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

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int32) exception.ActualValue)
               .IsEqualTo(0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(-1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int32) exception.ActualValue)
               .IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class IsStrictlyPositive_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) 1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.IsStrictlyPositive(Int64.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) 0, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int64) exception.ActualValue)
               .IsEqualTo(0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive((Int64) ( -1 ), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int64) exception.ActualValue)
               .IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class IsStrictlyPositive_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyPositive(0.1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.IsStrictlyPositive(Double.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(0.0, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Double) exception.ActualValue)
               .IsEqualTo(0.0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(-0.1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Double) exception.ActualValue)
               .IsEqualTo(-0.1);
        }
    }

    [TestFixture]
    public class IsStrictlyPositive_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.FromMilliseconds(1), "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.Zero, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((TimeSpan) exception.ActualValue)
               .IsEqualTo(TimeSpan.Zero);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check
               .ThatCode(() => Verify.IsStrictlyPositive(TimeSpan.FromTicks(-1), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((TimeSpan) exception.ActualValue)
               .IsEqualTo(TimeSpan.FromTicks(-1));
        }
    }


    [TestFixture]
    public class Debug_IsStrictlyPositive_Int32
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Int32.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int32) exception.ActualValue)
               .IsEqualTo(0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(-1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int32) exception.ActualValue)
               .IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyPositive_Int64
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) 1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Int64.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) 0, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int64) exception.ActualValue)
               .IsEqualTo(0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check
               .ThatCode(() => Verify.Debug.IsStrictlyPositive((Int64) ( -1 ), "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Int64) exception.ActualValue)
               .IsEqualTo(-1);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyPositive_Double
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0.1, "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(Double.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(0.0, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Double) exception.ActualValue)
               .IsEqualTo(0.0);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(-0.1, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((Double) exception.ActualValue)
               .IsEqualTo(-0.1);
        }
    }

    [TestFixture]
    public class Debug_IsStrictlyPositive_TimeSpan
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.Debug.IsStrictlyPositive(TimeSpan.FromMilliseconds(1), "name")
                )
               .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.MaxValue, "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Zero()
        {
            var exception = Check
               .ThatCode(() => Verify.Debug.IsStrictlyPositive(TimeSpan.Zero, "name"))
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((TimeSpan) exception.ActualValue)
               .IsEqualTo(TimeSpan.Zero);
        }

        [Test]
        public void Throws_For_Negative()
        {
            var exception = Check.ThatCode(
                    () => Verify.Debug.IsStrictlyPositive(TimeSpan.FromTicks(-1), "name")
                )
               .Throws<ArgumentOutOfRangeException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsStrictlyPositive);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();

            Check.That((TimeSpan) exception.ActualValue)
               .IsEqualTo(TimeSpan.FromTicks(-1));
        }
    }
}
