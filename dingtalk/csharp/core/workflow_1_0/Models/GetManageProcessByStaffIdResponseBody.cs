// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetManageProcessByStaffIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetManageProcessByStaffIdResponseBodyResult> Result { get; set; }
        public class GetManageProcessByStaffIdResponseBodyResult : TeaModel {
            [NameInMap("attendanceType")]
            [Validation(Required=false)]
            public int? AttendanceType { get; set; }

            [NameInMap("flowTitle")]
            [Validation(Required=false)]
            public string FlowTitle { get; set; }

            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("iconName")]
            [Validation(Required=false)]
            public string IconName { get; set; }

            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("newProcess")]
            [Validation(Required=false)]
            public bool? NewProcess { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
