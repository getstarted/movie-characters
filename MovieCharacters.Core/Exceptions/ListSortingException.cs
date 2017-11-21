//-----------------------------------------------------------------------
// <copyright file="ListSortingException.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace MovieCharacters.Core.Exceptions
{
    /// <summary>
    /// Represents errors that occure when retrieving content
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ListSortingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSortingException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ListSortingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}