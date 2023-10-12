// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class TransferEventRequest : TeaModel {
        [NameInMap("isExitCalendar")]
        [Validation(Required=false)]
        public bool? IsExitCalendar { get; set; }

        [NameInMap("needNotifyViaO2O")]
        [Validation(Required=false)]
        public bool? NeedNotifyViaO2O { get; set; }

        [NameInMap("newOrganizerId")]
        [Validation(Required=false)]
        public string NewOrganizerId { get; set; }

    }

}
