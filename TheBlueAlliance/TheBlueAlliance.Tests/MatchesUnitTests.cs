using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheBlueAlliance.Models;

namespace TheBlueAlliance.Tests
{
    [TestClass]
    public class MatchesUnitTests
    {
        [TestMethod]
        public void GetMatchInformation2015NullTest()
        {
            var actualInformation = Matches.GetMatchInformation2015("2014cmp_f1m1");

            MatchInformation_2015.Match expectedResult = null;

            Assert.AreEqual(expectedResult, actualInformation);
        }

        [TestMethod]
        public void GetMatchInformation2014NullTest()
        {
            var actualInformation = Matches.GetMatchInformation2014("2015cmp_f1m1");

            MatchInformation_2015.Match expectedResult = null;

            Assert.AreEqual(expectedResult, actualInformation);
        }

        [TestMethod]
        public void GetMatchInformation2015Test()
        {
            var actualMatchInformation = Matches.GetMatchInformation2015("2015iri_qm43");

            var expectedCompLevel = "qm";
            var expectedMatchNumber = 43;
            string expectedTimeString = null;
            var expectedSetNumber = 1;
            var expectedKey = "2015iri_qm43";
            var expectedTime = 1437161040;

            var expectedScoreBreakdownBlue_Tote_Count_Far = 24;
            var expectedScoreBreakdownBlue_Tote_Count_Near = 14;
            var expectedScoreBreakdownBlue_container_count_level1 = 0;
            var expectedScoreBreakdownBlue_container_count_level2 = 0;
            var expectedScoreBreakdownBlue_container_count_level3 = 0;
            var expectedScoreBreakdownBlue_container_count_level4 = 0;
            var expectedScoreBreakdownBlue_container_count_level5 = 0;
            var expectedScoreBreakdownBlue_container_count_level6 = 5;
            var expectedScoreBreakdownBlue_teleop_points = 226;
            var expectedScoreBreakdownBlue_auto_points = 20;
            var expectedScoreBreakdownBlue_total_points = 280;
            var expectedScoreBreakdownBlue_tote_set = false;
            var expectedScoreBreakdownBlue_container_set = false;
            var expectedScoreBreakdownBlue_foul_count = 1;
            var expectedScoreBreakdownBlue_container_pointers = 120;
            var expectedScoreBreakdownBlue_adjust_points = 0;
            var expectedScoreBreakdownBlue_litter_count_unprocessed = 0;
            var expectedScoreBreakdownBlue_robot_set = false;
            var expectedScoreBreakdownBlue_litter_count_container = 5;
            var expectedScoreBreakdownBlue_tote_points = 76;
            var expectedScoreBreakdownBlue_foul_points = 6;
            var expectedScoreBreakdownBlue_tote_stack = true;
            var expectedScoreBreakdownBlue_litter_count_landfill = 0;
            var expectedScoreBreakdownBlue_litter_points = 30;

            var expectedCoopertition = "Stack";

            var expectedScoreBreakdownRed_Tote_Count_Far = 18;
            var expectedScoreBreakdownRed_Tote_Count_Near = 22;
            var expectedScoreBreakdownRed_container_count_level1 = 0;
            var expectedScoreBreakdownRed_container_count_level2 = 0;
            var expectedScoreBreakdownRed_container_count_level3 = 0;
            var expectedScoreBreakdownRed_container_count_level4 = 0;
            var expectedScoreBreakdownRed_container_count_level5 = 0;
            var expectedScoreBreakdownRed_container_count_level6 = 5;
            var expectedScoreBreakdownRed_teleop_points = 218;
            var expectedScoreBreakdownRed_auto_points = 28;
            var expectedScoreBreakdownRed_total_points = 286;
            var expectedScoreBreakdownRed_tote_set = false;
            var expectedScoreBreakdownRed_container_set = true;
            var expectedScoreBreakdownRed_foul_count = 0;
            var expectedScoreBreakdownRed_container_pointers = 120;
            var expectedScoreBreakdownRed_adjust_points = 0;
            var expectedScoreBreakdownRed_litter_count_unprocessed = 0;
            var expectedScoreBreakdownRed_robot_set = false;
            var expectedScoreBreakdownRed_litter_count_container = 3;
            var expectedScoreBreakdownRed_tote_points = 80;
            var expectedScoreBreakdownRed_foul_points = 0;
            var expectedScoreBreakdownRed_tote_stack = true;
            var expectedScoreBreakdownRed_litter_count_landfill = 0;
            var expectedScoreBreakdownRed_litter_points = 18;

            var expected_coopertition_points = 40;

            var expectedAlliancesBlueScore = 280;
            var expectedAlliancesBlue0 = "frc624";
            var expectedAlliancesBlue1 = "frc1619";
            var expectedAlliancesBlue2 = "frc4678";

            var expectedAlliancesRedScore = 286;
            var expectedAlliancesRed0 = "frc4143";
            var expectedAlliancesRed1 = "frc2826";
            var expectedAlliancesRed2 = "frc5413";

            var expectedEventKey = "2015iri";

            Assert.AreEqual(expectedCompLevel, actualMatchInformation.comp_level, "Comp Levels are not as expected!");
            Assert.AreEqual(expectedMatchNumber, actualMatchInformation.match_number, "Match Numbers are not as expected!");
            Assert.AreEqual(expectedTimeString, actualMatchInformation.time_string, "Time strings are not as expected!");
            Assert.AreEqual(expectedSetNumber, actualMatchInformation.set_number, "Set numbers are not as expected!");
            Assert.AreEqual(expectedKey, actualMatchInformation.key, "Keys are not as expected!");
            Assert.AreEqual(expectedTime, actualMatchInformation.time, "Times are not as expected!");

            Assert.AreEqual(expectedScoreBreakdownBlue_Tote_Count_Far, actualMatchInformation.score_breakdown.blue.tote_count_far, "Blue Tote count far is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_Tote_Count_Near, actualMatchInformation.score_breakdown.blue.tote_count_near, "Blue Tote count near is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level1, actualMatchInformation.score_breakdown.blue.container_count_level1, "Blue Container count level 1 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level2, actualMatchInformation.score_breakdown.blue.container_count_level2, "Blue Container count level 2 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level3, actualMatchInformation.score_breakdown.blue.container_count_level3, "Blue Container count level 3 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level4, actualMatchInformation.score_breakdown.blue.container_count_level4, "Blue Container count level 4 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level5, actualMatchInformation.score_breakdown.blue.container_count_level5, "Blue Container count level 5 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_count_level6, actualMatchInformation.score_breakdown.blue.container_count_level6, "Blue Container count level 6 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_teleop_points, actualMatchInformation.score_breakdown.blue.teleop_points, "Blue Teleop points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_auto_points, actualMatchInformation.score_breakdown.blue.auto_points, "Blu eAuto points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_total_points, actualMatchInformation.score_breakdown.blue.total_points, "Blue Total points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_tote_set, actualMatchInformation.score_breakdown.blue.tote_set, "Blue Tote set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_set, actualMatchInformation.score_breakdown.blue.container_set, "Blue Container set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_foul_count, actualMatchInformation.score_breakdown.blue.foul_count, "Blue Foul Count is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_container_pointers, actualMatchInformation.score_breakdown.blue.container_points, "Blue Container points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_adjust_points, actualMatchInformation.score_breakdown.blue.adjust_points, "Blue adjust points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_litter_count_unprocessed, actualMatchInformation.score_breakdown.blue.litter_count_unprocessed, "Blue litter count unprocessed is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_robot_set, actualMatchInformation.score_breakdown.blue.robot_set, "Blue robot set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_litter_count_container, actualMatchInformation.score_breakdown.blue.litter_count_container, "Blue litter count container is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_tote_points, actualMatchInformation.score_breakdown.blue.tote_points, "Blue tote points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_foul_points, actualMatchInformation.score_breakdown.blue.foul_points, "Blue foul points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_tote_stack, actualMatchInformation.score_breakdown.blue.tote_stack, "Blue tote stack is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_litter_count_landfill, actualMatchInformation.score_breakdown.blue.litter_count_landfill, "Blue litter count landfill is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownBlue_litter_points, actualMatchInformation.score_breakdown.blue.litter_points, "Blue litter points are not as expected!");

            Assert.AreEqual(expectedCoopertition, actualMatchInformation.score_breakdown.coopertition, "Coopertition is not as expected!");

            Assert.AreEqual(expectedScoreBreakdownRed_Tote_Count_Far, actualMatchInformation.score_breakdown.red.tote_count_far, "Red Tote count far is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_Tote_Count_Near, actualMatchInformation.score_breakdown.red.tote_count_near, "Red Tote count near is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level1, actualMatchInformation.score_breakdown.red.container_count_level1, "Red Container count level 1 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level2, actualMatchInformation.score_breakdown.red.container_count_level2, "Red Container count level 2 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level3, actualMatchInformation.score_breakdown.red.container_count_level3, "Red Container count level 3 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level4, actualMatchInformation.score_breakdown.red.container_count_level4, "Red Container count level 4 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level5, actualMatchInformation.score_breakdown.red.container_count_level5, "Red Container count level 5 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_count_level6, actualMatchInformation.score_breakdown.red.container_count_level6, "Red Container count level 6 is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_teleop_points, actualMatchInformation.score_breakdown.red.teleop_points, "Red Teleop points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_auto_points, actualMatchInformation.score_breakdown.red.auto_points, "Blu eAuto points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_total_points, actualMatchInformation.score_breakdown.red.total_points, "Red Total points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_tote_set, actualMatchInformation.score_breakdown.red.tote_set, "Red Tote set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_set, actualMatchInformation.score_breakdown.red.container_set, "Red Container set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_foul_count, actualMatchInformation.score_breakdown.red.foul_count, "Red Foul Count is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_container_pointers, actualMatchInformation.score_breakdown.red.container_points, "Red Container points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_adjust_points, actualMatchInformation.score_breakdown.red.adjust_points, "Red adjust points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_litter_count_unprocessed, actualMatchInformation.score_breakdown.red.litter_count_unprocessed, "Red litter count unprocessed is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_robot_set, actualMatchInformation.score_breakdown.red.robot_set, "Red robot set is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_litter_count_container, actualMatchInformation.score_breakdown.red.litter_count_container, "Red litter count container is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_tote_points, actualMatchInformation.score_breakdown.red.tote_points, "Red tote points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_foul_points, actualMatchInformation.score_breakdown.red.foul_points, "Red foul points are not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_tote_stack, actualMatchInformation.score_breakdown.red.tote_stack, "Red tote stack is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_litter_count_landfill, actualMatchInformation.score_breakdown.red.litter_count_landfill, "Red litter count landfill is not as expected!");
            Assert.AreEqual(expectedScoreBreakdownRed_litter_points, actualMatchInformation.score_breakdown.red.litter_points, "Red litter points are not as expected!");

            Assert.AreEqual(expected_coopertition_points, actualMatchInformation.score_breakdown.coopertition_points, "Coopertition points are not as expected!");

            Assert.AreEqual(expectedAlliancesBlueScore, actualMatchInformation.alliances.blue.score, "Blue total score is not as expected!");
            Assert.AreEqual(expectedAlliancesBlue0, actualMatchInformation.alliances.blue.teams[0], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesBlue1, actualMatchInformation.alliances.blue.teams[1], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesBlue2, actualMatchInformation.alliances.blue.teams[2], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRedScore, actualMatchInformation.alliances.red.score, "Red total score is not as expected!");
            Assert.AreEqual(expectedAlliancesRed0, actualMatchInformation.alliances.red.teams[0], "Red team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRed1, actualMatchInformation.alliances.red.teams[1], "Red team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRed2, actualMatchInformation.alliances.red.teams[2], "Red team alliances are not as expected!");

            Assert.AreEqual(expectedEventKey, actualMatchInformation.event_key, "Event keys are not as expected!");
        }

        [TestMethod]
        public void GetMatchInformation2014Test()
        {
            var actualMatchInformation = Matches.GetMatchInformation2014("2014cmp_f1m1");

            var expectedCompLevel = "f";
            var expectedMatchNumber = 1;
            var expectedTimeString = "5:38 PM";
            var expectedSetNumber = 1;
            var expectedKey = "2014cmp_f1m1";
            var expectedTime = 1398551880;

            var expectedAlliancesBlueScore = 361;
            var expectedAlliancesBlue0 = "frc469";
            var expectedAlliancesBlue1 = "frc2848";
            var expectedAlliancesBlue2 = "frc254";

            var expectedAlliancesRedScore = 236;
            var expectedAlliancesRed0 = "frc1678";
            var expectedAlliancesRed1 = "frc1640";
            var expectedAlliancesRed2 = "frc1114";

            var expectedEventKey = "2014cmp";

            Assert.AreEqual(expectedCompLevel, actualMatchInformation.comp_level, "Comp Levels are not as expected!");
            Assert.AreEqual(expectedMatchNumber, actualMatchInformation.match_number, "Match Numbers are not as expected!");
            Assert.AreEqual(expectedTimeString, actualMatchInformation.time_string, "Time strings are not as expected!");
            Assert.AreEqual(expectedSetNumber, actualMatchInformation.set_number, "Set numbers are not as expected!");
            Assert.AreEqual(expectedKey, actualMatchInformation.key, "Keys are not as expected!");
            Assert.AreEqual(expectedTime, actualMatchInformation.time, "Times are not as expected!");

            Assert.AreEqual(expectedAlliancesBlueScore, actualMatchInformation.alliances.blue.score, "Blue total score is not as expected!");
            Assert.AreEqual(expectedAlliancesBlue0, actualMatchInformation.alliances.blue.teams[0], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesBlue1, actualMatchInformation.alliances.blue.teams[1], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesBlue2, actualMatchInformation.alliances.blue.teams[2], "Blue team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRedScore, actualMatchInformation.alliances.red.score, "Red total score is not as expected!");
            Assert.AreEqual(expectedAlliancesRed0, actualMatchInformation.alliances.red.teams[0], "Red team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRed1, actualMatchInformation.alliances.red.teams[1], "Red team alliances are not as expected!");
            Assert.AreEqual(expectedAlliancesRed2, actualMatchInformation.alliances.red.teams[2], "Red team alliances are not as expected!");

            Assert.AreEqual(expectedEventKey, actualMatchInformation.event_key, "Event keys are not as expected!");
        }
    }
}