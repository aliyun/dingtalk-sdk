// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetFlowSignDetailResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetFlowSignDetailResponseBodyData Data { get; set; }
        public class GetFlowSignDetailResponseBodyData : TeaModel {
            [NameInMap("businessSense")]
            [Validation(Required=false)]
            public string BusinessSense { get; set; }
            [NameInMap("flowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }
            [NameInMap("signers")]
            [Validation(Required=false)]
            public List<GetFlowSignDetailResponseBodyDataSigners> Signers { get; set; }
            public class GetFlowSignDetailResponseBodyDataSigners : TeaModel {
                public string SignerName { get; set; }
                public int? SignStatus { get; set; }
            }
        };

        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
