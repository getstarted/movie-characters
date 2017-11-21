//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using MovieCharacters.Core.Clients;
using MovieCharacters.Core.Models;
using MovieCharacters.Core.Services;
using MovieCharacters.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Extensions.Options;

namespace MovieCharacters.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieListApiOptions _options;

        public HomeController(IOptions<MovieListApiOptions> movieListApiOptions)
        {
            _options = movieListApiOptions.Value;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            List<ActorViewModel> movieList;
            try
            {
                var client = new RemoteApiClient(_options.BaseUrl, _options.Resource);
                var movieListingService = new MovieListingService(client);
                movieList = movieListingService.GetSortedList();
            }
            catch (Exception ex)
            {
                movieList = null;
                ViewData["Exception"] = ex.Message;
            }

            return View(movieList);
        }
    }
}