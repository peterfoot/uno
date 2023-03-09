using System;
using System.Diagnostics;
using Windows.Foundation;

namespace Windows.Media.Playback
{
	public partial class MediaPlayer
	{
		#region Properties

		private IMediaPlaybackSource _source;
		public IMediaPlaybackSource Source
		{
			get => _source;
			set
			{
				Stop();

				_source = value;

				InitializeSource();

				SourceChanged?.Invoke(this, null);

				if (_source != null && AutoPlay)
				{
					Play();
				}
			}
		}

		public bool AutoPlay { get; set; }

		private bool _isMuted;
		public bool IsMuted
		{
			get => _isMuted;
			set
			{
				_isMuted = value;
				ToggleMute();
				IsMutedChanged?.Invoke(this, _isMuted);
			}
		}

		private double _volume = 1d;
		public double Volume
		{
			get => _volume;
			set
			{
				_volume = value;
				OnVolumeChanged();
				VolumeChanged?.Invoke(this, _volume);
			}
		}

		public MediaPlaybackSession PlaybackSession { get; }

		#endregion

		#region Events

		public event TypedEventHandler<MediaPlayer, object> SourceChanged;

		public event TypedEventHandler<MediaPlayer, object> IsMutedChanged;

		public event TypedEventHandler<MediaPlayer, object> VolumeChanged;

		public event TypedEventHandler<MediaPlayer, object> MediaEnded;

		public event TypedEventHandler<MediaPlayer, MediaPlayerFailedEventArgs> MediaFailed;

		public event TypedEventHandler<MediaPlayer, object> MediaOpened;

		public event TypedEventHandler<MediaPlayer, object> SeekCompleted;

		public event TypedEventHandler<MediaPlayer, double> VideoRatioChanged;

		#endregion

		public MediaPlayer()
		{
			PlaybackSession = new MediaPlaybackSession(this);
			Initialize();
		}
	}
}
