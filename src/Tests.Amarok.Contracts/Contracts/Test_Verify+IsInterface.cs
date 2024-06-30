// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


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
