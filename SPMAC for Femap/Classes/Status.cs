using System.Drawing;
using System.Threading;
using Telerik.WinControls.UI;

namespace SPMAC_for_Femap.Classes
{
    public static class Status
    {
        public static string CurrentStatusString { set; get; }
        public static int ProgressValue { get; set; }
        public static CancellationTokenSource CancellationTokenSourse { get; set; }
        public static CurrentState CurrState { get; set; }
        public enum CurrentState
        {
            READY,
            WARNING,
            ERROR,
            SAVING,
            CREATING,
            ASSEMBLY,
            WAIT,
            ANALYSIS
        };
        public static Image ImageState { get; set; }
        public static string CurrentDirectory { get; set; }
        public static string CurrentDetailsSetDirectory { get; set; }
    }
}
