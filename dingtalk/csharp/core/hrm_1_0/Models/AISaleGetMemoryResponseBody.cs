// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleGetMemoryResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleGetMemoryResponseBodyResult Result { get; set; }
        public class AISaleGetMemoryResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<AISaleGetMemoryResponseBodyResultData> Data { get; set; }
            public class AISaleGetMemoryResponseBodyResultData : TeaModel {
                [NameInMap("contactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("entityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public string ExtInfo { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("happenedAt")]
                [Validation(Required=false)]
                public long? HappenedAt { get; set; }

                [NameInMap("importance")]
                [Validation(Required=false)]
                public int? Importance { get; set; }

                [NameInMap("memoryCategory")]
                [Validation(Required=false)]
                public string MemoryCategory { get; set; }

                [NameInMap("memoryContent")]
                [Validation(Required=false)]
                public string MemoryContent { get; set; }

                [NameInMap("memoryId")]
                [Validation(Required=false)]
                public string MemoryId { get; set; }

                [NameInMap("memoryTitle")]
                [Validation(Required=false)]
                public string MemoryTitle { get; set; }

                [NameInMap("sourceActivityId")]
                [Validation(Required=false)]
                public string SourceActivityId { get; set; }

                [NameInMap("tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public string NextCursor { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
