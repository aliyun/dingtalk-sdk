// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryUserHonorsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserHonorsResponseBodyResult Result { get; set; }
        public class QueryUserHonorsResponseBodyResult : TeaModel {
            [NameInMap("honors")]
            [Validation(Required=false)]
            public List<QueryUserHonorsResponseBodyResultHonors> Honors { get; set; }
            public class QueryUserHonorsResponseBodyResultHonors : TeaModel {
                /// <summary>
                /// 有效期截止时间点，没有该属性则为永久生效
                /// </summary>
                [NameInMap("expirationTime")]
                [Validation(Required=false)]
                public long? ExpirationTime { get; set; }

                /// <summary>
                /// 授予历史记录 包含用户及授予时间
                /// </summary>
                [NameInMap("grantHistory")]
                [Validation(Required=false)]
                public List<QueryUserHonorsResponseBodyResultHonorsGrantHistory> GrantHistory { get; set; }
                public class QueryUserHonorsResponseBodyResultHonorsGrantHistory : TeaModel {
                    /// <summary>
                    /// 授予时间 时间戳
                    /// </summary>
                    [NameInMap("grantTime")]
                    [Validation(Required=false)]
                    public long? GrantTime { get; set; }

                    /// <summary>
                    /// 必须。荣誉发放人userid
                    /// </summary>
                    [NameInMap("senderUserid")]
                    [Validation(Required=false)]
                    public string SenderUserid { get; set; }

                }

                /// <summary>
                /// 荣誉含义
                /// </summary>
                [NameInMap("honorDesc")]
                [Validation(Required=false)]
                public string HonorDesc { get; set; }

                /// <summary>
                /// 必须。荣誉id
                /// </summary>
                [NameInMap("honorId")]
                [Validation(Required=false)]
                public string HonorId { get; set; }

                /// <summary>
                /// 必须。荣誉名字
                /// </summary>
                [NameInMap("honorName")]
                [Validation(Required=false)]
                public string HonorName { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
