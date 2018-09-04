using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestProject
{
    public class App : Application
    {
        public App()
        {
            MainPage = new Main_Page();
        }
    }

    public class Main_Page : ContentPage
    {
        Entry field1, field2;
        Button Add;
        Label Result;

        public Main_Page()
        {
            field1 = new Entry()
            {
                Placeholder = "Enter Number",
                AutomationId    =   "entry1"
            };
            field2 = new Entry()
            {
                Placeholder = "Enter Number",
                AutomationId = "entry2"
            };
            Add = new Button()
            {
                Text = "Add",
                AutomationId = "Add"
            };
            Add.Clicked += Add_Clicked;

            Result = new Label()
            {
                Text = "Result",
                BackgroundColor = Color.DarkSalmon
            };

            var sLayout = new StackLayout()
            {
                Children = { field1, field2, Add, Result }
            };
            Content = sLayout;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            int value1, value2;
            int.TryParse(field1.Text.ToString(), out value1);
            int.TryParse(field2.Text.ToString(), out value2);

            Result.Text = (value1 + value2).ToString();
        }
    }
}
