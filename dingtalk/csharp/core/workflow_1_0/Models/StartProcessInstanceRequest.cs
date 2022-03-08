// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class StartProcessInstanceRequest : TeaModel {
        /// <summary>
        /// 不使用审批流模板时，直接指定审批人列表
        /// </summary>
        [NameInMap("approvers")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestApprovers> Approvers { get; set; }
        public class StartProcessInstanceRequestApprovers : TeaModel {
            /// <summary>
            /// 审批类型
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// 审批人列表
            /// </summary>
            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// 抄送人userId列表
        /// </summary>
        [NameInMap("ccList")]
        [Validation(Required=false)]
        public List<string> CcList { get; set; }

        /// <summary>
        /// 抄送时间
        /// </summary>
        [NameInMap("ccPosition")]
        [Validation(Required=false)]
        public string CcPosition { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// 表单数据内容，控件列表
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestFormComponentValues> FormComponentValues { get; set; }
        public class StartProcessInstanceRequestFormComponentValues : TeaModel {
            /// <summary>
            /// 控件别名
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// 控件类型
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("details")]
            [Validation(Required=false)]
            public List<StartProcessInstanceRequestFormComponentValuesDetails> Details { get; set; }
            public class StartProcessInstanceRequestFormComponentValuesDetails : TeaModel {
                /// <summary>
                /// 控件别名
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class StartProcessInstanceRequestFormComponentValuesDetailsDetails : TeaModel {
                    /// <summary>
                    /// 控件别名
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// 控件类型
                    /// </summary>
                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// 控件扩展值
                    /// </summary>
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    /// <summary>
                    /// 控件id
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// 控件名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 控件值
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// 控件扩展值
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                /// <summary>
                /// 控件id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 控件名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 控件值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 控件扩展值
            /// </summary>
            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            /// <summary>
            /// 控件id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 控件名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 控件值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 企业微应用标识
        /// </summary>
        [NameInMap("microappAgentId")]
        [Validation(Required=false)]
        public long? MicroappAgentId { get; set; }

        /// <summary>
        /// 审批发起人的userId
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// 审批流的唯一码
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 使用审批流模板时，模板上的自选操作人列表
        /// </summary>
        [NameInMap("targetSelectActioners")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestTargetSelectActioners> TargetSelectActioners { get; set; }
        public class StartProcessInstanceRequestTargetSelectActioners : TeaModel {
            /// <summary>
            /// 自选节点的规则key
            /// </summary>
            [NameInMap("actionerKey")]
            [Validation(Required=false)]
            public string ActionerKey { get; set; }

            /// <summary>
            /// 操作人userId列表
            /// </summary>
            [NameInMap("actionerUserIds")]
            [Validation(Required=false)]
            public List<string> ActionerUserIds { get; set; }

        }

    }

}
