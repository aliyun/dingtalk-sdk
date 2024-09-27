// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class GetRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nextToken</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetRecordsResponseBodyRecords> Records { get; set; }
        public class GetRecordsResponseBodyRecords : TeaModel {
            [NameInMap("createdBy")]
            [Validation(Required=false)]
            public GetRecordsResponseBodyRecordsCreatedBy CreatedBy { get; set; }
            public class GetRecordsResponseBodyRecordsCreatedBy : TeaModel {
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("lastModifiedBy")]
            [Validation(Required=false)]
            public GetRecordsResponseBodyRecordsLastModifiedBy LastModifiedBy { get; set; }
            public class GetRecordsResponseBodyRecordsLastModifiedBy : TeaModel {
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

        }

    }

}
