// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryProjectResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;10&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c825b82b-a87a-49f3-a8b2-7a948b979975</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryProjectResponseBodyResult> Result { get; set; }
        public class QueryProjectResponseBodyResult : TeaModel {
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

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<QueryProjectResponseBodyResultCustomFields> CustomFields { get; set; }
            public class QueryProjectResponseBodyResultCustomFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>64ba333e4206372f3f5cxxxx</para>
                /// </summary>
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<QueryProjectResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class QueryProjectResponseBodyResultCustomFieldsValue : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64ba333e4206372f3f5cxxxx</para>
                    /// </summary>
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>自定义字段1</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>描述内容</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isSuspended")]
            [Validation(Required=false)]
            public bool? IsSuspended { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxxxx">http://xxxxx</a></para>
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试项目</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingc23b7b9682b4xxxx</para>
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64ba333e4206372f3f5cxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UNI</para>
            /// </summary>
            [NameInMap("uniqueIdPrefix")]
            [Validation(Required=false)]
            public string UniqueIdPrefix { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>organization</para>
            /// </summary>
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

    }

}
