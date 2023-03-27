// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchUserTaskRequest : TeaModel {
        /// <summary>
        /// 每页返回最大数量。默认10，最大100。
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
        /// 用户的任务角色, creator,executor,involveMember 中的一个或多个,以 ','拼接。例如：creator,executor。
        /// </summary>
        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public string RoleTypes { get; set; }

        /// <summary>
        /// tql，参考项目内的tql使用说明。
        /// </summary>
        [NameInMap("tql")]
        [Validation(Required=false)]
        public string Tql { get; set; }

    }

}
