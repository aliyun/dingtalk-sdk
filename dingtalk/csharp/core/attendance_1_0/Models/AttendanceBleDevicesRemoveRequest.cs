// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesRemoveRequest : TeaModel {
        [NameInMap("deviceIdList")]
        [Validation(Required=false)]
        public List<long?> DeviceIdList { get; set; }

        [NameInMap("groupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
