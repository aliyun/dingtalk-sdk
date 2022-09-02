// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetFlowDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFlowDetailResponseBodyData Data { get; set; }
        public class GetFlowDetailResponseBodyData : TeaModel {
            [NameInMap("businessSense")]
            [Validation(Required=false)]
            public string BusinessSense { get; set; }

            [NameInMap("flowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }

            [NameInMap("initiatorAuthorizedName")]
            [Validation(Required=false)]
            public string InitiatorAuthorizedName { get; set; }

            [NameInMap("initiatorName")]
            [Validation(Required=false)]
            public string InitiatorName { get; set; }

            [NameInMap("logs")]
            [Validation(Required=false)]
            public List<GetFlowDetailResponseBodyDataLogs> Logs { get; set; }
            public class GetFlowDetailResponseBodyDataLogs : TeaModel {
                [NameInMap("logType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                [NameInMap("operateDescription")]
                [Validation(Required=false)]
                public string OperateDescription { get; set; }

                [NameInMap("operateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                [NameInMap("operatorAccountName")]
                [Validation(Required=false)]
                public string OperatorAccountName { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
