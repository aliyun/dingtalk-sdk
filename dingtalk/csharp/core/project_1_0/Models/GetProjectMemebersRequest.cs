// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersRequest : TeaModel {
        /// <summary>
        /// 每页返回最大数量。默认10，最大300。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 项目角色ID，仅查询拥有该角色的成员，并且仅支持单个角色查询。
        /// </summary>
        [NameInMap("projectRoleId")]
        [Validation(Required=false)]
        public string ProjectRoleId { get; set; }

        /// <summary>
        /// 跳过的数据数量。
        /// </summary>
        [NameInMap("skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// 如果传递，仅查询这些用户ID， 用逗号组合。
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
