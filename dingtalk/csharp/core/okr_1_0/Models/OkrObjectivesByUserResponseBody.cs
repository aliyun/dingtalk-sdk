// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OkrObjectivesByUserResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public OkrObjectivesByUserResponseBodyContent Content { get; set; }
        public class OkrObjectivesByUserResponseBodyContent : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<OpenObjectiveDTO> Result { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
