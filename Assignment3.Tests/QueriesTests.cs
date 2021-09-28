using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void GetNameByCreator_Wizards_Invented_By_Rowling()
        {
            // Arrange
            IEnumerable<Wizard> wizards = Wizard.Wizards.Value;

            // Act
            var o = Queries.GetNameByCreator("J.K. Rowling", wizards);
            var oLinq = Queries.GetNameByCreatorLinq("J.K. Rowling", wizards);
            var expected = new string[] {
                "Lord Voldemort",
                "Albus Dumbledore"
            };

            // Assert
            Assert.Equal(expected, o);
            Assert.Equal(expected, oLinq);
        }

        [Fact]
        public void GetYearOfOldestSithLord_Return_1985() {
            // Arrange
            IEnumerable<Wizard> wizards = Wizard.Wizards.Value;

            // Act
            var o = Queries.GetYearOfOldestSithLord(wizards);
            var oLinq = Queries.GetYearOfOldestSithLordLinq(wizards);
            var expected = 1985;

            // Assert
            Assert.Equal(expected, o);
            Assert.Equal(expected, oLinq);
        }

        [Fact]
        public void GetYearAndNameFromHarryPotter_Dumbledore_And_Voldemort() {
            // Arrange
            IEnumerable<Wizard> wizards = Wizard.Wizards.Value;

            // Act
            var o = Queries.GetYearAndNameFromHarryPotter(wizards);
            var oLinq = Queries.GetYearAndNameFromHarryPotterLinq(wizards);

            IEnumerable<(string, int?)> expected = new List<(String, int?)>{
                ("Lord Voldemort", 2001),
                ("Albus Dumbledore", 2001)
            };
            
            // Assert
            Assert.Equal(expected, o);
            Assert.Equal(expected, oLinq);
        }

        [Fact]
        public void GetWizardNamesGroupedByCreatorReverse_idk() {
            // Arrange
            IEnumerable<Wizard> wizards = Wizard.Wizards.Value;

            // Act
            var o = Queries.GetWizardNamesGroupedByCreatorReverse(wizards);
            var oLinq = Queries.GetWizardNamesGroupedByCreatorReverseLinq(wizards);
            IEnumerable<string> expected = new string[] {
                "Queen Ravenna",
                "Bavmorda",
                "Grand High Witch",
                "The Wicked Witch of the West",
                "Darth old",
                "Maleficent",
                "Lo Pan",
                "Merlin",
                "Gandalf",
                "Sauron",
                "Albus Dumbledore",
                "Lord Voldemort",
                "Darth Vader",
                "The White Witch"
            };

            // Assert
            Assert.Equal(expected, o);
            Assert.Equal(expected, oLinq);
        }
    }
}
