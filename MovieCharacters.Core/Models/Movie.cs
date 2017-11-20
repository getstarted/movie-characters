//-----------------------------------------------------------------------
// <copyright file="Movie.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace MovieCharacters.Core.Models
{
    /// <summary>
    /// Movie details
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Gets or sets the name of the movie.
        /// </summary>
        /// <value>
        /// The name of the movie.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the roles in the movie.
        /// </summary>
        /// <value>
        /// The roles in the movie.
        /// </value>
        public List<Character> Roles { get; set; }
    }
}
