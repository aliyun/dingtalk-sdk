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
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("failureList")]
            [Validation(Required=false)]
            public List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> FailureList { get; set; }
            public class AttendanceBleDevicesAddResponseBodyErrorListFailureList : TeaModel {
                [NameInMap("deviceId")]
                [Validation(Required=false)]
                public long? DeviceId { get; set; }

                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

            }

            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        [NameInMap("successList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesAddResponseBodySuccessList> SuccessList { get; set; }
        public class AttendanceBleDevicesAddResponseBodySuccessList : TeaModel {
            [NameInMap("deviceId")]
            [Validation(Required=false)]
            public long? DeviceId { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

        }

    }

}
