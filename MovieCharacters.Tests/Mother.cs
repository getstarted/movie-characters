//-----------------------------------------------------------------------
// <copyright file="Mother.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace MovieCharacters.Tests
{
    internal static class Mother
    {
        public static string RemoteApiBaseUrl => "http://alintacodingtest.azurewebsites.net";

        public static string RemoteApiResource => "api/Movies";

        public static string SampleJsonMovieListing => "[{\"name\":\"The Blues Brothers\",\"roles\":[{\"name\":\"Jake Blues\",\"actor\":\"John Belushi\"}]}," +
                                                       "{\"name\":\"Animal House\",\"roles\":[{\"name\":\"John Blutarsky\",\"actor\":\"John Belushi\"}]}]";
    }
}