// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListMaintainInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMaintainInfoResponseBodyResult> Result { get; set; }
        public class ListMaintainInfoResponseBodyResult : TeaModel {
            [NameInMap("deviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("handleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            [NameInMap("maintenanceStaff")]
            [Validation(Required=false)]
            public List<string> MaintenanceStaff { get; set; }

            [NameInMap("processState")]
            [Validation(Required=false)]
            public int? ProcessState { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
