using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhasmoApp.Droid.Services;
using PhasmoApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocaleAndroid))]
namespace PhasmoApp.Droid.Services
{
    public class LocaleAndroid : ILocale
    {
        public string GetCurrentLocaleId()
        {
            var androidLocale = Java.Util.Locale.Default;
            var netLanguage = androidLocale.ToString().Replace("_", "-");
            return netLanguage.ToLower();
        }
    }
}