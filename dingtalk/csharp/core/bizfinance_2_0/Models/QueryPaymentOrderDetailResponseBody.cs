// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryPaymentOrderDetailResponseBody : TeaModel {
        [NameInMap("orderList")]
        [Validation(Required=false)]
        public List<QueryPaymentOrderDetailResponseBodyOrderList> OrderList { get; set; }
        public class QueryPaymentOrderDetailResponseBodyOrderList : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("outBizNo")]
            [Validation(Required=false)]
            public string OutBizNo { get; set; }

            [NameInMap("payeeAccountDTO")]
            [Validation(Required=false)]
            public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO PayeeAccountDTO { get; set; }
            public class QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTO : TeaModel {
                [NameInMap("bankDTO")]
                [Validation(Required=false)]
                public QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO BankDTO { get; set; }
                public class QueryPaymentOrderDetailResponseBodyOrderListPayeeAccountDTOBankDTO : TeaModel {
                    [NameInMap("accountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    [NameInMap("bankBranchCode")]
                    [Validation(Required=false)]
                    public string BankBranchCode { get; set; }

                    [NameInMap("bankBranchName")]
                    [Validation(Required=false)]
                    public string BankBranchName { get; set; }

                    [NameInMap("bankCardNo")]
                    [Validation(Required=false)]
                    public string BankCardNo { get; set; }

                    [NameInMap("bankCode")]
                    [Validation(Required=false)]
                    public string BankCode { get; set; }

                    [NameInMap("bankName")]
                    [Validation(Required=false)]
                    public string BankName { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("payerAccountDTO")]
            [Validation(Required=false)]
            public QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO PayerAccountDTO { get; set; }
            public class QueryPaymentOrderDetailResponseBodyOrderListPayerAccountDTO : TeaModel {
                [NameInMap("enterpriseAccountCode")]
                [Validation(Required=false)]
                public string EnterpriseAccountCode { get; set; }

            }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("subOrderList")]
            [Validation(Required=false)]
            public List<QueryPaymentOrderDetailResponseBodyOrderListSubOrderList> SubOrderList { get; set; }
            public class QueryPaymentOrderDetailResponseBodyOrderListSubOrderList : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("orderNo")]
                [Validation(Required=false)]
                public string OrderNo { get; set; }

                [NameInMap("outBizNo")]
                [Validation(Required=false)]
                public string OutBizNo { get; set; }

                [NameInMap("payeeAccountDTO")]
                [Validation(Required=false)]
                public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO PayeeAccountDTO { get; set; }
                public class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTO : TeaModel {
                    [NameInMap("bankDTO")]
                    [Validation(Required=false)]
                    public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO BankDTO { get; set; }
                    public class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayeeAccountDTOBankDTO : TeaModel {
                        [NameInMap("accountName")]
                        [Validation(Required=false)]
                        public string AccountName { get; set; }

                        [NameInMap("bankBranchCode")]
                        [Validation(Required=false)]
                        public string BankBranchCode { get; set; }

                        [NameInMap("bankBranchName")]
                        [Validation(Required=false)]
                        public string BankBranchName { get; set; }

                        [NameInMap("bankCardNo")]
                        [Validation(Required=false)]
                        public string BankCardNo { get; set; }

                        [NameInMap("bankCode")]
                        [Validation(Required=false)]
                        public string BankCode { get; set; }

                        [NameInMap("bankName")]
                        [Validation(Required=false)]
                        public string BankName { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("payerAccountDTO")]
                [Validation(Required=false)]
                public QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO PayerAccountDTO { get; set; }
                public class QueryPaymentOrderDetailResponseBodyOrderListSubOrderListPayerAccountDTO : TeaModel {
                    [NameInMap("enterpriseAccountCode")]
                    [Validation(Required=false)]
                    public string EnterpriseAccountCode { get; set; }

                }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
