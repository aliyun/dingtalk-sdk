// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public int? DeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("formComponentValues")]
        [Validation(Required=false)]
        public List<ProcessForecastRequestFormComponentValues> FormComponentValues { get; set; }
        public class ProcessForecastRequestFormComponentValues : TeaModel {
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
            public List<ProcessForecastRequestFormComponentValuesDetails> Details { get; set; }
            public class ProcessForecastRequestFormComponentValuesDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Phone</para>
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                [NameInMap("details")]
                [Validation(Required=false)]
                public List<ProcessForecastRequestFormComponentValuesDetailsDetails> Details { get; set; }
                public class ProcessForecastRequestFormComponentValuesDetailsDetails : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager432</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
