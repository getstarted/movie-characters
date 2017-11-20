//-----------------------------------------------------------------------
// <copyright file="RemoteApiClient.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using MovieCharacters.Core.Exceptions;
using MovieCharacters.Core.Interfaces;
using MovieCharacters.Core.Models;
using RestSharp;
using System;
using System.Collections.Generic;

namespace MovieCharacters.Core.Clients
{
    /// <summary>
    /// A client to retrieve movie listings from a remote API.
    /// </summary>
    /// <seealso cref="MovieCharacters.Core.Interfaces.IMovieListingClient" />
    public class RemoteApiClient : IMovieListingClient
    {
        private readonly string _baseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteApiClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="resource">The resource.</param>
        public RemoteApiClient(string baseUrl, string resource = "")
        {
            _baseUrl = baseUrl;
            Resource = resource;
        }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        /// <value>
        /// The resource.
        /// </value>
        public string Resource { get; set; }

        /// <summary>
        /// Gets the movie list.
        /// </summary>
        /// <returns>A list of movies from the remote API</returns>
        public List<Movie> GetMovieList()
        {
            var request = new RestRequest
            {
                Resource = Resource
            };

            return Execute<List<Movie>>(request);
        }

        private T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient { BaseUrl = new Uri(_baseUrl) };

            var response = client.Execute<T>(request);

            if (response.ErrorException == null)
            {
                return response.Data;
            }

            var message = $"Error retrieving response from {_baseUrl}. Check inner details for more info.";
            throw new ContentRetrievalException(message, response.ErrorException);
        }
    }
}