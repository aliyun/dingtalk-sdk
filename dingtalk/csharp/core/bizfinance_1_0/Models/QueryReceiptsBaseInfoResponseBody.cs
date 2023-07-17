// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsBaseInfoResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryReceiptsBaseInfoResponseBodyList> List { get; set; }
        public class QueryReceiptsBaseInfoResponseBodyList : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListCreator Creator { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListCreator : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("customer")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListCustomer Customer { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListCustomer : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("principal")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListPrincipal Principal { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListPrincipal : TeaModel {
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("project")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListProject Project { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListProject : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("receiptId")]
            [Validation(Required=false)]
            public string ReceiptId { get; set; }

            [NameInMap("recordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("supplier")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListSupplier Supplier { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListSupplier : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
