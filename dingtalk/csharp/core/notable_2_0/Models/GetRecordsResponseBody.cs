// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class GetRecordsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetRecordsResponseBodyRecords> Records { get; set; }
        public class GetRecordsResponseBodyRecords : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
