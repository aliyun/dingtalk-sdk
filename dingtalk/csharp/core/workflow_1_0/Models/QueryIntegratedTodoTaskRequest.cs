// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryIntegratedTodoTaskRequest : TeaModel {
        /// <summary>
        /// 在此时间戳之前创建的
        /// </summary>
        [NameInMap("createBefore")]
        [Validation(Required=false)]
        public long? CreateBefore { get; set; }

        /// <summary>
        /// 第几页，取值范围为 1 ≤ page ≤ 1000
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页大小，取值范围为 1 ≤ pageSize ≤ 40
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
