// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryAccountTradeByPageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryAccountTradeByPageResponseBodyResult> Result { get; set; }
        public class QueryAccountTradeByPageResponseBodyResult : TeaModel {
            [NameInMap("balance")]
            [Validation(Required=false)]
            public string Balance { get; set; }

            [NameInMap("detailId")]
            [Validation(Required=false)]
            public string DetailId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("instanceTitle")]
            [Validation(Required=false)]
            public string InstanceTitle { get; set; }

            [NameInMap("instanceUrl")]
            [Validation(Required=false)]
            public string InstanceUrl { get; set; }

            [NameInMap("otherAccountName")]
            [Validation(Required=false)]
            public string OtherAccountName { get; set; }

            [NameInMap("otherAccountNo")]
            [Validation(Required=false)]
            public string OtherAccountNo { get; set; }

            [NameInMap("receiptFile")]
            [Validation(Required=false)]
            public QueryAccountTradeByPageResponseBodyResultReceiptFile ReceiptFile { get; set; }
            public class QueryAccountTradeByPageResponseBodyResultReceiptFile : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("previewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

            }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("tradeAmount")]
            [Validation(Required=false)]
            public string TradeAmount { get; set; }

            [NameInMap("tradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }

            [NameInMap("tradeTime")]
            [Validation(Required=false)]
            public long? TradeTime { get; set; }

            [NameInMap("tradeType")]
            [Validation(Required=false)]
            public string TradeType { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
