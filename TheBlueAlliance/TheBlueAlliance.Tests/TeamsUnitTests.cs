using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBlueAlliance.Models;

namespace TheBlueAlliance.Test
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
        public void GetTeamEventMatchesTest()
        {

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

        }

        [TestMethod]
        public void GetTeamInformationTest()
        {
        }

        [TestMethod]
        public void GetTeamMediaLocationsTest()
        {
        }
    }
}