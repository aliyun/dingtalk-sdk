// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class QueryPluginRuleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPluginRuleResponseBodyResult Result { get; set; }
        public class QueryPluginRuleResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryPluginRuleResponseBodyResultData> Data { get; set; }
            public class QueryPluginRuleResponseBodyResultData : TeaModel {
                [NameInMap("bizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("chatType")]
                [Validation(Required=false)]
                public string ChatType { get; set; }

                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

            }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
