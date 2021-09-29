using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public static IEnumerable<String> GetNameByCreator(string name, IEnumerable<Wizard> wizards) {
            return wizards
                .Where(w => w.Creator == name)
                .Select(w => w.Name);
        }
        public static IEnumerable<String> GetNameByCreatorLinq(string name, IEnumerable<Wizard> wizards) {
            return from wizard in wizards
                where wizard.Creator == name
                select wizard.Name;
        }

        public static int GetYearOfOldestSithLord(IEnumerable<Wizard> wizards) {
            return (int)wizards
                .Where(w => w.Name.StartsWith("Darth"))
                .Select(w => w.Year).Max();
        }

        public static int GetYearOfOldestSithLordLinq(IEnumerable<Wizard> wizards) {
            return (int)(from wizard in wizards
                where wizard.Name.StartsWith("Darth")
                select wizard.Year).Max();
        }

        public static IEnumerable<(string, int?)> GetYearAndNameFromHarryPotter(IEnumerable<Wizard> wizards) {
            return wizards
                .Where(w => w.Medium == "Harry Potter Series")
                .Select(w => (w.Name, w.Year));
        }

        public static IEnumerable<(string, int?)> GetYearAndNameFromHarryPotterLinq(IEnumerable<Wizard> wizards) {
            return from wizard in wizards
                where wizard.Medium == "Harry Potter Series"
                select (wizard.Name, wizard.Year);
        }

        public static IEnumerable<string> GetWizardNamesGroupedByCreatorReverse(IEnumerable<Wizard> wizards) {
            return wizards
                .OrderByDescending(w => w.Creator)
                .ThenBy(w => w.Name)
                .Select(w => w.Name);
        }

        public static IEnumerable<string> GetWizardNamesGroupedByCreatorReverseLinq(IEnumerable<Wizard> wizards) {
            return from wizard in wizards
                orderby wizard.Creator descending, wizard.Name ascending
                select wizard.Name;
        }
    }
}
