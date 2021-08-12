// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesAddResponseBody : TeaModel {
        /// <summary>
        /// 添加错误列表
        /// </summary>
        [NameInMap("errorList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesAddResponseBodyErrorList> ErrorList { get; set; }
        public class AttendanceBleDevicesAddResponseBodyErrorList : TeaModel {
            /// <summary>
            /// 错误code
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 失败蓝牙设备列表
            /// </summary>
            [NameInMap("failureList")]
            [Validation(Required=false)]
            public List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> FailureList { get; set; }
            public class AttendanceBleDevicesAddResponseBodyErrorListFailureList : TeaModel {
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

            /// <summary>
            /// errorMsg
            /// </summary>
            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        /// <summary>
        /// 添加成功蓝牙设备列表
        /// </summary>
        [NameInMap("successList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesAddResponseBodySuccessList> SuccessList { get; set; }
        public class AttendanceBleDevicesAddResponseBodySuccessList : TeaModel {
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
