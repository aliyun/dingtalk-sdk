// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptDetailForInvoiceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryReceiptDetailForInvoiceResponseBodyResult Result { get; set; }
        public class QueryReceiptDetailForInvoiceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("accountantBookId")]
            [Validation(Required=false)]
            public string AccountantBookId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4000</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>applied</para>
            /// </summary>
            [NameInMap("applyStatus")]
            [Validation(Required=false)]
            public string ApplyStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>invoicing</para>
            /// </summary>
            [NameInMap("bizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COM_DEFAULT</para>
            /// </summary>
            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public QueryReceiptDetailForInvoiceResponseBodyResultCreator Creator { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxx">https://xxxx</a></para>
                /// </summary>
                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试名字</para>
                /// </summary>
                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1231</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("customer")]
            [Validation(Required=false)]
            public QueryReceiptDetailForInvoiceResponseBodyResultCustomer Customer { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultCustomer : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CUS_xxxxx</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.abc.com">www.abc.com</a></para>
            /// </summary>
            [NameInMap("drawerEmail")]
            [Validation(Required=false)]
            public string DrawerEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678901</para>
            /// </summary>
            [NameInMap("drawerTelephone")]
            [Validation(Required=false)]
            public string DrawerTelephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VAT_NORMAL_E</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EM-xxxxx</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("productInfoList")]
            [Validation(Required=false)]
            public List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> ProductInfoList { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>12.3</para>
                /// </summary>
                [NameInMap("amountWithTax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("amountWithoutTax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("discountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>鱼</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>大型</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("taxClassificationCode")]
                [Validation(Required=false)]
                public string TaxClassificationCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>千克</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12.3</para>
                /// </summary>
                [NameInMap("unitPriceWithTax")]
                [Validation(Required=false)]
                public string UnitPriceWithTax { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("unitPriceWithoutTax")]
                [Validation(Required=false)]
                public string UnitPriceWithoutTax { get; set; }

                [NameInMap("withTax")]
                [Validation(Required=false)]
                public bool? WithTax { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32131131231</para>
            /// </summary>
            [NameInMap("purchaserAccount")]
            [Validation(Required=false)]
            public string PurchaserAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>工商银行XX支行</para>
            /// </summary>
            [NameInMap("purchaserBankName")]
            [Validation(Required=false)]
            public string PurchaserBankName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>钉有限公司</para>
            /// </summary>
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345678901</para>
            /// </summary>
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("receiptId")]
            [Validation(Required=false)]
            public string ReceiptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16000000</para>
            /// </summary>
            [NameInMap("recordTime")]
            [Validation(Required=false)]
            public string RecordTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>备注信息</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("showPurchaserAccountInRemark")]
            [Validation(Required=false)]
            public bool? ShowPurchaserAccountInRemark { get; set; }

            [NameInMap("showPurchaserContactInRemark")]
            [Validation(Required=false)]
            public bool? ShowPurchaserContactInRemark { get; set; }

            [NameInMap("showSellerAccountInRemark")]
            [Validation(Required=false)]
            public bool? ShowSellerAccountInRemark { get; set; }

            [NameInMap("showSellerContactInRemark")]
            [Validation(Required=false)]
            public bool? ShowSellerContactInRemark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三提交的开票申请单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
