using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GopiVemuriMVC.Common
{
    public class ConstantsBO
    {
        public static string DBConnection = !string.IsNullOrEmpty(ConfigurationManager.ConnectionStrings["DbConn"].ToString()) ? ConfigurationManager.ConnectionStrings["DBConn"].ToString() : string.Empty;
        public static int DBConnTimeOut = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["DBConnTimeOut"]) ? Convert.ToInt32(ConfigurationManager.AppSettings["DBConnTimeOut"]) : 300;
        public static int MaxFailedLoginAttempt = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["MaxFailedLoginAttempt"]) ? Convert.ToInt32(ConfigurationManager.AppSettings["MaxFailedLoginAttempt"]) : 5;
        public static string XmlFilePath = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["XmlFilePath"]) ? ConfigurationManager.AppSettings["XmlFilePath"] : string.Empty;
        public static string MsgXmlName = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["MsgXmlName"]) ? ConfigurationManager.AppSettings["MsgXmlName"] : string.Empty;
        public static string ItemImgPath = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["ItemImgPath"]) ? ConfigurationManager.AppSettings["ItemImgPath"] : string.Empty;
        public static string CancelEnStatus = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["CancelEnStatus"]) ? ConfigurationManager.AppSettings["CancelEnStatus"] : string.Empty;
        public static string FedExTrackingUrl = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["FedExTrackingUrl"]) ? ConfigurationManager.AppSettings["FedExTrackingUrl"] : string.Empty;
        public static string SSRSUserName = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSRSUserName"]) ? ConfigurationManager.AppSettings["SSRSUserName"] : string.Empty;
        public static string SSRSPassword = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSRSPassword"]) ? ConfigurationManager.AppSettings["SSRSPassword"] : string.Empty;
        public static string SSRSDomain = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSRSDomain"]) ? ConfigurationManager.AppSettings["SSRSDomain"] : string.Empty;
        public static string SSRSReportName = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSRSReportName"]) ? ConfigurationManager.AppSettings["SSRSReportName"] : string.Empty;
        public static string SSRSPDFFileName = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SSRSPDFFileName"]) ? ConfigurationManager.AppSettings["SSRSPDFFileName"] : string.Empty;
        public static string WorkTicketDestinationFolder = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["WorkTicketDestinationFolder"]) ? ConfigurationManager.AppSettings["WorkTicketDestinationFolder"] : string.Empty;
        public static string AccessXml = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["AccessXml"]) ? ConfigurationManager.AppSettings["AccessXml"] : string.Empty;
        public static string RatingServiceRequestXML = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["AccessXml"]) ? ConfigurationManager.AppSettings["AccessXml"] : string.Empty;
        public static string TrackingURL = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["TrackingURL"]) ? ConfigurationManager.AppSettings["TrackingURL"] : string.Empty;

    }
}