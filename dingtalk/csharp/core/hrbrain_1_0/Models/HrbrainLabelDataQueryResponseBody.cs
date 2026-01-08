// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainLabelDataQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainLabelDataQueryResponseBodyContent Content { get; set; }
        public class HrbrainLabelDataQueryResponseBodyContent : TeaModel {
            [NameInMap("labelDatas")]
            [Validation(Required=false)]
            public List<HrbrainLabelDataQueryResponseBodyContentLabelDatas> LabelDatas { get; set; }
            public class HrbrainLabelDataQueryResponseBodyContentLabelDatas : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("deptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("jobLevel")]
                [Validation(Required=false)]
                public string JobLevel { get; set; }

                [NameInMap("labelTitle")]
                [Validation(Required=false)]
                public string LabelTitle { get; set; }

                [NameInMap("labelValue")]
                [Validation(Required=false)]
                public string LabelValue { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("postName")]
                [Validation(Required=false)]
                public string PostName { get; set; }

                [NameInMap("workNo")]
                [Validation(Required=false)]
                public string WorkNo { get; set; }

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
