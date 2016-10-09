using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XFP
{

    public class CourseMasterDetailDB : MasterDetailPage
    {

        public CourseMasterDetailDB()
        {

            var listView = new ListView();
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            listView.ItemSelected += (sender, e) => {

                if (e.SelectedItem != null)
                {

                    Detail.BindingContext = e.SelectedItem;
                    IsPresented = false;
                }
            };

            // represents the master page
            Master = new ContentPage
            {
                Title = "Courses",
                Content = listView
            };

            Detail = new CoursePageDB();
            Detail.BindingContext = PluralsightCourse.GetCourseList().First();
        }
    }
}
