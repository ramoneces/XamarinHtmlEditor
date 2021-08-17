using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinHtmlEditor
{
    public class HtmlEditor : WebView
    {
        public HtmlEditor()
        {
            string baseUrl = DependencyService.Get<IBaseUrl>().Get();
            Source = Path.Combine(baseUrl, "index.html");
        }

        public static BindableProperty EvaluateJavascriptProperty =
        BindableProperty.Create(nameof(EvaluateJavascript), typeof(Func<string, Task<string>>), typeof(HtmlEditor), null, BindingMode.OneWayToSource);

        public Func<string, Task<string>> EvaluateJavascript
        {
            get { return (Func<string, Task<string>>)GetValue(EvaluateJavascriptProperty); }
            set { SetValue(EvaluateJavascriptProperty, value); }
        }
    }

}
