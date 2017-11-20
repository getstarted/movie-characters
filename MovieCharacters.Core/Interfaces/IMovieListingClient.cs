//-----------------------------------------------------------------------
// <copyright file="IMovieListingClient.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using MovieCharacters.Core.Models;
using System.Collections.Generic;

namespace MovieCharacters.Core.Interfaces
{
    /// <summary>
    /// Interface to retrieve a movie listing
    /// </summary>
    public interface IMovieListingClient
    {
        /// <summary>
        /// Gets the movie list.
        /// </summary>
        /// <returns>A list of movies</returns>
        List<Movie> GetMovieList();
    }
}