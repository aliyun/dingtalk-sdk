// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// 是否还有数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryReceiptsBaseInfoResponseBodyList> List { get; set; }
        public class QueryReceiptsBaseInfoResponseBodyList : TeaModel {
            /// <summary>
            /// 金额
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
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
            };

            /// <summary>
            /// 客户
            /// </summary>
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
            };

            /// <summary>
            /// 主数据modelId
            /// </summary>
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
            };

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
            };

            /// <summary>
            /// 单据ID
            /// </summary>
            [NameInMap("receiptId")]
            [Validation(Required=false)]
            public string ReceiptId { get; set; }

            /// <summary>
            /// 记录时间，默认为审批通过时间
            /// </summary>
            [NameInMap("recordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 来源
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// 状态 agree running
            /// </summary>
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
            };

            /// <summary>
            /// 单据标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
