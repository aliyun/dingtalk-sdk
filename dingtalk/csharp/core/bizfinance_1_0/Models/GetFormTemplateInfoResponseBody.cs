// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetFormTemplateInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiptFormTemplateInfoList")]
        [Validation(Required=false)]
        public List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList> ReceiptFormTemplateInfoList { get; set; }
        public class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList : TeaModel {
            [NameInMap("componentList")]
            [Validation(Required=false)]
            public List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList> ComponentList { get; set; }
            public class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;100&quot;</para>
                /// </summary>
                [NameInMap("bindingVal")]
                [Validation(Required=false)]
                public string BindingVal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;xxx&quot;</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;报销金额&quot;</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;amount&quot;</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;报销套件&quot;</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;PROC-EB81447A-B0E3-4A2F-A719-0A85EFD09184&quot;</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;invalid&quot;</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("suiteId")]
            [Validation(Required=false)]
            public string SuiteId { get; set; }

        }

    }

}
