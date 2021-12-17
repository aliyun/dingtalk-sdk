// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastRequest : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public int? DeptId { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

        /// <summary>
        /// 表单数据内容，控件列表
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<ProcessForecastRequestFormComponentValues> FormComponentValues { get; set; }
        public class ProcessForecastRequestFormComponentValues : TeaModel {
            /// <summary>
            /// 控件id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 控件别名
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

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

            /// <summary>
            /// 控件扩展值
            /// </summary>
            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            /// <summary>
            /// 控件类型
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("details")]
            [Validation(Required=false)]
            public List<ProcessForecastRequestFormComponentValuesDetails> Details { get; set; }
            public class ProcessForecastRequestFormComponentValuesDetails : TeaModel {
                /// <summary>
                /// 控件id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 控件别名
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

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

                /// <summary>
                /// 控件扩展值
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<ProcessForecastRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class ProcessForecastRequestFormComponentValuesDetailsDetails : TeaModel {
                    /// <summary>
                    /// 控件id
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// 控件别名
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

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

                    /// <summary>
                    /// 控件扩展值
                    /// </summary>
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                }

            }

        }

        /// <summary>
        /// 审批流的唯一码
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 审批发起人的userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
