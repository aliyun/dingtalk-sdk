// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class BatchInsertBizObjectResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchInsertBizObjectResponseBodyData Data { get; set; }
        public class BatchInsertBizObjectResponseBodyData : TeaModel {
            /// <summary>
            /// 成功新增的业务对象id数组
            /// </summary>
            [NameInMap("bizObjectIds")]
            [Validation(Required=false)]
            public List<string> BizObjectIds { get; set; }

            /// <summary>
            /// 新增失败的数据数组
            /// </summary>
            [NameInMap("failedDatas")]
            [Validation(Required=false)]
            public List<string> FailedDatas { get; set; }

            /// <summary>
            /// 失败的提示信息数组
            /// </summary>
            [NameInMap("failedMessages")]
            [Validation(Required=false)]
            public List<string> FailedMessages { get; set; }

            /// <summary>
            /// 新增成功的流程实例id数组
            /// </summary>
            [NameInMap("processIds")]
            [Validation(Required=false)]
            public List<string> ProcessIds { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
