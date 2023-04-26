// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryUserInfoResponseBodyContent Content { get; set; }
        public class QueryUserInfoResponseBodyContent : TeaModel {
            [NameInMap("comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            [NameInMap("dept")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentDept> Dept { get; set; }
            public class QueryUserInfoResponseBodyContentDept : TeaModel {
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            [NameInMap("group")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentGroup> Group { get; set; }
            public class QueryUserInfoResponseBodyContentGroup : TeaModel {
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJob Job { get; set; }
            public class QueryUserInfoResponseBodyContentJob : TeaModel {
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJobStatus JobStatus { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatus : TeaModel {
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("jobStatusList")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentJobStatusList> JobStatusList { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatusList : TeaModel {
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentUserProb UserProb { get; set; }
            public class QueryUserInfoResponseBodyContentUserProb : TeaModel {
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

        }

    }

}
