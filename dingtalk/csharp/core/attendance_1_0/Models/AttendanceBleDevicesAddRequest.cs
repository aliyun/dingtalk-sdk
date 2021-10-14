// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesAddRequest : TeaModel {
        /// <summary>
        /// 蓝牙设备Id列表
        /// </summary>
        [NameInMap("deviceIdList")]
        [Validation(Required=false)]
        public List<long?> DeviceIdList { get; set; }

        /// <summary>
        /// 考勤组Id
        /// </summary>
        [NameInMap("groupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        /// <summary>
        /// 操作人Id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
