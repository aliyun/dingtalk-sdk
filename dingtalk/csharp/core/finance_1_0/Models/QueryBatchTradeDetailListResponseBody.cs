// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeDetailListResponseBody : TeaModel {
        /// <summary>
        /// 明细列表
        /// </summary>
        [NameInMap("batchTradeDetailList")]
        [Validation(Required=false)]
        public List<QueryBatchTradeDetailListResponseBodyBatchTradeDetailList> BatchTradeDetailList { get; set; }
        public class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList : TeaModel {
            /// <summary>
            /// 序号
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public long? SerialNo { get; set; }

            /// <summary>
            /// 明细单号
            /// </summary>
            [NameInMap("detailNo")]
            [Validation(Required=false)]
            public string DetailNo { get; set; }

            /// <summary>
            /// 收款人账号
            /// </summary>
            [NameInMap("payeeAccountNo")]
            [Validation(Required=false)]
            public string PayeeAccountNo { get; set; }

            /// <summary>
            /// 收款账号类型
            /// </summary>
            [NameInMap("payeeAccountType")]
            [Validation(Required=false)]
            public string PayeeAccountType { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 收款方电子钱包持有者姓名
            /// </summary>
            [NameInMap("payeeAccountName")]
            [Validation(Required=false)]
            public string PayeeAccountName { get; set; }

            /// <summary>
            /// 金额
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// 订单时间时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 支付完成时间
            /// </summary>
            [NameInMap("gmtFinish")]
            [Validation(Required=false)]
            public string GmtFinish { get; set; }

        }

        /// <summary>
        /// 当前页数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 单页条数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [NameInMap("totalPageNumber")]
        [Validation(Required=false)]
        public int? TotalPageNumber { get; set; }

    }

}
