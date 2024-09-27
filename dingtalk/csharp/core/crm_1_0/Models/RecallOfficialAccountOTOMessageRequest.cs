// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class RecallOfficialAccountOTOMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SWXXX</para>
        /// </summary>
        [NameInMap("openPushId")]
        [Validation(Required=false)]
        public string OpenPushId { get; set; }

    }

}
