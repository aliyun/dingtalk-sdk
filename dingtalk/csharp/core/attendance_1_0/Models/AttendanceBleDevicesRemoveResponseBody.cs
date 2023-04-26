// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class AttendanceBleDevicesRemoveResponseBody : TeaModel {
        [NameInMap("errorList")]
        [Validation(Required=false)]
        public List<AttendanceBleDevicesRemoveResponseBodyErrorList> ErrorList { get; set; }
        public class AttendanceBleDevicesRemoveResponseBodyErrorList : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("failureList")]
            [Validation(Required=false)]
            public List<long?> FailureList { get; set; }

            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        [NameInMap("successList")]
        [Validation(Required=false)]
        public List<long?> SuccessList { get; set; }

    }

}
