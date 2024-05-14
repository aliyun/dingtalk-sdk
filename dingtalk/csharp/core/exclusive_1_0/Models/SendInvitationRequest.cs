// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SendInvitationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgAlias")]
        [Validation(Required=false)]
        public string OrgAlias { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("partnerLabelId")]
        [Validation(Required=false)]
        public long? PartnerLabelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("partnerNum")]
        [Validation(Required=false)]
        public string PartnerNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
