// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListProcessInstanceIdsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListProcessInstanceIdsResponseBodyResult Result { get; set; }
        public class ListProcessInstanceIdsResponseBodyResult : TeaModel {
            /// <summary>
            /// 审批实例ID列表。
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<string> List { get; set; }

            /// <summary>
            /// 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// 接口请求是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
