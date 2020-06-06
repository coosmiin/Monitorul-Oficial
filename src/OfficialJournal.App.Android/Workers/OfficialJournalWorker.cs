using Android.Content;
using Android.Support.V4.App;
using AndroidX.Work;
using System;

namespace OfficialJournal.App.Droid.Workers
{
	public class OfficialJournalWorker : Worker
	{
		public OfficialJournalWorker(Context context, WorkerParameters parameters)
			: base (context, parameters)
		{
		}

		public override Result DoWork()
		{
			Android.Util.Log.Debug($"{nameof(OfficialJournalWorker)}", DateTime.Now.ToString());

			var builder = new NotificationCompat.Builder(ApplicationContext, null)
				.SetAutoCancel(true)
				//.SetContentIntent(resultPendingIntent) // Start up this activity when the user clicks the intent.
				.SetContentTitle("Some title")
				.SetSmallIcon(Resource.Drawable.notification_icon_background)
				.SetContentText($"Test notification content");

			var notificationManager = NotificationManagerCompat.From(ApplicationContext);
			notificationManager.Notify(1, builder.Build());

			return Result.InvokeSuccess();
		}
	}
}
