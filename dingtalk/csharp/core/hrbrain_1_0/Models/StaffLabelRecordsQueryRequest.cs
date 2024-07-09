// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class StaffLabelRecordsQueryRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<StaffLabelRecordsQueryRequestBody> Body { get; set; }
        public class StaffLabelRecordsQueryRequestBody : TeaModel {
            [NameInMap("labels")]
            [Validation(Required=false)]
            public List<StaffLabelRecordsQueryRequestBodyLabels> Labels { get; set; }
            public class StaffLabelRecordsQueryRequestBodyLabels : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("typeCode")]
                [Validation(Required=false)]
                public string TypeCode { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
