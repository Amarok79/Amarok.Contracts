// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


/// <summary>
///     This type provides static methods for argument verification.
/// </summary>
internal static partial class Verify
{
    /// <summary>
    ///     This nested type provides the same static methods for argument verification as the parent type, except that these
    ///     nested methods are all annotated with
    ///     <c>
    ///         [Conditional("DEBUG")]
    ///     </c>
    ///     , meaning these methods are only compiled into the output assembly, if the compiler define
    ///     <c>
    ///         DEBUG
    ///     </c>
    ///     is present.
    /// </summary>
    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
    }
}
