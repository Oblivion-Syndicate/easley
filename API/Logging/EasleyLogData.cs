//////////////////////////////////////////////
/// Filename: EasleyLogData.cs
/// Date: July 24, 2025
/// Author: Maverick Liberty
//////////////////////////////////////////////

namespace Easley.API.Logging
{

    public sealed class EasleyLogData
    {

        public string Category;
        public LogLevelFlags LogLevel = LogLevelFlags.Default;

        public EasleyLogData(string category)
        {
            this.Category = category;
            this.LogLevel = LogLevelFlags.Default;
        }

        public EasleyLogData(string category, LogLevelFlags level)
        {
            this.Category = category;
            this.LogLevel = level;
        }

    }

}
