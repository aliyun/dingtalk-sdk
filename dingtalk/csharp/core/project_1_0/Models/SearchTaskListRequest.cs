// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskListRequest : TeaModel {
        /// <summary>
        /// 每页返回最大数量。默认10，最大300。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页标，从上一次请求结果中获取。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 模糊任务分组名字。
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// 任务分组ID集合，逗号组合。
        /// </summary>
        [NameInMap("taskListIds")]
        [Validation(Required=false)]
        public string TaskListIds { get; set; }

    }

}
