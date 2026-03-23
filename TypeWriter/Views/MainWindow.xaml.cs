using NLog;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using TypeWriter.PubSubEvents;
using TypeWriter.Services;
using XamlPearls.Shortcuts;

namespace TypeWriter.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppConfigSource _appconfigSource = App.Instance.Container.Resolve<AppConfigSource>();
        private Logger _logger = LogManager.GetCurrentClassLogger();
        private MediaPlayerController _mediaPlayerController = App.Instance.Container.Resolve<MediaPlayerController>();

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true; // Prevent the window from closing
            this.Hide(); // Hide the window instead of closing it
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            #region Media

            var model = new HotKeyModel("PauseOrResumeMedia", true, false, false, false, Keys.Space);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.PauseOrResume(); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("NextMedia", true, false, false, false, Keys.Down);
            try
            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    try { _mediaPlayerController.Next(false); } catch (Exception ex) { _logger.Warn(ex); }
                });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("PrevMedia", true, false, false, false, Keys.Up);
            try
            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    try { _mediaPlayerController.Previous(); } catch (Exception ex) { _logger.Warn(ex); }
                });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("ForwardMedia", true, false, false, false, Keys.Right);

            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Forward(); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("BackMedia", true, false, false, false, Keys.Left);

            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("BackMedia1", true, false, false, false, Keys.D1);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(1 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("BackMedia2", true, false, false, false, Keys.D2);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(2 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia3", true, false, false, false, Keys.D3);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(3 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia4", true, false, false, false, Keys.D4);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(4 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia5", true, false, false, false, Keys.D5);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(5 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia6", true, false, false, false, Keys.D6);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(6 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia7", true, false, false, false, Keys.D7);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(7 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia8", true, false, false, false, Keys.D8);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(8 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia9", true, false, false, false, Keys.D9);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(9 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("BackMedia10", true, false, false, false, Keys.D0);
            try
            {
                this.RegisterGlobalHotKey(model, (model) => { try { _mediaPlayerController.Back(10 * 1000); } catch (Exception ex) { _logger.Warn(ex); } });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
            model = new HotKeyModel("IncSpeed", true, false, false, false, Keys.Oemplus);
            try
            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    try { _mediaPlayerController.IncrementSpeedRatio(_appconfigSource.GetConfig().SpeedRatioIncrement); } catch (Exception ex) { _logger.Warn(ex); }

                });
            }
            catch (Exception ex)
            {
                _logger.Warn( ex);

                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("DecSpeed", true, false, false, false, Keys.OemMinus);

            try

            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    try { _mediaPlayerController.DecrementSpeedRatio(_appconfigSource.GetConfig().SpeedRatioDecrement); } catch (Exception ex) { _logger.Warn(ex); }
                });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            model = new HotKeyModel("RstSpeed", true, false, false, false, Keys.R);

            try
            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    try { _mediaPlayerController.ResetSpeedRatio(); } catch (Exception ex) { _logger.Warn(ex); }
                });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }

            #endregion Media

            model = new HotKeyModel("PlayWordAudio", true, false, true, false, Keys.Space);
            try
            {
                this.RegisterGlobalHotKey(model, (model) =>
                {
                    App.Instance.Container.Resolve<IEventAggregator>()
                    .GetEvent<PlayWordAudioEvent>().Publish();
                });
            }
            catch (Exception ex)
            {
                _logger.Warn(ex);
                App.Instance.TrayIcon.ShowBalloonTip(nameof(TypeWriter), $"Failed to register {model.Name}.", Hardcodet.Wpf.TaskbarNotification.BalloonIcon.Warning);
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
