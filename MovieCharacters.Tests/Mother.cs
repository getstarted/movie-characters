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

        public static string MovieListingSample1 => "[{\"name\":\"The Blues Brothers\","
            + "\"roles\":[{\"name\":\"Jake Blues\",\"actor\":\"John Belushi\"}]}," 
            + "{\"name\":\"Animal House\",\"roles\":[{\"name\":\"John Blutarsky\",\"actor\":\"John Belushi\"}]}]";

        public static string MovieListingSample2 =>
            "[{\"name\":\"Beverly Hills Cop\",\"roles\":[{\"name\":\"Axel Foley\",\"actor\":\"Eddie Murphy\"}]},"
            + "{\"name\":\"Stand By Me\",\"roles\":[{\"name\":\"Gorgie Lachance\",\"actor\":\"Wil Wheaton\"}]},"
            + "{\"name\":\"Star Trek\",\"roles\":[{\"name\":\"Romulan\",\"actor\":\"Wil Wheaton\"}]}]";

        public static string MovieListingSample3 =>
            "[{\"name\":\"Star Trek\",\"roles\":[{\"name\":\"Romulan\",\"actor\":\"Wil Wheaton\"}]}," 
            + "{\"name\":\"Stand By Me\",\"roles\":[{\"name\":\"Gorgie Lachance\",\"actor\":\"Wil Wheaton\"}]}]";

        public static string MovieListingSample4 =>
            "[{\"name\":\"Star Trek\",\"roles\":[{\"name\":\"Romulan\",\"actor\":\"Wil Wheaton\"}]},"
            + "{\"name\":\"\",\"roles\":[{\"name\":\"Gorgie Lachance\",\"actor\":\"Wil Wheaton\"}]}]";

        public static string MovieListingSample5 =>
            "[{\"name\":\"Star Trek\",\"roles\":[{\"name\":\"Romulan\",\"actor\":\"Wil Wheaton\"}]},"
            + "{\"name\":\"Stand By Me\",\"roles\":[{\"name\":\"\",\"actor\":\"Wil Wheaton\"}]}]";

        public static string MovieListingSample6 =>
            "[{\"name\":\"Star Trek\",\"roles\":[{\"name\":\"Romulan\",\"actor\":\"Wil Wheaton\"}]},"
            + "{\"name\":\"Stand By Me\",\"roles\":[{\"name\":\"Gorgie Lachance\",\"actor\":\"\"}]}]";
    }
}