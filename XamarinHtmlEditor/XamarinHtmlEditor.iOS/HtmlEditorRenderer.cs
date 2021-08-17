using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinHtmlEditor;
using XamarinHtmlEditor.iOS;

[assembly: ExportRenderer(typeof(HtmlEditor), typeof(HtmlEditorRenderer))]
namespace XamarinHtmlEditor.iOS
{

    public class HtmlEditorRenderer : WkWebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var webView = e.NewElement as HtmlEditor;
            if (webView != null)
                webView.EvaluateJavascript = (js) =>
                {
                    return this.EvaluateJavaScriptAsync(js).ContinueWith((task) => task.Result.ToString());
                };
        }
    }
}