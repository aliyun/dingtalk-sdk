// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class RecallOfficialAccountOTOMessageRequest : TeaModel {
        /// <summary>
        /// 帐号ID 可空
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 消息推送时返回的ID
        /// </summary>
        [NameInMap("openPushId")]
        [Validation(Required=false)]
        public string OpenPushId { get; set; }

    }

}
