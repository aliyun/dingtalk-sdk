// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UpdateInvoiceVerifyStatusRequest : TeaModel {
        /// <summary>
        /// 查验流水号
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 查验结果
        /// </summary>
        [NameInMap("checkingResult")]
        [Validation(Required=false)]
        public int? CheckingResult { get; set; }

        /// <summary>
        /// 查验状态
        /// </summary>
        [NameInMap("checkingStatus")]
        [Validation(Required=false)]
        public int? CheckingStatus { get; set; }

        /// <summary>
        /// 业务响应码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 企业Id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 发票代码
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
        /// 发票状态
        /// </summary>
        [NameInMap("invoiceStatus")]
        [Validation(Required=false)]
        public int? InvoiceStatus { get; set; }

        /// <summary>
        /// 发票验真编号
        /// </summary>
        [NameInMap("invoiceVerifyId")]
        [Validation(Required=false)]
        public string InvoiceVerifyId { get; set; }

        /// <summary>
        /// 响应信息
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
