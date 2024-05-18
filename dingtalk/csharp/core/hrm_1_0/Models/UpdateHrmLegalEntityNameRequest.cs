// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateHrmLegalEntityNameRequest : TeaModel {
        [NameInMap("dingTenantId")]
        [Validation(Required=false)]
        public long? DingTenantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("legalEntityName")]
        [Validation(Required=false)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originLegalEntityName")]
        [Validation(Required=false)]
        public string OriginLegalEntityName { get; set; }

    }

}
