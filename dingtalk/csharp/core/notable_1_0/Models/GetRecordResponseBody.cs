// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class GetRecordResponseBody : TeaModel {
        [NameInMap("createdBy")]
        [Validation(Required=false)]
        public GetRecordResponseBodyCreatedBy CreatedBy { get; set; }
        public class GetRecordResponseBodyCreatedBy : TeaModel {
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
        public GetRecordResponseBodyLastModifiedBy LastModifiedBy { get; set; }
        public class GetRecordResponseBodyLastModifiedBy : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public long? LastModifiedTime { get; set; }

    }

}
