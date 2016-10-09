using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFP
{
    public class PluralsightCourse
    {

        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        //when using a complex time, toString is called

        public override string ToString()
        {

            return Title;
        }

        public static List<PluralsightCourse> GetCourseList()
        {

            var courseList = new List<PluralsightCourse>();

            courseList.Add(new PluralsightCourse
            {

                Title = "Building Cross Platform Apps with Xamarin Part 1",
                TitleShort = "Xamarin 1",
                Description = "Learn ho to use Xamarin to leverage your skills in Microsoft VIsual Studio and C# to build cross-platform apps that run on both Android and iOS",
                Author = "Jim Wilson"
            });

            courseList.Add(new PluralsightCourse
            {

                Title = "Building Cross Platform Apps with Xamarin Part 2",
                TitleShort = "Xamarin 2",
                Description = "More advanced stuff to learn. Wow, so new such technology. Learn ho to use Xamarin to leverage your skills in Microsoft VIsual Studio and C# to build cross-platform apps that run on both Android and iOS",
                Author = "Jim Wilson"
            });

            courseList.Add(new PluralsightCourse
            {

                Title = "Building Google Glass Apps with c# and Xamarin",
                TitleShort = "Google Glass",
                Description = "we can learn how to see the world through google glasses. new technology that renovates the world.",
                Author = "Jim Wilson"
            });

            courseList.Add(new PluralsightCourse
            {

                Title = "Android for .NET Developers",
                TitleShort = "Android .NET",
                Description = "android is cool and delicious",
                Author = "Jim Wilson"
            });

            return courseList;
        }

        public PluralsightCourse()
        {
        }
    }
}
