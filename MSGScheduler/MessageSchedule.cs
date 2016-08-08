using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MSGScheduler
{
    public class MessageSchedule
    {
        public String NameInContact { get; set; }
        public String PhoneNum { get; set; }
        public String DateSend { get; set; }
        public String DateSchedule { get; set; }
        public String DateDiscard { get; set; }
        public String SMSContent { get; set; }
        public String SMSStatus { get; set; }// 0 is unsent, 1 is sent, 2 is  discard
    }
}