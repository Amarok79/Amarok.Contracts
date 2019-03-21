﻿/* Copyright(c) 2019, Olaf Kober
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
		[TestFixture]
		public class IsAssignableTo
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.IsAssignableTo(typeof(Dog), typeof(Animal), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.IsAssignableTo(typeof(Dog), typeof(Dog), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.IsAssignableTo(null, typeof(Animal), "name"))
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
				var exception = Check.ThatCode(() => Verify.IsAssignableTo(typeof(Dog), null, "name"))
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
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.IsAssignableTo(typeof(Dog), typeof(Int32), "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsAssignableTo);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}

		[TestFixture]
		public class Debug_IsAssignableTo
		{
			[Test]
			public void DoesNotThrow_For_Instance()
			{
				Check.ThatCode(() => Verify.Debug.IsAssignableTo(typeof(Dog), typeof(Animal), "name"))
					.DoesNotThrow();
				Check.ThatCode(() => Verify.Debug.IsAssignableTo(typeof(Dog), typeof(Dog), "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws_For_Null()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsAssignableTo(null, typeof(Animal), "name"))
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
				var exception = Check.ThatCode(() => Verify.Debug.IsAssignableTo(typeof(Dog), null, "name"))
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
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.Debug.IsAssignableTo(typeof(Dog), typeof(Int32), "name"))
					.Throws<ArgumentException>()
					.Value;

				Check.That(exception.Message)
					.StartsWith(ExceptionResources.ArgumentIsAssignableTo);
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}
	}
}
