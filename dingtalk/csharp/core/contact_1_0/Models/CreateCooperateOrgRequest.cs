// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class CreateCooperateOrgRequest : TeaModel {
        /// <summary>
        /// 合作空间组织名称
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 合作空间的logo
        /// </summary>
        [NameInMap("logoMediaId")]
        [Validation(Required=false)]
        public string LogoMediaId { get; set; }

        /// <summary>
        /// 行业code
        /// </summary>
        [NameInMap("industryCode")]
        [Validation(Required=false)]
        public long? IndustryCode { get; set; }

    }

}
