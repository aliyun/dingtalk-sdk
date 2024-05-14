// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CreateOpportunityRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("belongToPhoneNum")]
        [Validation(Required=false)]
        public string BelongToPhoneNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contactPhoneNum")]
        [Validation(Required=false)]
        public string ContactPhoneNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("marketCode")]
        [Validation(Required=false)]
        public string MarketCode { get; set; }

    }

}
