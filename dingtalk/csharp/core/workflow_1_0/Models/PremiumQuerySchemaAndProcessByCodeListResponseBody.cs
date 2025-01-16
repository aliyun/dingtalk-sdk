// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumQuerySchemaAndProcessByCodeListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<PremiumQuerySchemaAndProcessByCodeListResponseBodyResult> Result { get; set; }
        public class PremiumQuerySchemaAndProcessByCodeListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding123</para>
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hrm.xxx</para>
            /// </summary>
            [NameInMap("bizCategoryId")]
            [Validation(Required=false)]
            public string BizCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1638326995000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userId123</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-28215C3E-00E3-4118-xxxx-4091F828AF2F</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https//:xxx</para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>模板描述1</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userId123</para>
            /// </summary>
            [NameInMap("modifierUserId")]
            [Validation(Required=false)]
            public string ModifierUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1638326995000</para>
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例模板</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROC-17428B8C-6C60-470E-xxxx-64F1037AE067</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;发起人&quot;,&quot;type&quot;:&quot;start&quot;,&quot;nodeId&quot;:&quot;sid-startevent&quot;,&quot;childNode&quot;:{&quot;name&quot;:&quot;审批人&quot;,&quot;prevId&quot;:&quot;sid-startevent&quot;,&quot;type&quot;:&quot;approver&quot;,&quot;nodeId&quot;:&quot;sid-1234_5678&quot;,&quot;properties&quot;:{&quot;activateType&quot;:&quot;ONE_BY_ONE&quot;,&quot;approvalType&quot;:&quot;MANUAL&quot;,&quot;actionerRules&quot;:[{&quot;select&quot;:[&quot;allStaff&quot;],&quot;range&quot;:{&quot;approvals&quot;:[],&quot;labels&quot;:[]},&quot;type&quot;:&quot;target_select&quot;,&quot;key&quot;:&quot;manual_sid-1234_5678_30a8_b373&quot;,&quot;multi&quot;:1}],&quot;agreeAll&quot;:false},&quot;childNode&quot;:{&quot;name&quot;:&quot;抄送人&quot;,&quot;prevId&quot;:&quot;sid-1234_5678&quot;,&quot;type&quot;:&quot;notifier&quot;,&quot;nodeId&quot;:&quot;9955_7e43&quot;,&quot;properties&quot;:{&quot;actionerRules&quot;:[{&quot;select&quot;:[&quot;allStaff&quot;],&quot;range&quot;:{},&quot;type&quot;:&quot;target_select&quot;,&quot;key&quot;:&quot;manual_9955_7e43_0c96_39d8&quot;,&quot;multi&quot;:1}]}}}}</para>
            /// </summary>
            [NameInMap("processConfig")]
            [Validation(Required=false)]
            public string ProcessConfig { get; set; }

            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;commentHiddenForProposer&quot;:&quot;&quot;,&quot;commentRequired&quot;:&quot;&quot;,&quot;icon&quot;:&quot;timefades#red&quot;,&quot;commentDescription&quot;:&quot;&quot;,&quot;description&quot;:&quot;支持地址控件&quot;,&quot;title&quot;:&quot;官方OA审批-POP-2025-0109&quot;,&quot;items&quot;:[{&quot;componentName&quot;:&quot;TimeAndLocationField&quot;,&quot;props&quot;:{&quot;label&quot;:[&quot;当前时间&quot;,&quot;当前地点&quot;],&quot;id&quot;:&quot;TimeAndLocationField_1CVHM5TIIWR9C&quot;,&quot;required&quot;:false}},{&quot;componentName&quot;:&quot;TextField&quot;,&quot;props&quot;:{&quot;placeholder&quot;:&quot;请输入&quot;,&quot;label&quot;:&quot;单行输入框&quot;,&quot;id&quot;:&quot;TextField_17EZKEGSOCTC0&quot;,&quot;required&quot;:false}}]}</para>
            /// </summary>
            [NameInMap("schemaContent")]
            [Validation(Required=false)]
            public string SchemaContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
