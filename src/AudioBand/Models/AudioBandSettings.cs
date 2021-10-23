namespace AudioBand.Models
{
    /// <summary>
    /// Collection of global AudioBand settings.
    /// </summary>
    public class AudioBandSettings
    {
        private string _lastNonIdleProfileName = "";

        /// <summary>
        /// Gets the last active profile name before going into idle.
        /// </summary>
        public string LastNonIdleProfileName
        {
            get => _lastNonIdleProfileName;
            set
            {
                if (value == IdleProfileName)
                {
                    return;
                }

                _lastNonIdleProfileName = value;
            }
        }

        /// <summary>
        /// The profile that should enable when AudioBand goes into idle mode.
        /// </summary>
        public string IdleProfileName { get; set; } = "Idle";

        /// <summary>
        /// Gets or sets whether to use the Idle Profile.
        /// </summary>
        public bool UseAutomaticIdleProfile { get; set; }

        /// <summary>
        /// Gets or sets whether to hide the Idle profile in the Profiles quick menu.
        /// </summary>
        public bool HideIdleProfileInQuickMenu { get; set; }

        /// <summary>
        /// Gets or sets the amount of time in seconds it should take for AudioBand to go idle.
        /// </summary>
        public int ShouldGoIdleAfterInSeconds { get; set; }

        /// <summary>
        /// Gets or sets whether to show a popup when an update is available.
        /// </summary>
        public bool ShowPopupOnAvailableUpdate { get; set; } = true;

        /// <summary>
        /// Gets or sets whether to show little help popups when something fails.
        /// </summary>
        public bool ShowInformationPopups { get; set; } = true;

        /// <summary>
        /// Gets or sets whether to opt-in for pre-releases.
        /// </summary>
        public bool OptInForPreReleases { get; set; }
    }
}
