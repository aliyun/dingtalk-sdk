// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataTenantQueyRequest : TeaModel {
        /// <summary>
        /// 实体 code
        /// </summary>
        [NameInMap("entityCode")]
        [Validation(Required=false)]
        public string EntityCode { get; set; }

        /// <summary>
        /// isv的业务领域
        /// </summary>
        [NameInMap("scopeCode")]
        [Validation(Required=false)]
        public string ScopeCode { get; set; }

    }

}
