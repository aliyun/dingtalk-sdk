// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationCreatedNotifyRequest : TeaModel {
        [NameInMap("alipayUserId")]
        [Validation(Required=false)]
        public string AlipayUserId { get; set; }

        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("nickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eWaJSqDcLsoiE</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("serverName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

        [NameInMap("serverTips")]
        [Validation(Required=false)]
        public string ServerTips { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>对应外部渠道的会话ID</para>
        /// </summary>
        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        [NameInMap("timeoutRemindTips")]
        [Validation(Required=false)]
        public string TimeoutRemindTips { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}
