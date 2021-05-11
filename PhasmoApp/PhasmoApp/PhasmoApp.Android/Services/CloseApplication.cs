
using PhasmoApp.Droid.Services;
using PhasmoApp.Services;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]
namespace PhasmoApp.Droid.Services
{
    public class CloseApplication : ICloseApplication
    {
        //Context context = Android.App.Application.Context;
        public void closeApplication()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            //Activity activity = context;// (Activity)Forms.Context;
            //activity.FinishAffinity();
        }
    }
}