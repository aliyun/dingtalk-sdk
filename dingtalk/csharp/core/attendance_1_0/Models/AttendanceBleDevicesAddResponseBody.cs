// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesAddResponseBody : TeaModel {
        [NameInMap("errorList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesAddResponseBodyErrorList> ErrorList { get; set; }
        public class AttendanceBleDevicesAddResponseBodyErrorList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>400001</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("failureList")]
            [Validation(Required=false)]
            public List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> FailureList { get; set; }
            public class AttendanceBleDevicesAddResponseBodyErrorListFailureList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3244523553</para>
                /// </summary>
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public long? DeviceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>蓝牙设备1</para>
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dfsgdsdgd</para>
                /// </summary>
                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        [NameInMap("successList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesAddResponseBodySuccessList> SuccessList { get; set; }
        public class AttendanceBleDevicesAddResponseBodySuccessList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6567575</para>
            /// </summary>
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>蓝牙设备2</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xfdfsdfgsdgfs</para>
            /// </summary>
            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
