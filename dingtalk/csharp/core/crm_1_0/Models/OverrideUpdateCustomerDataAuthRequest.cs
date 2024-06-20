// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class OverrideUpdateCustomerDataAuthRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("customerIds")]
        [Validation(Required=false)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataAuthUserIds")]
        [Validation(Required=false)]
        public List<string> DataAuthUserIds { get; set; }

        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
