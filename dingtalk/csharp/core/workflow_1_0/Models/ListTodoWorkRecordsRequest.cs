// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListTodoWorkRecordsRequest : TeaModel {
        /// <summary>
        /// 分页大小，最大值50。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页游标。
        /// 
        /// 如果是首次调用，该参数传0。
        /// 如果是非首次调用，该参数传上次调用时返回的nextToken。
        /// 
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// 待办事项的状态：
        /// 
        /// 0：待处理
        /// 
        /// -1：已经移除
        /// 
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// 要查询的执行人userid。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
