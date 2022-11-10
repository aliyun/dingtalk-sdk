// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryGroupMemberRequest : TeaModel {
        /// <summary>
        /// 每页条数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 群会话ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
