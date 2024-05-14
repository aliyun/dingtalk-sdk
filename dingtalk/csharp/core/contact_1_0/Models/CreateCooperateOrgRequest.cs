// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateCooperateOrgRequest : TeaModel {
        [NameInMap("industryCode")]
        [Validation(Required=false)]
        public long? IndustryCode { get; set; }

        [NameInMap("logoMediaId")]
        [Validation(Required=false)]
        public string LogoMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

    }

}
