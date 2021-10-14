// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentInfoResponseBody : TeaModel {
        /// <summary>
        /// 科室详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryDepartmentInfoResponseBodyContent Content { get; set; }
        public class QueryDepartmentInfoResponseBodyContent : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("leader")]
            [Validation(Required=false)]
            public QueryDepartmentInfoResponseBodyContentLeader Leader { get; set; }
            public class QueryDepartmentInfoResponseBodyContentLeader : TeaModel {
                /// <summary>
                /// 工作标签
                /// </summary>
                [NameInMap("job")]
                [Validation(Required=false)]
                public QueryDepartmentInfoResponseBodyContentLeaderJob Job { get; set; }
                public class QueryDepartmentInfoResponseBodyContentLeaderJob : TeaModel {
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
                };

                /// <summary>
                /// 工号
                /// </summary>
                [NameInMap("jobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

                /// <summary>
                /// 姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 人员Id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("residentLeader")]
            [Validation(Required=false)]
            public QueryDepartmentInfoResponseBodyContentResidentLeader ResidentLeader { get; set; }
            public class QueryDepartmentInfoResponseBodyContentResidentLeader : TeaModel {
                /// <summary>
                /// 工作标签
                /// </summary>
                [NameInMap("job")]
                [Validation(Required=false)]
                public QueryDepartmentInfoResponseBodyContentResidentLeaderJob Job { get; set; }
                public class QueryDepartmentInfoResponseBodyContentResidentLeaderJob : TeaModel {
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
                };

                /// <summary>
                /// 工号
                /// </summary>
                [NameInMap("jobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

                /// <summary>
                /// 姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 人员Id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }
        };

    }

}
