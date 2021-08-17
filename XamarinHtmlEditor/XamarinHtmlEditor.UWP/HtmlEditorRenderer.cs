using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinHtmlEditor;
using XamarinHtmlEditor.UWP;

[assembly: ExportRenderer(typeof(HtmlEditor), typeof(HtmlEditorRenderer))]
namespace XamarinHtmlEditor.UWP
{
    public class HtmlEditorRenderer : WebViewRenderer
    {
        protected async override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            var webView = e.NewElement as HtmlEditor;
            if (webView != null)
                webView.EvaluateJavascript = async (js) =>
                {
                    return await Control.InvokeScriptAsync("eval", new[] { js });
                };
        }
    }
   


}
