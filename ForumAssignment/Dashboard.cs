using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumAssignment
{
    public class Dashboard
    {
        /// <summary>
        /// Dashboard method for displaying UI context to the user.
        /// If the parameter is empty, then method displays warning line. Provided the given parameter
        /// is not null, the method iterates the List and delegates printing onto DisplayableComponent itself.
        /// </summary>
        /// <param name="components">List of Objects implementing DisplayableComponent interface.</param>
        /// <param name="pageHeader">Header of the dashboard page.</param>
        public void Display(List<IDisplayableComponent> components, string pageHeader)
        {
            if (!components.Any())
            {
                Console.WriteLine("There is no content to display.");
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}{pageHeader}");
                Console.WriteLine("======================================");
                components.ForEach(compoment => compoment.DisplayComponent());
                Console.WriteLine($"======================================{Environment.NewLine}");

            }
        }

    }
}
