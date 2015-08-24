using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBlueAlliance.Models;

namespace TheBlueAlliance.Tests
{
    [TestClass]
    public class TeamsUnitTests
    {
        [TestMethod]
        public void GetTeamEventAwardsTest()
        {
            TeamEventAwards.Award[] actualInformation = Teams.GetTeamEventAwards("frc3710", "2015onto");

            string expectedEventKey = "2015onto";
            int expectedAwardType = 1;
            string expectedName = "Regional Winners";
            int expectedRecipientNumber0 = 2056;
            int expectedRecipientNumber1 = 2852;
            int expectedRecipientNumber2 = 3710;
            int expectedYear = 2015;

            Assert.AreEqual(expectedEventKey, actualInformation[0].event_key);
            Assert.AreEqual(expectedAwardType, actualInformation[0].award_type);
            Assert.AreEqual(expectedName, actualInformation[0].name);
            Assert.AreEqual(expectedRecipientNumber0, actualInformation[0].recipient_list[0].team_number);
            Assert.AreEqual(expectedRecipientNumber1, actualInformation[0].recipient_list[1].team_number);
            Assert.AreEqual(expectedRecipientNumber2, actualInformation[0].recipient_list[2].team_number);
            Assert.AreEqual(expectedYear, actualInformation[0].year);
        }

        [TestMethod]
        public void GetTeamEventsTest()
        {
            TeamEvents.Event[] actualInformation = Teams.GetTeamEvents("frc3710", 2015);

            string expectedKey = "2015onnb";
            string expectedWebsite = "http://www.firstroboticscanada.org";
            Boolean expectedOfficial = true;
            string expectedEndDate = "2015-03-28";
            string expectedName = "North Bay Regional";
            string expectedShortName = "North Bay";
            string expectedFacebookEID = null;
            string expectedEventDistrictString = null;
            string expectedVenueAddress = "Nipissing University\n100 College Drive\nNorth Bay, ON P1B 8L7\nCanada";
            int expectedEventDistrict = 0;
            string expectedLocation = "North Bay, ON, Canada";
            string expectedEventCode = "onnb";
            int expectedYear = 2015;
            string expectedWebcastType = "livestream";
            string expectedWebcastChannel = "12312913";
            string expectedWebcastFile = "3856137";
            string expectedEventTypeString = "Regional";
            string expectedStartDate = "2015-03-25";
            int expectedEventType = 0;

            Assert.AreEqual(expectedKey, actualInformation[0].key);
            Assert.AreEqual(expectedWebsite, actualInformation[0].website);
            Assert.AreEqual(expectedOfficial, actualInformation[0].official);
            Assert.AreEqual(expectedEndDate, actualInformation[0].end_date);
            Assert.AreEqual(expectedName, actualInformation[0].name);
            Assert.AreEqual(expectedShortName, actualInformation[0].short_name);
            Assert.AreEqual(expectedFacebookEID, actualInformation[0].facebook_eid);
            Assert.AreEqual(expectedEventDistrictString, actualInformation[0].event_district_string);
            Assert.AreEqual(expectedVenueAddress, actualInformation[0].venue_address);
            Assert.AreEqual(expectedEventDistrict, actualInformation[0].event_district);
            Assert.AreEqual(expectedLocation, actualInformation[0].location);
            Assert.AreEqual(expectedEventCode, actualInformation[0].event_code);
            Assert.AreEqual(expectedYear, actualInformation[0].year);
            Assert.AreEqual(expectedWebcastType, actualInformation[0].webcast[0].type);
            Assert.AreEqual(expectedWebcastChannel, actualInformation[0].webcast[0].channel);
            Assert.AreEqual(expectedWebcastFile, actualInformation[0].webcast[0].file);
            Assert.AreEqual(expectedEventTypeString, actualInformation[0].event_type_string);
            Assert.AreEqual(expectedStartDate, actualInformation[0].start_date);
            Assert.AreEqual(expectedEventType, actualInformation[0].event_type);
        }

        [TestMethod]
        public void GetTeamHistoricalAwardsTest()
        {
            TeamHistoryAwards.Award[] actualInformation = Teams.GetTeamHistoricalAwards("frc3710");

            string expectedEventKey = "2011on2";
            int expectedAwardType = 13;
            string expectedAwardName = "Judges Award";
            int expectedRecipientTeamNumber = 3710;
            string expectedRecipientAwardee = null;
            int expectedYear = 2011;

            Assert.AreEqual(expectedEventKey, actualInformation[0].event_key);
            Assert.AreEqual(expectedAwardType, actualInformation[0].award_type);
            Assert.AreEqual(expectedAwardName, actualInformation[0].name);
            Assert.AreEqual(expectedRecipientTeamNumber, actualInformation[0].recipient_list[0].team_number);
            Assert.AreEqual(expectedRecipientAwardee, actualInformation[0].recipient_list[0].awardee);
            Assert.AreEqual(expectedYear, actualInformation[0].year);
        }

        [TestMethod]
        public void GetTeamHistoryEventsTest()
        {
            var actualEventInformation = Teams.GetTeamHistoryEvents("frc3710");

            const string expectedKey = "2011on2";
            const string expectedWebsite = "http://www.firstroboticscanada.org/site/index.php";
            const bool expectedOfficial = true;
            const string expectedEndDate = "2011-04-02";
            const string expectedName = "Greater Toronto West Regional";
            const string expectedShortName = "Greater Toronto West";
            const object expectedFaceBookEid = null;
            const object expectedEventDistrictString = null;
            const string expectedVenueAddress = "Hershey Centre\n5500 Rose Cherry Place\nMississauga, ON L4Z 3G1\nCanada";
            const int expectedEventDistrict = 0;
            const string expectedLocation = "Mississauga, ON, Canada";
            const string expectedEventCode = "on2";
            const int expectedYear = 2011;
            const string expectedEventTypeString = "Regional";
            const string expectedStartDate = "2011-03-31";
            const int expectedEventType = 0;

            Assert.AreEqual(expectedKey, actualEventInformation[0].key, "Event Keys are not as expected");
            Assert.AreEqual(expectedWebsite, actualEventInformation[0].website, "Websites are not as expected");
            Assert.AreEqual(expectedOfficial, actualEventInformation[0].official, "Is Official are not as expected");
            Assert.AreEqual(expectedEndDate, actualEventInformation[0].end_date, " are not as expected");
            Assert.AreEqual(expectedName, actualEventInformation[0].name, "Event Names are not as expected");
            Assert.AreEqual(expectedShortName, actualEventInformation[0].short_name, "Short Names are not as expected");
            Assert.AreEqual(expectedFaceBookEid, actualEventInformation[0].facebook_eid, "Facebook EID are not as expected");
            Assert.AreEqual(expectedEventDistrictString, actualEventInformation[0].event_district_string, "Event District Strings are not as expected");
            Assert.AreEqual(expectedVenueAddress, actualEventInformation[0].venue_address, "Venue Addresses are not as expected");
            Assert.AreEqual(expectedEventDistrict, actualEventInformation[0].event_district, "Event Districts are not as expected");
            Assert.AreEqual(expectedLocation, actualEventInformation[0].location, "Locations are not as expected");
            Assert.AreEqual(expectedEventCode, actualEventInformation[0].event_code, "Event Codes are not as expected");
            Assert.AreEqual(expectedYear, actualEventInformation[0].year, "Years are not as expected");
            Assert.AreEqual(expectedEventTypeString, actualEventInformation[0].event_type_string, "Event Type Strings are not as expected");
            Assert.AreEqual(expectedStartDate, actualEventInformation[0].start_date, "Start Dates are not as expected");
            Assert.AreEqual(expectedEventType, actualEventInformation[0].event_type, "Event Types are not as expected");
        }

        [TestMethod]
        public void GetTeamInformationTest()
        {
            var actualInformation = TheBlueAlliance.Teams.GetTeamInformation("frc3710");

            string expectedWebsite = "http://www.cyberfalcons.com";
            string expectedName = "Limestone Learning Foundation and Haakon Industries & Frontenac Secondary School";
            string expectedLocality = "Kingston";
            int expectedRookieYear = 2011;
            string expectedRegion = "ON";
            int expectedTeamNumber = 3710;
            string expectedLocation = "Kingston, ON, Canada";
            string expectedKey = "frc3710";
            string expectedCountryName = "Canada";
            string expectedNickname = "FSS Cyber Falcons";

            Assert.AreEqual(expectedWebsite,actualInformation.website);
            Assert.AreEqual(expectedName,actualInformation.name);
            Assert.AreEqual(expectedLocality,actualInformation.locality);
            Assert.AreEqual(expectedRookieYear,actualInformation.rookie_year);
            Assert.AreEqual(expectedRegion,actualInformation.region);
            Assert.AreEqual(expectedTeamNumber,actualInformation.team_number);
            Assert.AreEqual(expectedLocation,actualInformation.location);
            Assert.AreEqual(expectedKey,actualInformation.key);
            Assert.AreEqual(expectedCountryName,actualInformation.country_name);
            Assert.AreEqual(expectedNickname,actualInformation.nickname);
        }

        [TestMethod]
        public void GetTeamMediaLocationsTest()
        {
            var actualInformation = Teams.GetTeamMediaLocations("frc254", 2014);

            string expectedType = "cdphotothread";
            string expectedDetails = "fe3/fe38d320428adf4f51ac969efb3db32c_l.jpg";
            string expectedForeignKey = "39894";

            Assert.AreEqual(expectedType,actualInformation[0].type);
            Assert.AreEqual(expectedDetails,actualInformation[0].details.image_partial);
            Assert.AreEqual(expectedForeignKey,actualInformation[0].foreign_key);
        }
    }
}