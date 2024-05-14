// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionRoleMemberRequest : TeaModel {
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleCodeList")]
        [Validation(Required=false)]
        public List<string> RoleCodeList { get; set; }

    }

}
