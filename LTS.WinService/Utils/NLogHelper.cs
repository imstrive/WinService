using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.WinService.Utils
{
    /// <summary>
    /// NLog日志帮助类
    /// </summary>
    public class NLogHelper
    {
        private static Logger logHelper;
        static NLogHelper()
        {
            logHelper = LogManager.GetCurrentClassLogger();
        }
        #region Debug
        public static void Debug(string msg)
        {
            logHelper.Debug(msg);
        }

        public static void Debug(string msg, Exception err)
        {
            logHelper.Debug(err, msg);
        }
        #endregion

        #region Info
        public static void Info(string msg)
        {
            logHelper.Info(msg);
        }

        public static void Info(string msg, Exception err)
        {
            logHelper.Info(err, msg);
        }
        #endregion

        #region Warn
        public static void Warn(string msg)
        {
            logHelper.Warn(msg);
        }

        public static void Warn(string msg, Exception err)
        {
            logHelper.Warn(err, msg);
        }
        #endregion

        #region Trace
        public static void Trace(string msg)
        {
            logHelper.Trace(msg);
        }

        public static void Trace(string msg, Exception err)
        {
            logHelper.Trace(err, msg);
        }
        #endregion

        #region Error
        public static void Error(string msg)
        {
            logHelper.Error(msg);
        }

        public static void Error(string msg, Exception err)
        {
            logHelper.Error(err, msg);
        }
        #endregion

        #region Fatal
        public static void Fatal(string msg)
        {
            logHelper.Fatal(msg);
        }

        public static void Fatal(string msg, Exception err)
        {
            logHelper.Fatal(err, msg);
        }
        #endregion
    }
}
