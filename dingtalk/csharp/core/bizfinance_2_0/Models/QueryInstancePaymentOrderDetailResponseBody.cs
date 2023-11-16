// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryInstancePaymentOrderDetailResponseBody : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("payeeAccountDTO")]
        [Validation(Required=false)]
        public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO PayeeAccountDTO { get; set; }
        public class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO : TeaModel {
            [NameInMap("bankOpenDTO")]
            [Validation(Required=false)]
            public QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO BankOpenDTO { get; set; }
            public class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO : TeaModel {
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
        public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO PayerAccountDTO { get; set; }
        public class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO : TeaModel {
            [NameInMap("bankOpenDTO")]
            [Validation(Required=false)]
            public QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO BankOpenDTO { get; set; }
            public class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO : TeaModel {
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

            [NameInMap("enterpriseAccountCode")]
            [Validation(Required=false)]
            public string EnterpriseAccountCode { get; set; }

        }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
