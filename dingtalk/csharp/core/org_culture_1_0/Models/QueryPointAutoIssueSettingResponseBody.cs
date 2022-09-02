// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointAutoIssueSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointAutoIssueSettingResponseBodyResult Result { get; set; }
        public class QueryPointAutoIssueSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// 企业每月额度自动发放给每个人的数量
            /// </summary>
            [NameInMap("pointAutoNum")]
            [Validation(Required=false)]
            public long? PointAutoNum { get; set; }

            /// <summary>
            /// 企业积分自动发放状态
            /// </summary>
            [NameInMap("pointAutoState")]
            [Validation(Required=false)]
            public bool? PointAutoState { get; set; }

            /// <summary>
            /// 企业积分自动发放时间 指定的是每月1号或15号
            /// </summary>
            [NameInMap("pointAutoTime")]
            [Validation(Required=false)]
            public long? PointAutoTime { get; set; }

        }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
