// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class CheckOpportunityResultRequest : TeaModel {
        [NameInMap("belongToPhoneNum")]
        [Validation(Required=false)]
        public string BelongToPhoneNum { get; set; }

        [NameInMap("contactPhoneNum")]
        [Validation(Required=false)]
        public string ContactPhoneNum { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("marketCode")]
        [Validation(Required=false)]
        public string MarketCode { get; set; }

    }

}
