// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class StaffLabelRecordsQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public StaffLabelRecordsQueryResponseBodyContent Content { get; set; }
        public class StaffLabelRecordsQueryResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<StaffLabelRecordsQueryResponseBodyContentData> Data { get; set; }
            public class StaffLabelRecordsQueryResponseBodyContentData : TeaModel {
                [NameInMap("labels")]
                [Validation(Required=false)]
                public List<StaffLabelRecordsQueryResponseBodyContentDataLabels> Labels { get; set; }
                public class StaffLabelRecordsQueryResponseBodyContentDataLabels : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>long_termism_score</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>values.long_termism_score</para>
                    /// </summary>
                    [NameInMap("guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>持续业绩</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions> Options { get; set; }
                    public class StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions : TeaModel {
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("tip")]
                        [Validation(Required=false)]
                        public string Tip { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>values</para>
                    /// </summary>
                    [NameInMap("typeCode")]
                    [Validation(Required=false)]
                    public string TypeCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>价值</para>
                    /// </summary>
                    [NameInMap("typeName")]
                    [Validation(Required=false)]
                    public string TypeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5（总是）</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0140180438261064274667</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("totalCountt")]
            [Validation(Required=false)]
            public long? TotalCountt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0140180438261064274667</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
