// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class OrderBillingRequest : TeaModel {
        [NameInMap("additionInfos")]
        [Validation(Required=false)]
        public List<OrderBillingRequestAdditionInfos> AdditionInfos { get; set; }
        public class OrderBillingRequestAdditionInfos : TeaModel {
            [NameInMap("additionContent")]
            [Validation(Required=false)]
            public string AdditionContent { get; set; }

            [NameInMap("additionName")]
            [Validation(Required=false)]
            public string AdditionName { get; set; }

            [NameInMap("dataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("applyPerson")]
        [Validation(Required=false)]
        public string ApplyPerson { get; set; }

        [NameInMap("invoiceRemark")]
        [Validation(Required=false)]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>VAT_NORMAL_E</para>
        /// </summary>
        [NameInMap("invoiceType")]
        [Validation(Required=false)]
        public string InvoiceType { get; set; }

        [NameInMap("isNaturalPerson")]
        [Validation(Required=false)]
        public bool? IsNaturalPerson { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("payee")]
        [Validation(Required=false)]
        public string Payee { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("products")]
        [Validation(Required=false)]
        public List<OrderBillingRequestProducts> Products { get; set; }
        public class OrderBillingRequestProducts : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12.55</para>
            /// </summary>
            [NameInMap("amountWithTax")]
            [Validation(Required=false)]
            public string AmountWithTax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>面包</para>
            /// </summary>
            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            [NameInMap("revenueCode")]
            [Validation(Required=false)]
            public string RevenueCode { get; set; }

            [NameInMap("specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>个</para>
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19.99</para>
            /// </summary>
            [NameInMap("unitPrice")]
            [Validation(Required=false)]
            public string UnitPrice { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省杭州市XXX街道</para>
        /// </summary>
        [NameInMap("purchaserAddress")]
        [Validation(Required=false)]
        public string PurchaserAddress { get; set; }

        [NameInMap("purchaserBankAccount")]
        [Validation(Required=false)]
        public string PurchaserBankAccount { get; set; }

        [NameInMap("purchaserBankName")]
        [Validation(Required=false)]
        public string PurchaserBankName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX公司</para>
        /// </summary>
        [NameInMap("purchaserName")]
        [Validation(Required=false)]
        public string PurchaserName { get; set; }

        [NameInMap("purchaserTaxNo")]
        [Validation(Required=false)]
        public string PurchaserTaxNo { get; set; }

        [NameInMap("purchaserTel")]
        [Validation(Required=false)]
        public string PurchaserTel { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("taxSign")]
        [Validation(Required=false)]
        public int? TaxSign { get; set; }

    }

}
