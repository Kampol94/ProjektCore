using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Telephony;
using ProjektCoreMobile.Droid;
using Xamarin.Forms;
using Uri = Android.Net.Uri;
[assembly: Dependency(typeof(PhoneDialer))]

namespace ProjektCoreMobile.Droid
{
    public class PhoneDialer : IDialer
    {

        public bool Dial(string number)
        {
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            var context = Forms.Context;
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
            if (context == null) return false;
            var intent = new Intent(Intent.ActionCall);
            intent.SetData(Uri.Parse("tel:" + number));
            if(IsIntentAvailable(context, intent))
            {
                context.StartActivity(intent);
                return true;
            }
            return false;
        }

        public static bool IsIntentAvailable(Context context, Intent intent)
        {
            var packageManager = context.PackageManager;
            var list = packageManager.QueryIntentServices(intent, 0).Union(packageManager.QueryIntentActivities(intent, 0));
            var manager = TelephonyManager.FromContext(context);
            return manager.PhoneType != PhoneType.None;
        }
    }
}