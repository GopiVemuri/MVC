using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GopiVemuriMVC.Common
{
    public enum OperationStatus
    {
        Failure,
        Success,
    }

    #region "(Error Handling) Severity"
    /// <summary>
    /// "Severity" => is used in Error Handling class.
    /// </summary>
    public enum Severity : int
    {
        /// <summary>
        /// "Error" or "Exception" in the process.
        /// </summary>            
        Error = 1,

        /// <summary>
        /// "Information" is to log the warnings
        /// </summary>
        Information = 2,

        /// <summary>
        /// To Trace
        /// </summary>
        Trace = 3,
    }
    #endregion
    public enum MessageStatus
    {

        Error,
        Success,
        Warning,
        Note

    }
}