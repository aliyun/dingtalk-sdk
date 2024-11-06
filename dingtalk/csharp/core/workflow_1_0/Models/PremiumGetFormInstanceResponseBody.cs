// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetFormInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SWAPP-dfeacds-example</para>
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, object> Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631870043000</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00003</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-abcdef-example</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("formInstDataList")]
        [Validation(Required=false)]
        public List<PremiumGetFormInstanceResponseBodyFormInstDataList> FormInstDataList { get; set; }
        public class PremiumGetFormInstanceResponseBodyFormInstDataList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("extendValue")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>951a8-8828-430c-b3e-example</para>
        /// </summary>
        [NameInMap("formInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>000025</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1631870043000</para>
        /// </summary>
        [NameInMap("modifyTimestamp")]
        [Validation(Required=false)]
        public long? ModifyTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-abcdef-example</para>
        /// </summary>
        [NameInMap("outBizCode")]
        [Validation(Required=false)]
        public string OutBizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>951a8-8828-430c-b3e-example</para>
        /// </summary>
        [NameInMap("outInstanceId")]
        [Validation(Required=false)]
        public string OutInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx提交的表单数据</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
