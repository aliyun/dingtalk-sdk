// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountOTOMessageResultRequest : TeaModel {
        /// <summary>
        /// 推送ID
        /// </summary>
        [NameInMap("openPushId")]
        [Validation(Required=false)]
        public string OpenPushId { get; set; }

        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
