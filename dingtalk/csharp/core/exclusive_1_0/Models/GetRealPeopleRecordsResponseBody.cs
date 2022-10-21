// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetRealPeopleRecordsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetRealPeopleRecordsResponseBodyData> Data { get; set; }
        public class GetRealPeopleRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// agentId
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// 接口调用时间(毫秒时间戳)
            /// </summary>
            [NameInMap("invokeTime")]
            [Validation(Required=false)]
            public long? InvokeTime { get; set; }

            /// <summary>
            /// 实人认证结果 1-成功 2-失败
            /// </summary>
            [NameInMap("personIdentification")]
            [Validation(Required=false)]
            public int? PersonIdentification { get; set; }

            /// <summary>
            /// 平台 0-Android 或 1-iOS
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            /// <summary>
            /// 1. 姓名匹配阶段失败 2. 认证阶段失败 3. 实人流程阶段失败 4. 协议签署阶段失败 5. 人脸录入阶段失败 6. 人脸录入阶段用户主动取消 7. 人脸录入阶段成功 8. 人脸识别阶段失败 9. 人脸识别阶段主动取消 10. 人脸识别阶段成功  11.去实人场景
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public int? Scene { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 下一次拉取启始值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 总数据数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
