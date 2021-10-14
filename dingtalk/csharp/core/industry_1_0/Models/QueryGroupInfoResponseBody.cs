// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// 医疗组详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryGroupInfoResponseBodyContent Content { get; set; }
        public class QueryGroupInfoResponseBodyContent : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("leader")]
            [Validation(Required=false)]
            public QueryGroupInfoResponseBodyContentLeader Leader { get; set; }
            public class QueryGroupInfoResponseBodyContentLeader : TeaModel {
                /// <summary>
                /// 工作标签
                /// </summary>
                [NameInMap("job")]
                [Validation(Required=false)]
                public QueryGroupInfoResponseBodyContentLeaderJob Job { get; set; }
                public class QueryGroupInfoResponseBodyContentLeaderJob : TeaModel {
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
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
        };

    }

}
