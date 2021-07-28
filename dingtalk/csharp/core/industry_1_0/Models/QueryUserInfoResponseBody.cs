// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserInfoResponseBody : TeaModel {
        /// <summary>
        /// 人员详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryUserInfoResponseBodyContent Content { get; set; }
        public class QueryUserInfoResponseBodyContent : TeaModel {
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentJob Job { get; set; }
            public class QueryUserInfoResponseBodyContentJob : TeaModel {
                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
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
                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }
            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryUserInfoResponseBodyContentUserProb UserProb { get; set; }
            public class QueryUserInfoResponseBodyContentUserProb : TeaModel {
                /// <summary>
                /// 标签Code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 标签类型
                /// </summary>
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// 分类
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// 展示名称
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }
            [NameInMap("group")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentGroup> Group { get; set; }
            public class QueryUserInfoResponseBodyContentGroup : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public long? DeptId { get; set; }
                public string DeptName { get; set; }
            }
            [NameInMap("dept")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentDept> Dept { get; set; }
            public class QueryUserInfoResponseBodyContentDept : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("comments")]
            [Validation(Required=false)]
            public string Comments { get; set; }
            [NameInMap("jobStatusList")]
            [Validation(Required=false)]
            public List<QueryUserInfoResponseBodyContentJobStatusList> JobStatusList { get; set; }
            public class QueryUserInfoResponseBodyContentJobStatusList : TeaModel {
                public string Code { get; set; }
                public string BizType { get; set; }
                public string Category { get; set; }
                public string DisplayName { get; set; }
            }
        };

    }

}
