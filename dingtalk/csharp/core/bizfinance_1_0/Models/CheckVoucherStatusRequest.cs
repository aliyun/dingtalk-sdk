// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class CheckVoucherStatusRequest : TeaModel {
        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 进项发票/销项发票
        /// </summary>
        [NameInMap("financeType")]
        [Validation(Required=false)]
        public string FinanceType { get; set; }

        /// <summary>
        /// 发票编码
        /// </summary>
        [NameInMap("invoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [NameInMap("invoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 当前页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// 发票认证状态
        /// </summary>
        [NameInMap("verifyStatus")]
        [Validation(Required=false)]
        public string VerifyStatus { get; set; }

    }

}
