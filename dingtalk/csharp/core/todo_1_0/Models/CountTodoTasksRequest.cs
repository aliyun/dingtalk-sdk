// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CountTodoTasksRequest : TeaModel {
        /// <summary>
        /// 所属分类
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// 查询从计划完成时间开始
        /// </summary>
        [NameInMap("fromDueTime")]
        [Validation(Required=false)]
        public long? FromDueTime { get; set; }

        /// <summary>
        /// 待办完成状态。
        /// </summary>
        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        /// <summary>
        /// 待办回收状态
        /// </summary>
        [NameInMap("isRecycled")]
        [Validation(Required=false)]
        public bool? IsRecycled { get; set; }

        /// <summary>
        /// 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
        /// </summary>
        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public List<List<string>> RoleTypes { get; set; }

        /// <summary>
        /// 查询到计划完成时间结束
        /// </summary>
        [NameInMap("toDueTime")]
        [Validation(Required=false)]
        public long? ToDueTime { get; set; }

    }

}
