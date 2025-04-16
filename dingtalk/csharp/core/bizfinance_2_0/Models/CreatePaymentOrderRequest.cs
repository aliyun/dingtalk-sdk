// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class CreatePaymentOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1741941518884</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxabc</para>
        /// </summary>
        [NameInMap("outBizNo")]
        [Validation(Required=false)]
        public string OutBizNo { get; set; }

        [NameInMap("payeeAccountDTO")]
        [Validation(Required=false)]
        public CreatePaymentOrderRequestPayeeAccountDTO PayeeAccountDTO { get; set; }
        public class CreatePaymentOrderRequestPayeeAccountDTO : TeaModel {
            [NameInMap("bankOpenDTO")]
            [Validation(Required=false)]
            public CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO BankOpenDTO { get; set; }
            public class CreatePaymentOrderRequestPayeeAccountDTOBankOpenDTO : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>钉钉中国</para>
                /// </summary>
                [NameInMap("accountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1025884624512</para>
                /// </summary>
                [NameInMap("bankBranchCode")]
                [Validation(Required=false)]
                public string BankBranchCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>招商银行杭州余杭分行</para>
                /// </summary>
                [NameInMap("bankBranchName")]
                [Validation(Required=false)]
                public string BankBranchName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122215111012</para>
                /// </summary>
                [NameInMap("bankCardNo")]
                [Validation(Required=false)]
                public string BankCardNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ICBC</para>
                /// </summary>
                [NameInMap("bankCode")]
                [Validation(Required=false)]
                public string BankCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>招商银行</para>
                /// </summary>
                [NameInMap("bankName")]
                [Validation(Required=false)]
                public string BankName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PERSONAL_BANK_CARD</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("payerAccountDTO")]
        [Validation(Required=false)]
        public CreatePaymentOrderRequestPayerAccountDTO PayerAccountDTO { get; set; }
        public class CreatePaymentOrderRequestPayerAccountDTO : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ACC_XXXXX</para>
            /// </summary>
            [NameInMap("enterpriseAccountCode")]
            [Validation(Required=false)]
            public string EnterpriseAccountCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>日常报销</para>
        /// </summary>
        [NameInMap("paymentOrderTitle")]
        [Validation(Required=false)]
        public string PaymentOrderTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>付款用途</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5046195764756652</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
