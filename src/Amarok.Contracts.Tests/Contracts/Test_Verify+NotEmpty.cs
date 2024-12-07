// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#define DEBUG

using System;
using System.Collections.Generic;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts;


public partial class Test_Verify
{
    [TestFixture]
    public class NotEmpty_String
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.NotEmpty("foo", "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.NotEmpty(" ", "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.NotEmpty(null, "name")).Throws<ArgumentNullException>().Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyString()
        {
            var exception = Check.ThatCode(() => Verify.NotEmpty(String.Empty, "name"))
                .Throws<ArgumentException>()
                .Value;

            Check.That(exception.Message)
                .StartsWith(ExceptionResources.ArgumentEmptyString)
                .And.Contains("Empty strings are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }

    [TestFixture]
    public class Debug_NotEmpty_String
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(() => Verify.Debug.NotEmpty("foo", "name")).DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.NotEmpty(" ", "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(null, "name"))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyString()
        {
            var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(String.Empty, "name"))
                .Throws<ArgumentException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentEmptyString);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }

    [TestFixture]
    public class NotEmpty_Enumerable
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.NotEmpty(
                        new[] {
                            123, 456,
                        },
                        "name"
                    )
                )
                .DoesNotThrow();

            Check.ThatCode(() => Verify.NotEmpty(_CreateNonEmptyEnumerable(), "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.NotEmpty((IEnumerable<Int32>)null, "name"))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyReadOnlyCollection()
        {
            var collection = Array.Empty<Int32>();

            var exception = Check.ThatCode(() => Verify.NotEmpty(collection, "name")).Throws<ArgumentException>().Value;

            Check.That(exception.Message)
                .StartsWith(ExceptionResources.ArgumentEmptyCollection)
                .And.Contains("Empty collections are invalid.");

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyEnumerable()
        {
            var collection = _CreateEmptyEnumerable();

            var exception = Check.ThatCode(() => Verify.NotEmpty(collection, "name")).Throws<ArgumentException>().Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentEmptyCollection);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }

    [TestFixture]
    public class Debug_NotEmpty_Enumerable
    {
        [Test]
        public void DoesNotThrow()
        {
            Check.ThatCode(
                    () => Verify.Debug.NotEmpty(
                        new[] {
                            123, 456,
                        },
                        "name"
                    )
                )
                .DoesNotThrow();

            Check.ThatCode(() => Verify.Debug.NotEmpty(_CreateNonEmptyEnumerable(), "name")).DoesNotThrow();
        }

        [Test]
        public void Throws_For_Null()
        {
            var exception = Check.ThatCode(() => Verify.Debug.NotEmpty((IEnumerable<Int32>)null, "name"))
                .Throws<ArgumentNullException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentNull);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyReadOnlyCollection()
        {
            var collection = Array.Empty<Int32>();

            var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(collection, "name"))
                .Throws<ArgumentException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentEmptyCollection);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }

        [Test]
        public void Throws_For_EmptyEnumerable()
        {
            var collection = _CreateEmptyEnumerable();

            var exception = Check.ThatCode(() => Verify.Debug.NotEmpty(collection, "name"))
                .Throws<ArgumentException>()
                .Value;

            Check.That(exception.Message).StartsWith(ExceptionResources.ArgumentEmptyCollection);

            Check.That(exception.ParamName).IsEqualTo("name");

            Check.That(exception.InnerException).IsNull();
        }
    }


    private static IEnumerable<Int32> _CreateEmptyEnumerable()
    {
        yield break;
    }

    private static IEnumerable<Int32> _CreateNonEmptyEnumerable()
    {
        yield return 123;
        yield return 456;
    }
}
