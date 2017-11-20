//-----------------------------------------------------------------------
// <copyright file="LocalStaticClientTest.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieCharacters.Core.Clients;

namespace MovieCharacters.Tests.Core
{
    [TestClass]
    public class LocalStaticClientTest
    {
        [TestMethod]
        public void CheckIfMoviesExistInStaticList()
        {
            var client = new LocalStaticClient(Mother.SampleJsonMovieListing);
            var movieList = client.GetMovieList();

            Assert.IsTrue(movieList.Count > 0, "No movies found in retrieved list");
        }
    }
}
