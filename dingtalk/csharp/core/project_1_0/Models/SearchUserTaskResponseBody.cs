// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskResponseBody : TeaModel {
        /// <summary>
        /// 分页标，供分页使用，下一页token。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求 ID，请求异常时可提供此 ID，进行问题排查。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务ID列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<string> Result { get; set; }

        /// <summary>
        /// 任务总数。
        /// </summary>
        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
