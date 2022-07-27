// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListBasicRoleInPageRequest : TeaModel {
        /// <summary>
        /// 应用的agentId
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// 单页查询的最大条目数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 查询凭证，初始使用0
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
