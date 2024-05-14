// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public int? DeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<ProcessForecastRequestFormComponentValues> FormComponentValues { get; set; }
        public class ProcessForecastRequestFormComponentValues : TeaModel {
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("details")]
            [Validation(Required=false)]
            public List<ProcessForecastRequestFormComponentValuesDetails> Details { get; set; }
            public class ProcessForecastRequestFormComponentValuesDetails : TeaModel {
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<ProcessForecastRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class ProcessForecastRequestFormComponentValuesDetailsDetails : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
