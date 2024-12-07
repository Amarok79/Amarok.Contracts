// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class ArraySegment_Array_Count
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2)).DoesNotThrow();
        }

        [Test]
        public void ThrowsForNull()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment((Byte[])null, 0))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("array");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void ThrowsForNegativeCount()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], -1))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 3))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }
    }

    [TestFixture]
    public class ArraySegment_Array_Offset_Count
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 2)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 3)).ThrowsAny();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 2)).ThrowsAny();

            Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2, 0)).ThrowsAny();
        }

        [Test]
        public void ThrowsForNull()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment((Byte[])null, 0, 0))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("array");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void ThrowsForNegativeOffset()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], -1, 0))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("offset");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForNegativeCount()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, -1))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForOffsetTooBig()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 2, 0))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("offset");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(2);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }

        [Test]
        public void ThrowsForCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 0, 3))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }

        [Test]
        public void ThrowsForOffsetPlusCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.ArraySegment(new Byte[2], 1, 2))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }
    }

    [TestFixture]
    public class Debug_ArraySegment_Array_Count
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2)).DoesNotThrow();
        }

        [Test]
        public void ThrowsForNull()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment((Byte[])null, 0))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("array");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void ThrowsForNegativeCount()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], -1))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 3))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }
    }

    [TestFixture]
    public class Debug_ArraySegment_Array_Offset_Count
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 2)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 3)).ThrowsAny();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 0)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 1)).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 2)).ThrowsAny();

            Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2, 0)).ThrowsAny();
        }

        [Test]
        public void ThrowsForNull()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment((Byte[])null, 0, 0))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("array");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void ThrowsForNegativeOffset()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], -1, 0))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("offset");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForNegativeCount()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, -1))
                .Throws<ArgumentOutOfRangeException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsPositive);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(-1);
        }

        [Test]
        public void ThrowsForOffsetTooBig()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 2, 0))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("offset");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(2);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }

        [Test]
        public void ThrowsForCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 0, 3))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }

        [Test]
        public void ThrowsForOffsetPlusCountTooBig()
        {
            var exception = Check.ThatCode(() => Verify.Debug.ArraySegment(new Byte[2], 1, 2))
                .Throws<ArgumentExceedsUpperLimitException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentIsLessThan);

            Check.That(exception.ParamName).IsEqualTo("count");

            Check.That(exception.InnerException).IsNull();

            Check.That((Int32)exception.ActualValue).IsEqualTo(3);

            Check.That((Int32)exception.UpperLimit).IsEqualTo(2);
        }
    }
}
