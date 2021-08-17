using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinHtmlEditor
{
    public partial class MainPage : ContentPage
    {
        const string SampleEditorData = "{\"blocks\":[{\"id\":\"JUYXkhrJC7\",\"type\":\"header\",\"data\":{\"text\":\"Editor.js\",\"level\":2}},{\"id\":\"hOzpbAWBoB\",\"type\":\"paragraph\",\"data\":{\"text\":\"Hey. Meet the new Editor. On this page you can see it in action — try to edit this text. Source code of the page contains the example of connection and configuration.\"}}],\"version\":\"2.22.2\"}";

        public MainPage()
        {
            InitializeComponent();
        }


        private async void SetData_Clicked(object sender, EventArgs e)
        {
             await Editor.EvaluateJavascript($"setData('{SampleEditorData}')");
        }
        
        private async void ToggleReadonly_Clicked(object sender, EventArgs e)
        {
            string result = await Editor.CallAsyncMethod("toggleReadOnly");

            App.Current.MainPage.DisplayAlert((sender as Button).Text, $"Readonly set to: {result}.", "Ok");
        }

        private async void GetData_Clicked(object sender, EventArgs e)
        {
            string result = await Editor.CallAsyncMethod("getData");

            App.Current.MainPage.DisplayAlert((sender as Button).Text, $"Saved data: {result}.", "Ok");
        }

        
    }
}
