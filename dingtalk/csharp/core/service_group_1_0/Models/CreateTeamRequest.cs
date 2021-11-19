// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateTeamRequest : TeaModel {
        /// <summary>
        /// 团队管理员钉钉uid
        /// </summary>
        [NameInMap("creatorDingUid")]
        [Validation(Required=false)]
        public long? CreatorDingUid { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 团队名字
        /// </summary>
        [NameInMap("teamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

    }

}
