using System;
using System.IO;
using PhasmoApp.Droid.Services;
using PhasmoApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(PathService))]
namespace PhasmoApp.Droid.Services
{
    class PathService : IPathService
    {
        public string GetImagePath()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures).AbsolutePath;
        }

        public string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }
    }
}