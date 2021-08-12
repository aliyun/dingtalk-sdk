// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoTasksRequest : TeaModel {
        /// <summary>
        /// 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 待办完成状态。
        /// </summary>
        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

    }

}
