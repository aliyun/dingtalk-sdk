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
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentGroup> Group { get; set; }
            public class QueryUserInfoResponseBodyContentGroup : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptId")]
                [Validation(Required=false)]
                public long? DeptId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("relId")]
                [Validation(Required=false)]
                public long? RelId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJob Job { get; set; }
            public class QueryUserInfoResponseBodyContentJob : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJobStatus JobStatus { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatus : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jobStatusList")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentJobStatusList> JobStatusList { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatusList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentUserProb UserProb { get; set; }
            public class QueryUserInfoResponseBodyContentUserProb : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

        }

    }

}
