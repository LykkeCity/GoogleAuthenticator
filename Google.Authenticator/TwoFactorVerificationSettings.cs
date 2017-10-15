namespace Lykke.GoogleAuthenticator
{
    public class TwoFactorVerificationSettings
    {
        public TwoFactorVerificationSettings()
        {
            UseVerification = false;
            QRCodeWidth = 200;
            QRCodeHeight = 200;
            AppNamePrefix = null;
        }

        public bool UseVerification { get; set; }
        
        // ReSharper disable once InconsistentNaming
        public int QRCodeWidth { get; set; }
        // ReSharper disable once InconsistentNaming
        public int QRCodeHeight { get; set; }

        public string AppNamePrefix { get; set; }
    }
}
