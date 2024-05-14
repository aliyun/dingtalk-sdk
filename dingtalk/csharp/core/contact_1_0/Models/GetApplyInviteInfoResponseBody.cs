// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetApplyInviteInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("auditType")]
        [Validation(Required=false)]
        public long? AuditType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("empApplyJoinDept")]
        [Validation(Required=false)]
        public bool? EmpApplyJoinDept { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("inviteSwitch")]
        [Validation(Required=false)]
        public bool? InviteSwitch { get; set; }

        [NameInMap("inviteUrl")]
        [Validation(Required=false)]
        public string InviteUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("linkInvite")]
        [Validation(Required=false)]
        public bool? LinkInvite { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgApplyCodeInvite")]
        [Validation(Required=false)]
        public bool? OrgApplyCodeInvite { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("searchNameInvite")]
        [Validation(Required=false)]
        public bool? SearchNameInvite { get; set; }

    }

}
