//-----------------------------------------------------------------------
// <copyright file="LocalStaticClient.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using MovieCharacters.Core.Interfaces;
using MovieCharacters.Core.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieCharacters.Core.Clients
{
    /// <summary>
    /// A client to deal with a static version of movie listing
    /// </summary>
    /// <seealso cref="MovieCharacters.Core.Interfaces.IMovieListingClient" />
    public class LocalStaticClient : IMovieListingClient
    {
        private readonly List<Movie> _movieList;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalStaticClient"/> class.
        /// </summary>
        /// <param name="json">The json string to use as a static list.</param>
        public LocalStaticClient(string json)
        {
            _movieList = JsonConvert.DeserializeObject<List<Movie>>(json);
        }

        /// <summary>
        /// Gets the movie list.
        /// </summary>
        /// <returns>A list of movies from a static list</returns>
        public List<Movie> GetMovieList()
        {
            return _movieList;
        }
    }
}