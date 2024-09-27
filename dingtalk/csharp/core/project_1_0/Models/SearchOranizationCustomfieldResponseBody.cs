// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchOranizationCustomfieldResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f279e812-e431-428d-846d-cxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchOranizationCustomfieldResponseBodyResult> Result { get; set; }
        public class SearchOranizationCustomfieldResponseBodyResult : TeaModel {
            [NameInMap("advancedCustomField")]
            [Validation(Required=false)]
            public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField AdvancedCustomField { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomField : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>63a5301e420637003f5dxxxx</para>
                /// </summary>
                [NameInMap("advancedCustomFieldId")]
                [Validation(Required=false)]
                public string AdvancedCustomFieldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>所思文档</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<SearchOranizationCustomfieldResponseBodyResultChoices> Choices { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultChoices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>60a2187eb72xxxxxxx</para>
                /// </summary>
                [NameInMap("choiceId")]
                [Validation(Required=false)]
                public string ChoiceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>选项一</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0715153011125xxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60a2187eb72xxxxxxx</para>
            /// </summary>
            [NameInMap("customFieldsId")]
            [Validation(Required=false)]
            public string CustomFieldsId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>自定义字段</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;_appId&quot;:&quot;5937b10b83963200444b1ff8&quot;,&quot;kanbanCardAddCustomfieldDisable&quot;:true,&quot;locales&quot;:{&quot;name&quot;:{&quot;en&quot;:&quot;Progress update time&quot;,&quot;zh&quot;:&quot;进展更新时间&quot;}}}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public Dictionary<string, object> Payload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>number</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
