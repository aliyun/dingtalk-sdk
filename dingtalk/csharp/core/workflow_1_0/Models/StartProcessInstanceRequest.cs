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
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        [NameInMap("ccList")]
        [Validation(Required=false)]
        public List<string> CcList { get; set; }

        [NameInMap("ccPosition")]
        [Validation(Required=false)]
        public string CcPosition { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestFormComponentValues> FormComponentValues { get; set; }
        public class StartProcessInstanceRequestFormComponentValues : TeaModel {
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
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<StartProcessInstanceRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class StartProcessInstanceRequestFormComponentValuesDetailsDetails : TeaModel {
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("microappAgentId")]
        [Validation(Required=false)]
        public long? MicroappAgentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("targetSelectActioners")]
        [Validation(Required=false)]
        public List<StartProcessInstanceRequestTargetSelectActioners> TargetSelectActioners { get; set; }
        public class StartProcessInstanceRequestTargetSelectActioners : TeaModel {
            [NameInMap("actionerKey")]
            [Validation(Required=false)]
            public string ActionerKey { get; set; }

            [NameInMap("actionerUserIds")]
            [Validation(Required=false)]
            public List<string> ActionerUserIds { get; set; }

        }

    }

}
