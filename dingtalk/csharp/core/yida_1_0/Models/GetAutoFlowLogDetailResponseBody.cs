// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetAutoFlowLogDetailResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAutoFlowLogDetailResponseBodyData> Data { get; set; }
        public class GetAutoFlowLogDetailResponseBodyData : TeaModel {
            [NameInMap("activityKey")]
            [Validation(Required=false)]
            public string ActivityKey { get; set; }

            [NameInMap("elapsedTimeGMT")]
            [Validation(Required=false)]
            public long? ElapsedTimeGMT { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("inputParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> InputParams { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("others")]
            [Validation(Required=false)]
            public string Others { get; set; }

            [NameInMap("outputParams")]
            [Validation(Required=false)]
            public Dictionary<string, object> OutputParams { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        [NameInMap("hasMoreData")]
        [Validation(Required=false)]
        public bool? HasMoreData { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
