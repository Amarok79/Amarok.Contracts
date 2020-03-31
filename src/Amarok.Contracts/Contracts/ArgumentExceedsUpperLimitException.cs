/* MIT License
 * 
 * Copyright (c) 2020, Olaf Kober
 * https://github.com/Amarok79/Amarok.Contracts
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;


namespace Amarok.Contracts
{
	/// <summary>
	/// An exception that is thrown when a value exceeds the defined upper limit.
	/// </summary>
	[Serializable]
	public class ArgumentExceedsUpperLimitException : ArgumentOutOfRangeException
	{
		#region ++ Public Interface ++

		/// <summary>
		/// Gets the upper limit that has been exceeded.
		/// </summary>
		public Object? UpperLimit { get; }

		/// <summary>
		/// Gets the error message and the string representation of the invalid argument value.
		/// </summary>
		public override String Message
		{
			get
			{
				String msg = base.Message;
				if (this.UpperLimit != null && msg != null)
					msg = msg + Environment.NewLine + ExceptionResources.UpperLimit + this.UpperLimit;
				return msg!;
			}
		}


		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		public ArgumentExceedsUpperLimitException()
		{
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		/// 
		/// <param name="paramName">
		/// The name of the parameter that caused the exception.</param>
		public ArgumentExceedsUpperLimitException(String paramName)
			: base(paramName)
		{
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		/// 
		/// <param name="message">
		/// The error message that explains the reason for the exception.</param>
		/// <param name="innerException">
		/// The exception that is the cause of the current exception.</param>
		public ArgumentExceedsUpperLimitException(String message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		/// 
		/// <param name="paramName">
		/// The name of the parameter that caused the exception.</param>
		/// <param name="message">
		/// The error message that explains the reason for the exception.</param>
		public ArgumentExceedsUpperLimitException(String paramName, String message)
			: base(paramName, message)
		{
		}

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		/// 
		/// <param name="paramName">
		/// The name of the parameter that caused the exception.</param>
		/// <param name="actualValue">
		/// The value of the argument that causes this exception.</param>
		/// <param name="upperLimit">
		/// The upper limit that the value exceeded.</param>
		/// <param name="message">
		/// The error message that explains the reason for the exception.</param>
		public ArgumentExceedsUpperLimitException(String paramName, Object actualValue, Object upperLimit, String message)
			: base(paramName, actualValue, message)
		{
			this.UpperLimit = upperLimit;
		}

		#endregion

		#region ++ Serialization Interface ++

		/// <summary>
		/// Initializes a new instance.
		/// </summary>
		/// 
		/// <param name="info">
		/// The object that holds the serialized object data.</param>
		/// <param name="context">
		/// The contextual information about the source or destination.</param>
		protected ArgumentExceedsUpperLimitException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			this.UpperLimit = info.GetValue("UpperLimit", typeof(Object));
		}

		/// <summary>
		/// The method sets the SerializationInfo with information about the exception.
		/// </summary>
		/// 
		/// <param name="info">
		/// The object that holds the serialized object data.</param>
		/// <param name="context">
		/// The contextual information about the source or destination.</param>
		/// 
		/// <exception cref="System.ArgumentNullException">
		/// The info parameter is a null reference (Nothing in Visual Basic).</exception>
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);

			info.AddValue("UpperLimit", this.UpperLimit, typeof(Object));
		}

		#endregion
	}
}
