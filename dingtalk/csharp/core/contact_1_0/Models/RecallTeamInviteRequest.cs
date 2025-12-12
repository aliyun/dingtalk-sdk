// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class RecallTeamInviteRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>13336082715</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

    }

}
