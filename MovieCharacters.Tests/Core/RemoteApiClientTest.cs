//-----------------------------------------------------------------------
// <copyright file="RemoteApiClientTest.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieCharacters.Core.Clients;

namespace MovieCharacters.Tests.Core
{
    [TestClass]
    public class RemoteApiClientTest
    {
        [TestMethod]
        public void CheckIfMoviesExistFromRemoteApi()
        {
            var client = new RemoteApiClient(Mother.RemoteApiBaseUrl, Mother.RemoteApiResource);
            var movieList = client.GetMovieList();

            Assert.IsTrue(movieList.Count > 0, "No movies found in retrieved list");
        }
    }
}
