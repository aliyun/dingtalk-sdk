// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryTaskOfProjectRequest : TeaModel {
        /// <summary>
        /// 每页返回最大数量。默认10，最大500。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 供分页使用，下一页token，从当前页结果中获取。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询条件。如：“content ~ 标题1” 表示查询任务标题包含“标题1”的任务；“executor=05178xxxxx” 表示执行者是05178xxxx的任务；”involveMembers NOT IN["061xx","06112xx"] AND executorId=0673xxx AND content~标题2“ 表示查询参与者不是”061xx“和”06112xx“ 并且 执行者是0673xxx 并且 标题类似 ”标题2“的所有任务。
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
