/* Copyright(c) 2019, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#define DEBUG

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public partial class Test_Verify
	{
		public class Animal
		{
		}
		public sealed class Dog : Animal
		{
		}


		[TestFixture]
		public class IsSubclassOf
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.IsSubclassOf(typeof(Dog), typeof(Animal), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.IsSubclassOf(null, typeof(Animal), "name"))
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
			public void Throws_For_NullBaseType()
			{
				var exception = Check.ThatCode(() => Verify.IsSubclassOf(typeof(Dog), null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.ParamName)
					.IsEqualTo("type");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsSubclassOf(typeof(Dog), typeof(Dog), "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsSubclassOf);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class Debug_IsSubclassOf
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.Debug.IsSubclassOf(typeof(Dog), typeof(Animal), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsSubclassOf(null, typeof(Animal), "name"))
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
			public void Throws_For_NullBaseType()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsSubclassOf(typeof(Dog), null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.ParamName)
					.IsEqualTo("type");
				Check.That(exception.InnerException)
					.IsNull();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsSubclassOf(typeof(Dog), typeof(Dog), "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsSubclassOf);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}
	}
}
