// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetRecognizeRecordsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetRecognizeRecordsResponseBodyData> Data { get; set; }
        public class GetRecognizeRecordsResponseBodyData : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            [NameInMap("faceCompareResult")]
            [Validation(Required=false)]
            public int? FaceCompareResult { get; set; }

            [NameInMap("invokeTime")]
            [Validation(Required=false)]
            public long? InvokeTime { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
