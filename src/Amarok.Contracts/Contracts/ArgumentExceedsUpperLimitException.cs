// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

using System;
using System.Runtime.Serialization;


namespace Amarok.Contracts;


/// <summary>
///     An exception that is thrown when a value exceeds the defined upper limit.
/// </summary>
[Serializable]
internal class ArgumentExceedsUpperLimitException : ArgumentOutOfRangeException
{
    #region ++ Public Interface ++

    /// <summary>
    ///     Gets the upper limit that has been exceeded.
    /// </summary>
    public Object? UpperLimit { get; }

    /// <summary>
    ///     Gets the error message and the string representation of the invalid argument value.
    /// </summary>
    public override String Message
    {
        get
        {
            var msg = base.Message;

            if (UpperLimit != null && msg != null)
            {
                msg = msg + Environment.NewLine + ExceptionResources.UpperLimit + UpperLimit;
            }

            return msg!;
        }
    }


    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    public ArgumentExceedsUpperLimitException()
    {
    }

    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    /// 
    /// <param name="paramName">
    ///     The name of the parameter that caused the exception.
    /// </param>
    public ArgumentExceedsUpperLimitException(String paramName)
        : base(paramName)
    {
    }

    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    /// 
    /// <param name="message">
    ///     The error message that explains the reason for the exception.
    /// </param>
    /// <param name="innerException">
    ///     The exception that is the cause of the current exception.
    /// </param>
    public ArgumentExceedsUpperLimitException(String message, Exception innerException)
        : base(message, innerException)
    {
    }

    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    /// 
    /// <param name="paramName">
    ///     The name of the parameter that caused the exception.
    /// </param>
    /// <param name="message">
    ///     The error message that explains the reason for the exception.
    /// </param>
    public ArgumentExceedsUpperLimitException(String paramName, String message)
        : base(paramName, message)
    {
    }

    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    /// 
    /// <param name="paramName">
    ///     The name of the parameter that caused the exception.
    /// </param>
    /// <param name="actualValue">
    ///     The value of the argument that causes this exception.
    /// </param>
    /// <param name="upperLimit">
    ///     The upper limit that the value exceeded.
    /// </param>
    /// <param name="message">
    ///     The error message that explains the reason for the exception.
    /// </param>
    public ArgumentExceedsUpperLimitException(
        String paramName,
        Object actualValue,
        Object upperLimit,
        String message
    )
        : base(paramName, actualValue, message)
    {
        UpperLimit = upperLimit;
    }

    #endregion

    #region ++ Serialization Interface ++

    /// <summary>
    ///     Initializes a new instance.
    /// </summary>
    /// 
    /// <param name="info">
    ///     The object that holds the serialized object data.
    /// </param>
    /// <param name="context">
    ///     The contextual information about the source or destination.
    /// </param>
    protected ArgumentExceedsUpperLimitException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        UpperLimit = info.GetValue("UpperLimit", typeof(Object));
    }

    /// <summary>
    ///     The method sets the SerializationInfo with information about the exception.
    /// </summary>
    /// 
    /// <param name="info">
    ///     The object that holds the serialized object data.
    /// </param>
    /// <param name="context">
    ///     The contextual information about the source or destination.
    /// </param>
    /// 
    /// <exception cref="System.ArgumentNullException">
    ///     The info parameter is a null reference (Nothing in Visual Basic).
    /// </exception>
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);

        info.AddValue("UpperLimit", UpperLimit, typeof(Object));
    }

    #endregion
}
