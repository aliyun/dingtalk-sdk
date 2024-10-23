// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class IssueInvoiceWithOrderRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public IssueInvoiceWithOrderRequestContent Content { get; set; }
        public class IssueInvoiceWithOrderRequestContent : TeaModel {
            [NameInMap("additionInfo")]
            [Validation(Required=false)]
            public List<IssueInvoiceWithOrderRequestContentAdditionInfo> AdditionInfo { get; set; }
            public class IssueInvoiceWithOrderRequestContentAdditionInfo : TeaModel {
                [NameInMap("additionContent")]
                [Validation(Required=false)]
                public string AdditionContent { get; set; }

                [NameInMap("additionName")]
                [Validation(Required=false)]
                public string AdditionName { get; set; }

                [NameInMap("dataType")]
                [Validation(Required=false)]
                public long? DataType { get; set; }

            }

            [NameInMap("applyPerson")]
            [Validation(Required=false)]
            public string ApplyPerson { get; set; }

            [NameInMap("bankAccount")]
            [Validation(Required=false)]
            public string BankAccount { get; set; }

            [NameInMap("bankName")]
            [Validation(Required=false)]
            public string BankName { get; set; }

            [NameInMap("invoiceRemark")]
            [Validation(Required=false)]
            public string InvoiceRemark { get; set; }

            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public long? InvoiceType { get; set; }

            [NameInMap("naturalPerson")]
            [Validation(Required=false)]
            public string NaturalPerson { get; set; }

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
            public List<IssueInvoiceWithOrderRequestContentProducts> Products { get; set; }
            public class IssueInvoiceWithOrderRequestContentProducts : TeaModel {
                [NameInMap("amountIncludeTax")]
                [Validation(Required=false)]
                public string AmountIncludeTax { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

                [NameInMap("revenueCode")]
                [Validation(Required=false)]
                public string RevenueCode { get; set; }

                [NameInMap("specs")]
                [Validation(Required=false)]
                public string Specs { get; set; }

                [NameInMap("taxSign")]
                [Validation(Required=false)]
                public string TaxSign { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            [NameInMap("purchaser")]
            [Validation(Required=false)]
            public string Purchaser { get; set; }

            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("reviewer")]
            [Validation(Required=false)]
            public string Reviewer { get; set; }

            [NameInMap("taxnum")]
            [Validation(Required=false)]
            public string Taxnum { get; set; }

        }

        [NameInMap("financeAppKey")]
        [Validation(Required=false)]
        public string FinanceAppKey { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
