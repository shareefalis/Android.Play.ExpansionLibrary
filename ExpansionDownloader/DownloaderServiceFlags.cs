using System;

namespace ExpansionDownloader
{
    [Flags]
    public enum DownloaderServiceFlags
    {
        /// <summary>
        /// Set this flag in response to the 
        /// <see cref="DownloaderClientState.PausedNeedCellularPermission"/> 
        /// state and then call RequestContinueDownload to resume a download
        /// </summary>
        FlagsDownloadOverCellular = 1
    }
}