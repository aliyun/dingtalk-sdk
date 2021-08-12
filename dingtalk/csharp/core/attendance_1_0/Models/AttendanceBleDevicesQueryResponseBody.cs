// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesQueryResponseBody : TeaModel {
        /// <summary>
        /// 蓝牙列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesQueryResponseBodyResult> Result { get; set; }
        public class AttendanceBleDevicesQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// 蓝牙设备Id
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

            /// <summary>
            /// 蓝牙设备名称
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// sn
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
