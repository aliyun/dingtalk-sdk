// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CheckOpportunityResultRequest : TeaModel {
        /// <summary>
        /// corpId
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// belongToPhoneNum
        /// </summary>
        [NameInMap("belongToPhoneNum")]
        [Validation(Required=false)]
        public string BelongToPhoneNum { get; set; }

        /// <summary>
        /// contactPhoneNum
        /// </summary>
        [NameInMap("contactPhoneNum")]
        [Validation(Required=false)]
        public string ContactPhoneNum { get; set; }

        /// <summary>
        /// deptId
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// marketCode
        /// </summary>
        [NameInMap("marketCode")]
        [Validation(Required=false)]
        public string MarketCode { get; set; }

    }

}
