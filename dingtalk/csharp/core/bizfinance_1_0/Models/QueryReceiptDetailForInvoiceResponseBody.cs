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
            [NameInMap("accountantBookId")]
            [Validation(Required=false)]
            public string AccountantBookId { get; set; }

            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("applyStatus")]
            [Validation(Required=false)]
            public string ApplyStatus { get; set; }

            [NameInMap("bizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public QueryReceiptDetailForInvoiceResponseBodyResultCreator Creator { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultCreator : TeaModel {
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
            public QueryReceiptDetailForInvoiceResponseBodyResultCustomer Customer { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultCustomer : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("drawerEmail")]
            [Validation(Required=false)]
            public string DrawerEmail { get; set; }

            [NameInMap("drawerTelephone")]
            [Validation(Required=false)]
            public string DrawerTelephone { get; set; }

            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("productInfoList")]
            [Validation(Required=false)]
            public List<QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList> ProductInfoList { get; set; }
            public class QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList : TeaModel {
                [NameInMap("amountWithTax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                [NameInMap("amountWithoutTax")]
                [Validation(Required=false)]
                public string AmountWithoutTax { get; set; }

                [NameInMap("discountAmount")]
                [Validation(Required=false)]
                public string DiscountAmount { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                [NameInMap("taxClassificationCode")]
                [Validation(Required=false)]
                public string TaxClassificationCode { get; set; }

                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("unitPriceWithTax")]
                [Validation(Required=false)]
                public string UnitPriceWithTax { get; set; }

                [NameInMap("unitPriceWithoutTax")]
                [Validation(Required=false)]
                public string UnitPriceWithoutTax { get; set; }

                [NameInMap("withTax")]
                [Validation(Required=false)]
                public bool? WithTax { get; set; }

            }

            [NameInMap("purchaserAccount")]
            [Validation(Required=false)]
            public string PurchaserAccount { get; set; }

            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            [NameInMap("purchaserBankName")]
            [Validation(Required=false)]
            public string PurchaserBankName { get; set; }

            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

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

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
