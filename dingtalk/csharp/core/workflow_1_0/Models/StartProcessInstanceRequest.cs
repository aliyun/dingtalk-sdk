// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class StartProcessInstanceRequest : TeaModel {
        [NameInMap("approvers")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestApprovers> Approvers { get; set; }
        public class StartProcessInstanceRequestApprovers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>会签：AND；或签：OR；单人：NONE</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
        /// </summary>
        [NameInMap("bizDetailPageUrl")]
        [Validation(Required=false)]
        public string BizDetailPageUrl { get; set; }

        [NameInMap("ccList")]
        [Validation(Required=false)]
        public List<string> CcList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>START、FINISH、START_FINISH</para>
        /// </summary>
        [NameInMap("ccPosition")]
        [Validation(Required=false)]
        public string CcPosition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestFormComponentValues> FormComponentValues { get; set; }
        public class StartProcessInstanceRequestFormComponentValues : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Phone</para>
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("details")]
            [Validation(Required=false)]
            public List<StartProcessInstanceRequestFormComponentValuesDetails> Details { get; set; }
            public class StartProcessInstanceRequestFormComponentValuesDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Phone</para>
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class StartProcessInstanceRequestFormComponentValuesDetailsDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Phone</para>
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>总个数:1</para>
                    /// </summary>
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PhoneField_IZI2LP8QF6O0</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PhoneField</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>总个数:1</para>
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PhoneField_IZI2LP8QF6O0</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PhoneField</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123xxxxxxxx</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>总个数:1</para>
            /// </summary>
            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PhoneField_IZI2LP8QF6O0</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PhoneField</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxxx</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>41605932</para>
        /// </summary>
        [NameInMap("microappAgentId")]
        [Validation(Required=false)]
        public long? MicroappAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager432</para>
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("targetSelectActioners")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestTargetSelectActioners> TargetSelectActioners { get; set; }
        public class StartProcessInstanceRequestTargetSelectActioners : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>manual_1918_5cd3_5e19_6a98</para>
            /// </summary>
            [NameInMap("actionerKey")]
            [Validation(Required=false)]
            public string ActionerKey { get; set; }

            [NameInMap("actionerUserIds")]
            [Validation(Required=false)]
            public List<string> ActionerUserIds { get; set; }

        }

    }

}
