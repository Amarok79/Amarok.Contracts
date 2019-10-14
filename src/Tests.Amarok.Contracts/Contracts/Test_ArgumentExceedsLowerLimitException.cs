/* Copyright(c) 2019, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	[TestFixture, SetUICulture("en")]
	public class Test_ArgumentExceedsLowerLimitException
	{
		public class Construction
		{
			[Test]
			public void Succeed_With_DefaultConstructor()
			{
				// arrange
				var exception = new ArgumentExceedsLowerLimitException();

				// assert
				Check.That(exception.Message)
					.Contains("Specified argument was out of the range of valid values.");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That(exception.ParamName)
					.IsNull();
				Check.That(exception.ActualValue)
					.IsNull();
				Check.That(exception.LowerLimit)
					.IsNull();
			}

			[Test]
			public void Succeed_With_ParamName()
			{
				// arrange
				var exception = new ArgumentExceedsLowerLimitException("PARAM");

				// assert
				Check.That(exception.Message)
					.Contains(
						"Specified argument was out of the range of valid values.",
						"PARAM");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That(exception.ParamName)
					.IsEqualTo("PARAM");
				Check.That(exception.ActualValue)
					.IsNull();
				Check.That(exception.LowerLimit)
					.IsNull();
			}

			[Test]
			public void Succeed_With_MessageInnerException()
			{
				// arrange
				var inner = new ApplicationException();
				var exception = new ArgumentExceedsLowerLimitException("MSG", inner);

				// assert
				Check.That(exception.Message)
					.Contains("MSG");
				Check.That(exception.InnerException)
					.IsSameReferenceAs(inner);
				Check.That(exception.ParamName)
					.IsNull();
				Check.That(exception.ActualValue)
					.IsNull();
				Check.That(exception.LowerLimit)
					.IsNull();
			}

			[Test]
			public void Succeed_With_ParamNameMessage()
			{
				// arrange
				var exception = new ArgumentExceedsLowerLimitException("PARAM", "MSG");

				// assert
				Check.That(exception.Message)
					.Contains(
						"MSG",
						"PARAM");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That(exception.ParamName)
					.IsEqualTo("PARAM");
				Check.That(exception.ActualValue)
					.IsNull();
				Check.That(exception.LowerLimit)
					.IsNull();
			}

			[Test]
			public void Succeed_With_ParamNameValueLimitMessage()
			{
				// arrange
				var exception = new ArgumentExceedsLowerLimitException("PARAM", 123, 100, "MSG");

				// assert
				Check.That(exception.Message)
					.Contains(
						"MSG",
						"PARAM",
						"Actual value was 123.",
						"Lower limit: 100");
				Check.That(exception.InnerException)
					.IsNull();
				Check.That(exception.ParamName)
					.IsEqualTo("PARAM");
				Check.That(exception.ActualValue)
					.IsEqualTo(123);
				Check.That(exception.LowerLimit)
					.IsEqualTo(100);
			}
		}

		public class Serialization
		{
			[Test]
			public void Succeed_With_BinarySerialization()
			{
				// arrange
				var exception1 = new ArgumentExceedsLowerLimitException("PARAM", 123, 100, "MSG");
				var formatter = new BinaryFormatter();
				var stream = new MemoryStream();
				formatter.Serialize(stream, exception1);
				stream.Position = 0;
				var exception2 = (ArgumentExceedsLowerLimitException)formatter.Deserialize(stream);

				// assert
				Check.That(exception2)
					.Not.IsSameReferenceAs(exception1);
				Check.That(exception2.Message)
					.Contains(
						"MSG",
						"PARAM",
						"Actual value was 123.",
						"Lower limit: 100");
				Check.That(exception2.InnerException)
					.IsNull();
				Check.That(exception2.ParamName)
					.IsEqualTo("PARAM");
				Check.That(exception2.ActualValue)
					.IsEqualTo(123);
				Check.That(exception2.LowerLimit)
					.IsEqualTo(100);
			}

			[Test]
			public void Succeed_With_BinarySerialization_2()
			{
				// arrange
				var inner = new ApplicationException();
				var exception1 = new ArgumentExceedsLowerLimitException("MSG", inner);
				var formatter = new BinaryFormatter();
				var stream = new MemoryStream();
				formatter.Serialize(stream, exception1);
				stream.Position = 0;
				var exception2 = (ArgumentExceedsLowerLimitException)formatter.Deserialize(stream);

				// assert
				Check.That(exception2)
					.Not.IsSameReferenceAs(exception1);
				Check.That(exception2.Message)
					.Contains("MSG");
				Check.That(exception2.InnerException)
					.IsInstanceOf<ApplicationException>();
				Check.That(exception2.ParamName)
					.IsNull();
				Check.That(exception2.ActualValue)
					.IsNull();
				Check.That(exception2.LowerLimit)
					.IsNull();
			}
		}
	}
}
