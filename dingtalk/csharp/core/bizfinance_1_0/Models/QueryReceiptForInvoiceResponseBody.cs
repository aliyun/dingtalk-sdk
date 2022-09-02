// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptForInvoiceResponseBody : TeaModel {
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
        public List<QueryReceiptForInvoiceResponseBodyList> List { get; set; }
        public class QueryReceiptForInvoiceResponseBodyList : TeaModel {
            /// <summary>
            /// 金额
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 开票状态
            /// </summary>
            [NameInMap("applyStatus")]
            [Validation(Required=false)]
            public string ApplyStatus { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public QueryReceiptForInvoiceResponseBodyListCreator Creator { get; set; }
            public class QueryReceiptForInvoiceResponseBodyListCreator : TeaModel {
                /// <summary>
                /// 创建人头像
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// 创建人昵称
                /// </summary>
                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// 创建人工号
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 客户
            /// </summary>
            [NameInMap("customer")]
            [Validation(Required=false)]
            public QueryReceiptForInvoiceResponseBodyListCustomer Customer { get; set; }
            public class QueryReceiptForInvoiceResponseBodyListCustomer : TeaModel {
                /// <summary>
                /// 客户code
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 客户名字
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// 发票种类
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// 主数据modelId
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// 购方账户
            /// </summary>
            [NameInMap("purchaserAccount")]
            [Validation(Required=false)]
            public string PurchaserAccount { get; set; }

            /// <summary>
            /// 购方地址
            /// </summary>
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            /// <summary>
            /// 购方银行
            /// </summary>
            [NameInMap("purchaserBankName")]
            [Validation(Required=false)]
            public string PurchaserBankName { get; set; }

            /// <summary>
            /// 购方抬头
            /// </summary>
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// 购方税号
            /// </summary>
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// 购方电话
            /// </summary>
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

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

            /// <summary>
            /// 单据标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
