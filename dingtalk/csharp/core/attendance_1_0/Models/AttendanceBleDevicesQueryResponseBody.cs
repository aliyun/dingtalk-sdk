// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesQueryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesQueryResponseBodyResult> Result { get; set; }
        public class AttendanceBleDevicesQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>34666777</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>蓝牙设备</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12321kllksdf</para>
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
