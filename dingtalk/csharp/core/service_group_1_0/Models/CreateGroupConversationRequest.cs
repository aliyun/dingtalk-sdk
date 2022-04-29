// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CreateGroupConversationRequest : TeaModel {
        /// <summary>
        /// 开放corpid
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 钉群openID
        /// </summary>
        [NameInMap("dingGroupId")]
        [Validation(Required=false)]
        public string DingGroupId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 钉群内发起人工服务的客户的ID
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// 钉群内发起人工服务的客户的名称
        /// </summary>
        [NameInMap("dingUserName")]
        [Validation(Required=false)]
        public string DingUserName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extValues")]
        [Validation(Required=false)]
        public string ExtValues { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 小二技能组ID
        /// </summary>
        [NameInMap("serverGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
