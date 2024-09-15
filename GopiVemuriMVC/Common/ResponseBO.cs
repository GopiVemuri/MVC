using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace GopiVemuriMVC.Common
{
    public class ResponseBO<T> where T : class
    {
        public T Data { get; set; }

        public OperationStatus OperationStatus
        {
            get;
            set;
        }


        public string MessageCode
        {
            get;
            set;
        }

        public MessageStatus MessageStatus
        {
            get;
            set;
        }


        public long RID
        {
            get;
            set;
        }

        public bool BoolReserv { get; set; }

        public string ValidationKey
        {
            get;
            set;
        }
    }
}