// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class QueryEventResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryEventResponseBodyData> Data { get; set; }
        public class QueryEventResponseBodyData : TeaModel {
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("eventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("eventStatus")]
            [Validation(Required=false)]
            public long? EventStatus { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

            [NameInMap("occurrenceTime")]
            [Validation(Required=false)]
            public long? OccurrenceTime { get; set; }

            [NameInMap("picUrls")]
            [Validation(Required=false)]
            public List<string> PicUrls { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
