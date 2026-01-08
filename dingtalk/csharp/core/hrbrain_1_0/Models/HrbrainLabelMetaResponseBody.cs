// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelMetaResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainLabelMetaResponseBodyContent Content { get; set; }
        public class HrbrainLabelMetaResponseBodyContent : TeaModel {
            [NameInMap("labelMetas")]
            [Validation(Required=false)]
            public List<HrbrainLabelMetaResponseBodyContentLabelMetas> LabelMetas { get; set; }
            public class HrbrainLabelMetaResponseBodyContentLabelMetas : TeaModel {
                [NameInMap("categoryCode")]
                [Validation(Required=false)]
                public string CategoryCode { get; set; }

                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("dataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("extendInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendInfo { get; set; }

                [NameInMap("gmtCreated")]
                [Validation(Required=false)]
                public long? GmtCreated { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("importantLevel")]
                [Validation(Required=false)]
                public string ImportantLevel { get; set; }

                [NameInMap("isSensitive")]
                [Validation(Required=false)]
                public bool? IsSensitive { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("options")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> Options { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("useStatus")]
                [Validation(Required=false)]
                public string UseStatus { get; set; }

            }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
