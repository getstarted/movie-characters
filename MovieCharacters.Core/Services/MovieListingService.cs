//-----------------------------------------------------------------------
// <copyright file="MovieListingService.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using MovieCharacters.Core.Interfaces;
using MovieCharacters.Core.Models;
using System.Collections.Generic;
using System.Linq;

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
            var list = _client.GetMovieList();
            var actors = list
                .SelectMany(
                movie => movie.Roles, 
                (movie, role) => new ActorSortingModel()
                {
                    Character = role.Name,
                    Movie = movie.Name,
                    Name = role.Actor
                }).ToList();

            var sortedList = actors
                .OrderBy(a => a.Name)
                .GroupBy(a => a.Name)
                .Select(g => new ActorViewModel()
                {
                    ActorName = g.Key,
                    Characters = g.OrderBy(a => a.Movie)
                    .Select(b =>
                       new CharacterViewModel() { Movie = b.Movie, Name = b.Character }).ToList()
                }).ToList();

            return sortedList;
        }
    }
}