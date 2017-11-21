//-----------------------------------------------------------------------
// <copyright file="CharacterViewModel.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MovieCharacters.Core.Models
{
    /// <summary>
    /// The character in a movie
    /// </summary>
    public class CharacterViewModel
    {
        /// <summary>
        /// Gets or sets the name of the character.
        /// </summary>
        /// <value>
        /// The name of the character.
        /// </value>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the movie.
        /// </summary>
        /// <value>
        /// The movie name.
        /// </value>
        public string Movie { get; set; }
    }
}
