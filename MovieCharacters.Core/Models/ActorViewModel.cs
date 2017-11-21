//-----------------------------------------------------------------------
// <copyright file="ActorViewModel.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace MovieCharacters.Core.Models
{
    public class ActorViewModel
    {
        public string ActorName { get; set; }

        public List<CharacterViewModel> Characters { get; set; }
    }
}
