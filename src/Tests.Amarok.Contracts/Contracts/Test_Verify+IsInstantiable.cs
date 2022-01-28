// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using System.IO;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class IsInstantiable
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.IsInstantiable(typeof(String), "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.IsInstantiable(typeof(Int32), "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.IsInstantiable(null, "name"))
               .Throws<ArgumentNullException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_Interface()
        {
            var exception = Check.ThatCode(() => Verify.IsInstantiable(typeof(IComparable), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable)
               .And.Contains("Types representing interface or abstract base classes are invalid.");

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_AbstractClass()
        {
            var exception = Check.ThatCode(() => Verify.IsInstantiable(typeof(Stream), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_GenericTypeDefinition()
        {
            var exception = Check.ThatCode(() => Verify.IsInstantiable(typeof(Action<>), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }
    }

    [TestFixture]
    public class Debug_IsInstantiable
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.IsInstantiable(typeof(String), "name"))
               .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.IsInstantiable(typeof(Int32), "name"))
               .DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.Debug.IsInstantiable(null, "name"))
               .Throws<ArgumentNullException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_Interface()
        {
            var exception = Check
               .ThatCode(() => Verify.Debug.IsInstantiable(typeof(IComparable), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_AbstractClass()
        {
            var exception = Check
               .ThatCode(() => Verify.Debug.IsInstantiable(typeof(Stream), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }

        [Test]
        public void Throws_For_GenericTypeDefinition()
        {
            var exception = Check
               .ThatCode(() => Verify.Debug.IsInstantiable(typeof(Action<>), "name"))
               .Throws<ArgumentException>()
               .Value;

            Check.That(exception.Message)
               .StartsWith(ExceptionResources.ArgumentIsInstantiable);

            Check.That(exception.ParamName)
               .IsEqualTo("name");

            Check.That(exception.InnerException)
               .IsNull();
        }
    }
}
