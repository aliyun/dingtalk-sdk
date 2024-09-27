// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateReceiptRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receipts")]
        [Validation(Required=false)]
        public List<UpdateReceiptRequestReceipts> Receipts { get; set; }
        public class UpdateReceiptRequestReceipts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2.44</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INC_XXX</para>
            /// </summary>
            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd_efgh</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUS_XXX</para>
            /// </summary>
            [NameInMap("customerCode")]
            [Validation(Required=false)]
            public string CustomerCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACC_XXX</para>
            /// </summary>
            [NameInMap("enterpriseAcountCode")]
            [Validation(Required=false)]
            public string EnterpriseAcountCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1636445218000</para>
            /// </summary>
            [NameInMap("occurDate")]
            [Validation(Required=false)]
            public long? OccurDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>emp_xxx</para>
            /// </summary>
            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROJ_XXX</para>
            /// </summary>
            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试单据</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUP_XXX</para>
            /// </summary>
            [NameInMap("supplierCode")]
            [Validation(Required=false)]
            public string SupplierCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>付款单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1636445218000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emp_xxx</para>
            /// </summary>
            [NameInMap("updateUserId")]
            [Validation(Required=false)]
            public string UpdateUserId { get; set; }

        }

    }

}
