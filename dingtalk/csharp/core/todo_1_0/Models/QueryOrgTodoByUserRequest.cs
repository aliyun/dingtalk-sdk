// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class QueryOrgTodoByUserRequest : TeaModel {
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
        /// 每页数量。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询目标用户角色类型，执行人 | 创建人 | 参与人，可以同时传多个值。如：[["executor"], ["creator"],["participant"]] 或 [["executor", "creator"]]
        /// </summary>
        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public List<List<string>> RoleTypes { get; set; }

        /// <summary>
        /// 待办标题
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 查询到计划完成时间结束
        /// </summary>
        [NameInMap("toDueTime")]
        [Validation(Required=false)]
        public long? ToDueTime { get; set; }

    }

}
