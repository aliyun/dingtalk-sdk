// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetApplyInviteInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("auditType")]
        [Validation(Required=false)]
        public long? AuditType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("empApplyJoinDept")]
        [Validation(Required=false)]
        public bool? EmpApplyJoinDept { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inviteSwitch")]
        [Validation(Required=false)]
        public bool? InviteSwitch { get; set; }

        [NameInMap("inviteUrl")]
        [Validation(Required=false)]
        public string InviteUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("linkInvite")]
        [Validation(Required=false)]
        public bool? LinkInvite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("orgApplyCodeInvite")]
        [Validation(Required=false)]
        public bool? OrgApplyCodeInvite { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("searchNameInvite")]
        [Validation(Required=false)]
        public bool? SearchNameInvite { get; set; }

    }

}
