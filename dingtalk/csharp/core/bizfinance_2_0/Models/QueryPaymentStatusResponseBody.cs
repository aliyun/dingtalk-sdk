// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryPaymentStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingXXX</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>收款账户错误</para>
        /// </summary>
        [NameInMap("failReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABC</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20241112</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("payeeAccountInfo")]
        [Validation(Required=false)]
        public QueryPaymentStatusResponseBodyPayeeAccountInfo PayeeAccountInfo { get; set; }
        public class QueryPaymentStatusResponseBodyPayeeAccountInfo : TeaModel {
            [NameInMap("bankOpenDTO")]
            [Validation(Required=false)]
            public QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO BankOpenDTO { get; set; }
            public class QueryPaymentStatusResponseBodyPayeeAccountInfoBankOpenDTO : TeaModel {
                [NameInMap("bankBranchName")]
                [Validation(Required=false)]
                public string BankBranchName { get; set; }

                [NameInMap("bankCardNo")]
                [Validation(Required=false)]
                public string BankCardNo { get; set; }

                [NameInMap("bankName")]
                [Validation(Required=false)]
                public string BankName { get; set; }

            }

        }

        [NameInMap("payerAccountInfo")]
        [Validation(Required=false)]
        public QueryPaymentStatusResponseBodyPayerAccountInfo PayerAccountInfo { get; set; }
        public class QueryPaymentStatusResponseBodyPayerAccountInfo : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("bankOpenDTO")]
            [Validation(Required=false)]
            public QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO BankOpenDTO { get; set; }
            public class QueryPaymentStatusResponseBodyPayerAccountInfoBankOpenDTO : TeaModel {
                [NameInMap("bankBranchName")]
                [Validation(Required=false)]
                public string BankBranchName { get; set; }

                [NameInMap("bankCardNo")]
                [Validation(Required=false)]
                public string BankCardNo { get; set; }

                [NameInMap("bankName")]
                [Validation(Required=false)]
                public string BankName { get; set; }

            }

            [NameInMap("enterpriseAccountCode")]
            [Validation(Required=false)]
            public string EnterpriseAccountCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("paymentStatus")]
        [Validation(Required=false)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-11 00:00:00</para>
        /// </summary>
        [NameInMap("paymentTime")]
        [Validation(Required=false)]
        public string PaymentTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ABC</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>报销</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>504</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
