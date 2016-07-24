using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinSampleApp.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp (Platform platform)
		{
			if (platform == Platform.Android) {
                // steps-xamarin-android-test exports the generated APK path.
                string apkPath = Environment.GetEnvironmentVariable("ANDROID_APK_PATH");
                string emulatorSerial = Environment.GetEnvironmentVariable("ANDROID_EMULATOR_SERIAL");

                return ConfigureApp.Android
                  .ApkFile(apkPath)
                  .DeviceSerial(emulatorSerial)
                  .WaitTimes(new WaitTimes())
                  .StartApp();
            }

            string deviceUDID = Environment.GetEnvironmentVariable("IOS_SIMULATOR_UDID");
            string bundleID = "com.bitrise.samples.xamarinsampleapp";

            return ConfigureApp
                .iOS
                .InstalledApp(bundleID)
                .DeviceIdentifier(deviceUDID)
                .StartApp();
		}
	}
}

