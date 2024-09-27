// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class FormCreateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>用于员工差旅费用报销使用</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>出差报销审批</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        public FormCreateRequestTemplateConfig TemplateConfig { get; set; }
        public class FormCreateRequestTemplateConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abcd</para>
            /// </summary>
            [NameInMap("dirId")]
            [Validation(Required=false)]
            public string DirId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("disableDeleteProcess")]
            [Validation(Required=false)]
            public bool? DisableDeleteProcess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("disableFormEdit")]
            [Validation(Required=false)]
            public bool? DisableFormEdit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("disableHomepage")]
            [Validation(Required=false)]
            public bool? DisableHomepage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("disableResubmit")]
            [Validation(Required=false)]
            public bool? DisableResubmit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("disableStopProcessButton")]
            [Validation(Required=false)]
            public bool? DisableStopProcessButton { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hidden")]
            [Validation(Required=false)]
            public bool? Hidden { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>efgh</para>
            /// </summary>
            [NameInMap("originDirId")]
            [Validation(Required=false)]
            public string OriginDirId { get; set; }

        }

    }

}
