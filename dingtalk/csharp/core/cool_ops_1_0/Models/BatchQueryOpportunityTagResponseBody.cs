// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_ops_1_0.Models
{
    public class BatchQueryOpportunityTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchQueryOpportunityTagResponseBodyResult Result { get; set; }
        public class BatchQueryOpportunityTagResponseBodyResult : TeaModel {
            [NameInMap("opportunityList")]
            [Validation(Required=false)]
            public List<BatchQueryOpportunityTagResponseBodyResultOpportunityList> OpportunityList { get; set; }
            public class BatchQueryOpportunityTagResponseBodyResultOpportunityList : TeaModel {
                [NameInMap("activeUserCnt7d")]
                [Validation(Required=false)]
                public long? ActiveUserCnt7d { get; set; }

                [NameInMap("appActiveState")]
                [Validation(Required=false)]
                public string AppActiveState { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("fstFunnelsourceNameLv1")]
                [Validation(Required=false)]
                public string FstFunnelsourceNameLv1 { get; set; }

                [NameInMap("funnelsourceNameLv1")]
                [Validation(Required=false)]
                public string FunnelsourceNameLv1 { get; set; }

            }

        }

    }

}
