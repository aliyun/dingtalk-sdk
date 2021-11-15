// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateReceiptRequest : TeaModel {
        /// <summary>
        /// 单据列表 ，最长10
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<UpdateReceiptRequestReceipts> Receipts { get; set; }
        public class UpdateReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// 修改者工号
            /// </summary>
            [NameInMap("updateUserId")]
            [Validation(Required=false)]
            public string UpdateUserId { get; set; }

            /// <summary>
            /// 单据唯一编号
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 单据标题，传空代表不修改
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 单据更新时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// 业务发生时间，传空代表不修改
            /// </summary>
            [NameInMap("occurDate")]
            [Validation(Required=false)]
            public long? OccurDate { get; set; }

            /// <summary>
            /// 总金额，传空代表不修改
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 单据类型：1付款单，2收款单
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

            /// <summary>
            /// 负责人工号，传空代表不修改
            /// </summary>
            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// 关联收支类别，传空代表不修改
            /// </summary>
            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// 关联项目code，传空代表不修改
            /// </summary>
            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// 关联客户code，传空代表不修改
            /// </summary>
            [NameInMap("customerCode")]
            [Validation(Required=false)]
            public string CustomerCode { get; set; }

            /// <summary>
            /// 关联供应商code，传空代表不修改
            /// </summary>
            [NameInMap("supplierCode")]
            [Validation(Required=false)]
            public string SupplierCode { get; set; }

            /// <summary>
            /// 关联企业账户code，传空代表不修改
            /// </summary>
            [NameInMap("enterpriseAcountCode")]
            [Validation(Required=false)]
            public string EnterpriseAcountCode { get; set; }

            /// <summary>
            /// 备注，传空代表不修改
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

    }

}
