//-----------------------------------------------------------------------
// <copyright file="ActorSortingModel.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace MovieCharacters.Core.Models
{
    public class ActorSortingModel : IEquatable<ActorSortingModel>
    {
        public ActorSortingModel(string name, string character, string movie)
        {
            Name = name;
            Character = character;
            Movie = movie;
        }

        public string Name { get; }

        public string Character { get; }

        public string Movie { get; }

        public bool Equals(ActorSortingModel other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Name.Equals(other.Name) && Character.Equals(other.Character) && Movie.Equals(other.Movie);
        }

        public override int GetHashCode()
        {
            var hashName = string.IsNullOrEmpty(Name) ? 0 : Name.GetHashCode();
            var hashCharacter = string.IsNullOrEmpty(Character) ? 0 : Character.GetHashCode();
            var hashMovie = string.IsNullOrEmpty(Movie) ? 0 : Movie.GetHashCode();

            return hashName ^ hashCharacter ^ hashMovie;
        }
    }
}
