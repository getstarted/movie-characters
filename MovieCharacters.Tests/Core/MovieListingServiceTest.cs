//-----------------------------------------------------------------------
// <copyright file="MovieListingServiceTest.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieCharacters.Core.Clients;
using MovieCharacters.Core.Services;

namespace MovieCharacters.Tests.Core
{
    [TestClass]
    public class MovieListingServiceTest
    {
        [TestMethod]
        public void SortSampleList1_SingleActorTwoMovies()
        {
            CheckItem(Mother.MovieListingSample1, "John Belushi", "John Blutarsky", "Animal House");
        }

        [TestMethod]
        public void SortSampleList2_MultipleActors()
        {
            CheckItem(Mother.MovieListingSample2, "Eddie Murphy", "Axel Foley", "Beverly Hills Cop");
        }

        [TestMethod]
        public void SortSampleList3_SingleActorTwoMovies()
        {
            CheckItem(Mother.MovieListingSample3, "Wil Wheaton", "Gorgie Lachance", "Stand By Me");
        }

        [TestMethod]
        public void SortSampleList4_SingleActorEmptyMovieName()
        {
            CheckItem(Mother.MovieListingSample4, "Wil Wheaton", "Gorgie Lachance", string.Empty);
        }

        [TestMethod]
        public void SortSampleList5_SingleActorEmptyCharacterName()
        {
            CheckItem(Mother.MovieListingSample5, "Wil Wheaton", string.Empty, "Stand By Me");
        }

        [TestMethod]
        public void SortSampleList6_EmptyActorName()
        {
            CheckItem(Mother.MovieListingSample6, string.Empty, "Gorgie Lachance", "Stand By Me");
        }

        [TestMethod]
        private void CheckItem(string sampleList, string firstActorName, string firstCharacterName, string firstMovieName)
        {
            var client = new LocalStaticClient(sampleList);
            var movieListingService = new MovieListingService(client);
            var sortedList = movieListingService.GetSortedList();
            var firstActor = sortedList.ToList().FirstOrDefault();

            Assert.IsNotNull(firstActor, "The first actor should not be null");

            var firstCharacter = firstActor.Characters.FirstOrDefault();

            Assert.IsNotNull(firstCharacter, "The first character should not be null");

            Assert.AreEqual(firstCharacterName, firstCharacter.Name, "The first character does not match.");
            Assert.AreEqual(firstActorName, firstActor.ActorName, "The first actor does not match.");
            Assert.AreEqual(firstMovieName, firstCharacter.Movie, "The first movie does not match.");
        }
    }
}
