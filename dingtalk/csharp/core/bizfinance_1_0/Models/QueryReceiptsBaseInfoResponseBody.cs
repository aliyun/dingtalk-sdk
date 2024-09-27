// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsBaseInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryReceiptsBaseInfoResponseBodyList> List { get; set; }
        public class QueryReceiptsBaseInfoResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("accountantBookId")]
            [Validation(Required=false)]
            public string AccountantBookId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1714973165000</para>
            /// </summary>
            [NameInMap("approvedAt")]
            [Validation(Required=false)]
            public string ApprovedAt { get; set; }

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
            /// <para>1714973165000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListCreator Creator { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListCreator : TeaModel {
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
            public QueryReceiptsBaseInfoResponseBodyListCustomer Customer { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListCustomer : TeaModel {
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
            /// <para><a href="https://abc.com">https://abc.com</a></para>
            /// </summary>
            [NameInMap("instanceJumpUrl")]
            [Validation(Required=false)]
            public string InstanceJumpUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>EM-xxxxx</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            [NameInMap("principal")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListPrincipal Principal { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListPrincipal : TeaModel {
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

            [NameInMap("project")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListProject Project { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListProject : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

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

            [NameInMap("supplier")]
            [Validation(Required=false)]
            public QueryReceiptsBaseInfoResponseBodyListSupplier Supplier { get; set; }
            public class QueryReceiptsBaseInfoResponseBodyListSupplier : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三提交的开票申请单</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
