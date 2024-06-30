// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class NotNull_Object
    {
        [Test]
        public void DoesNotThrow_For_Instance()
        {
            Check.ThatCode(() => Verify.NotNull(new Object(), "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.NotNull(123, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.NotNull(null, "name")).Throws<ArgumentNullException>().Value;

            Check.That(exception.Message)
                .StartsWith(ExceptionResources.ArgumentNull)
                .And.Contains("Null values are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }

    [TestFixture]
    public class Debug_NotNull_Object
    {
        [Test]
        public void DoesNotThrow_For_Instance()
        {
            Check.ThatCode(() => Verify.Debug.NotNull(new Object(), "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.NotNull(123, "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.Debug.NotNull(null, "name"))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }
}
