// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalObjectiveProgressListResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public AgoalObjectiveProgressListResponseBodyContent Content { get; set; }
        public class AgoalObjectiveProgressListResponseBodyContent : TeaModel {
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("result")]
            [Validation(Required=false)]
            public List<OpenAgoalProgressDTO> Result { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
