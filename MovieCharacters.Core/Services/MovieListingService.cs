//-----------------------------------------------------------------------
// <copyright file="MovieListingService.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using MovieCharacters.Core.Interfaces;
using MovieCharacters.Core.Models;
using System.Collections.Generic;
using System.Linq;
using MovieCharacters.Core.Exceptions;

namespace MovieCharacters.Core.Services
{
    public class MovieListingService
    {
        private readonly IMovieListingClient _client;

        public MovieListingService(IMovieListingClient client)
        {
            _client = client;
        }

        public List<ActorViewModel> GetSortedList()
        {
            List<Movie> list;

            try
            {
                list = _client.GetMovieList();
            }
            catch (Exception ex)
            {
                throw new ContentRetrievalException("Error retrieving movie list", ex);
            }

            if (list == null)
            {
                return null;
            }

            try
            {
                var actors = list
                    .SelectMany(
                        movie => movie.Roles,
                        (movie, role) => new ActorSortingModel(role.Actor, role.Name, movie.Name))
                    .Distinct()
                    .ToList();

                var sortedList = actors
                    .OrderBy(a => a.Name)
                    .GroupBy(a => a.Name)
                    .Select(g => new ActorViewModel()
                    {
                        ActorName = g.Key,
                        Characters = g.OrderBy(a => a.Movie)
                            .Select(b => new CharacterViewModel() { Movie = b.Movie, Name = b.Character })
                            .ToList()
                    })
                    .ToList();

                return sortedList;
            }
            catch (Exception ex)
            {
                throw new ListSortingException("Error sorting movie list", ex);
            }
        }
    }
}