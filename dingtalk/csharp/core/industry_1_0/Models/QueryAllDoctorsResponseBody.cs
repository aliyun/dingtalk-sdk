// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryAllDoctorsResponseBody : TeaModel {
        /// <summary>
        /// 人员列表
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryAllDoctorsResponseBodyContent> Content { get; set; }
        public class QueryAllDoctorsResponseBodyContent : TeaModel {
            /// <summary>
            /// 钉钉staffId
            /// </summary>
            [NameInMap("staffId")]
            [Validation(Required=false)]
            public string StaffId { get; set; }

            /// <summary>
            /// 用户Id
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 职称标签
            /// </summary>
            [NameInMap("job")]
            [Validation(Required=false)]
            public QueryAllDoctorsResponseBodyContentJob Job { get; set; }
            public class QueryAllDoctorsResponseBodyContentJob : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
            };

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("jobNum")]
            [Validation(Required=false)]
            public string JobNum { get; set; }

            /// <summary>
            /// 工作状态标签
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public QueryAllDoctorsResponseBodyContentJobStatus JobStatus { get; set; }
            public class QueryAllDoctorsResponseBodyContentJobStatus : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
            };

            /// <summary>
            /// 人员属性标签
            /// </summary>
            [NameInMap("userProb")]
            [Validation(Required=false)]
            public QueryAllDoctorsResponseBodyContentUserProb UserProb { get; set; }
            public class QueryAllDoctorsResponseBodyContentUserProb : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }
                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }
            };

        }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 数据总量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

    }

}
