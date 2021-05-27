// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetFlowDetailResponseBody : TeaModel {
        [NameInMap("businessScene")]
        [Validation(Required=false)]
        public string BusinessScene { get; set; }

        [NameInMap("flowStatus")]
        [Validation(Required=false)]
        public float? FlowStatus { get; set; }

        [NameInMap("initiatorAuthorizedName")]
        [Validation(Required=false)]
        public string InitiatorAuthorizedName { get; set; }

        [NameInMap("initiatorName")]
        [Validation(Required=false)]
        public string InitiatorName { get; set; }

        [NameInMap("logs")]
        [Validation(Required=false)]
        public List<GetFlowDetailResponseBodyLogs> Logs { get; set; }
        public class GetFlowDetailResponseBodyLogs : TeaModel {
            [NameInMap("operatorAccountName")]
            [Validation(Required=false)]
            public string OperatorAccountName { get; set; }

            [NameInMap("logType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            [NameInMap("operateDescription")]
            [Validation(Required=false)]
            public string OperateDescription { get; set; }

            [NameInMap("operateTime")]
            [Validation(Required=false)]
            public float? OperateTime { get; set; }

        }

    }

}
