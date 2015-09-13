using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using TheBlueAlliance.Models;
using TheBlueAlliance.Properties;

namespace TheBlueAlliance
{
    public class Events
    {
        #region Event Information
        /// <summary>
        ///     Provides information for an event
        /// </summary>
        /// <param name="eventCode"></param>
        /// <returns></returns>
        public static Event.EventInformation GetEventInformation(string eventCode)
        {
            if (GetEventInformationJson(eventCode) != null)
            {
                return JsonConvert.DeserializeObject<Event.EventInformation>(GetEventInformationJson(eventCode));
            }
            return null;
        }

        private static string GetEventInformationJson(string eventCode)
        {
            var wc = new WebClient();
            wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);
            try
            {
                var url = ("http://www.thebluealliance.com/api/v2/event/" + eventCode);
                string downloadedData = wc.DownloadString(url);

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\" + eventCode + ".json"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\" + eventCode + ".json");
                }
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\" + eventCode + ".json", downloadedData);
                return downloadedData;
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
                return GetEventInformationCachedJson(eventCode);
            }
        }

        private static string GetEventInformationCachedJson(string eventCode)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\" + eventCode + ".json"))
            {
                return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventInformation\\" + eventCode + ".json");
            }
            return null;
        }

        #endregion

        #region Event Awards
        public static EventAwards.Award[] GetEventAwards(string eventCode)
        {
            if (GetEventAwardsJson(eventCode) != null)
            {
                return JsonConvert.DeserializeObject<List<EventAwards.Award>>(GetEventAwardsJson(eventCode)).ToArray();
            }
            return null;
        }

        private static string GetEventAwardsJson(string eventCode)
        {
            try
            {
                var wc = new WebClient();
                wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);

                var url = ("http://www.thebluealliance.com/api/v2/event/" + eventCode + "/awards");
                string downloadedData = wc.DownloadString(url);
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\" + eventCode + ".json"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\" + eventCode + ".json");
                }
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\");
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\" + eventCode + ".json", downloadedData);
                return downloadedData;
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
                return GetEventAwardsCachedJson(eventCode);
            }
        }

        private static string GetEventAwardsCachedJson(string eventCode)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\" + eventCode + ".json"))
            {
                return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Cache\\TBA\\Events\\EventAwards\\" + eventCode + ".json");
            }
            return null;
        }
        #endregion

        public static EventMatches.Match[] GetEventMatches(string eventKey)
        {
            var dataList = new List<EventMatches.Match>();
            var eventMatchesToReturn = dataList.ToArray();
            var wc = new WebClient();
            wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);
            try
            {
                var url = ("http://www.thebluealliance.com/api/v2/event/" + eventKey + "/matches");
                dataList = JsonConvert.DeserializeObject<List<EventMatches.Match>>(wc.DownloadString(url));
                eventMatchesToReturn = dataList.ToArray();
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
            }
            return eventMatchesToReturn;
        }

        public static EventRankings.Team[] GetEventRankings(string eventKey)
        {
            var teamList = new List<EventRankings.Team>();

            var wc = new WebClient();
            wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);

            try
            {
                var url = ("http://www.thebluealliance.com/api/v2/event/" + eventKey + "/rankings");
                var dataList = JsonConvert.DeserializeObject<List<List<object>>>(wc.DownloadString(url));

                for (var i = 1; i < dataList.Count; i++)
                {
                    var teamToAdd = new EventRankings.Team
                    {
                        Rank = Convert.ToInt32(dataList.ToArray()[i][0]),
                        Team_Number = Convert.ToInt32(dataList.ToArray()[i][1]),
                        Qual_Average = Convert.ToDouble(dataList.ToArray()[i][2]),
                        Auto = Convert.ToInt32(dataList.ToArray()[i][3]),
                        Container = Convert.ToInt32(dataList.ToArray()[i][4]),
                        Coopertition = Convert.ToInt32(dataList.ToArray()[i][5]),
                        Litter = Convert.ToInt32(dataList.ToArray()[i][6]),
                        Tote = Convert.ToInt32(dataList.ToArray()[i][7]),
                        Played = Convert.ToInt32(dataList.ToArray()[i][8])
                    };
                    teamList.Add(teamToAdd);
                }
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
            }
            return teamList.ToArray();
        }

        public static Models.Events.Event[] GetEvents(int year)
        {
            var dataList = new List<Models.Events.Event>();
            var wc = new WebClient();
            wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);
            try
            {
                var url = ("http://www.thebluealliance.com/api/v2/events/" + year);
                dataList = JsonConvert.DeserializeObject<List<Models.Events.Event>>(wc.DownloadString(url));
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
            }
            return dataList.ToArray();
        }

        public static EventTeams.Team[] GetEventTeamsList(string eventKey)
        {
            var teamList = new List<EventTeams.Team>();
            var wc = new WebClient();
            wc.Headers.Add("X-TBA-App-Id", Settings.Default.Header_Address + Assembly.GetExecutingAssembly().GetName().Version);
            try
            {
                var url = ("http://www.thebluealliance.com/api/v2/event/" + eventKey + "/teams");
                teamList = JsonConvert.DeserializeObject<List<EventTeams.Team>>(wc.DownloadString(url));
            }
            catch (Exception webError)
            {
                Console.WriteLine("Error Message: " + webError.Message);
            }
            return teamList.ToArray();
        }
    }
}