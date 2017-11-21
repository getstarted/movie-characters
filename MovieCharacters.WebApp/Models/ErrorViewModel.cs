//-----------------------------------------------------------------------
// <copyright file="ErrorViewModel.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace MovieCharacters.WebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}