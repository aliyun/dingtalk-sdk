// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserAppVersionSummaryResponseBody : TeaModel {
        /// <summary>
        /// 用户版本分布情况列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserAppVersionSummaryResponseBodyData> Data { get; set; }
        public class GetUserAppVersionSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// 统计日期
            /// </summary>
            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// 组织名称
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 端信息
            /// </summary>
            [NameInMap("client")]
            [Validation(Required=false)]
            public string Client { get; set; }

            /// <summary>
            /// 版本信息
            /// </summary>
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// 用户数
            /// </summary>
            [NameInMap("userCnt")]
            [Validation(Required=false)]
            public float? UserCnt { get; set; }

        }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次请求的分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
