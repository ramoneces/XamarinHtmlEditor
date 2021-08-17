using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using XamarinHtmlEditor.iOS;

[assembly: Dependency(typeof(BaseUrl))]
namespace XamarinHtmlEditor.iOS
{
    public class BaseUrl : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}