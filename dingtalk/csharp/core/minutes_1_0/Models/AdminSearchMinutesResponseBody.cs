// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class AdminSearchMinutesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("minutesList")]
        [Validation(Required=false)]
        public List<AdminSearchMinutesResponseBodyMinutesList> MinutesList { get; set; }
        public class AdminSearchMinutesResponseBodyMinutesList : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("creatorUnionId")]
            [Validation(Required=false)]
            public string CreatorUnionId { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("fullTextSummary")]
            [Validation(Required=false)]
            public string FullTextSummary { get; set; }

            [NameInMap("originalText")]
            [Validation(Required=false)]
            public string OriginalText { get; set; }

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
