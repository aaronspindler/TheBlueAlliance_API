using System;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using TheBlueAlliance.Models;
using TheBlueAlliance.Properties;

namespace TheBlueAlliance
{
    public class Matches
    {
        public static MatchInformation_2015.Match GetMatchInformation2015(string matchKey)
        {
            if (matchKey.Substring(0, 4) != "2015") return null;
            if (GetMatchInformationJsonData(matchKey) != null)
            {
                return JsonConvert.DeserializeObject<MatchInformation_2015.Match>(GetMatchInformationJsonData(matchKey));
            }

            return null;
        }

        public static MatchInformation_2014.Match GetMatchInformation2014(string matchKey)
        {
            if (matchKey.Substring(0, 4) != "2014") return null;
            if (GetMatchInformationJsonData(matchKey) != null)
            {
                return JsonConvert.DeserializeObject<MatchInformation_2014.Match>(GetMatchInformationJsonData(matchKey));
            }

            return null;
        }

        private static string GetMatchInformationJsonData(string matchKey)
        {
            try
            {
                var wc = new WebClient();
                wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);
                var downloadedData = wc.DownloadString("http://www.thebluealliance.com/api/v2/match/" + matchKey);
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\" + matchKey + ".json"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\" + matchKey + ".json");
                }
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\" + matchKey + ".json", downloadedData);
                return downloadedData;
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
                return GetCachedMatchInformationJson(matchKey);
            }
        }

        private static string GetCachedMatchInformationJson(string matchKey)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\" + matchKey + ".json"))
            {
                return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Matches\\" + matchKey + ".json");
            }
            return null;
        }
    }
}