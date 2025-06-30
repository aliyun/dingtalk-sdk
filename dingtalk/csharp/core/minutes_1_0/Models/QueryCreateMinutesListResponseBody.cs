// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryCreateMinutesListResponseBody : TeaModel {
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("minutesDetails")]
        [Validation(Required=false)]
        public List<QueryCreateMinutesListResponseBodyMinutesDetails> MinutesDetails { get; set; }
        public class QueryCreateMinutesListResponseBodyMinutesDetails : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("durationMicros")]
            [Validation(Required=false)]
            public long? DurationMicros { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public int? IsDeleted { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("taskUuid")]
            [Validation(Required=false)]
            public string TaskUuid { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
