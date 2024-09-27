// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectResponseBodyResult Result { get; set; }
        public class CreateProjectResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0517xxxxxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<CreateProjectResponseBodyResultCustomFields> CustomFields { get; set; }
            public class CreateProjectResponseBodyResultCustomFields : TeaModel {
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<CreateProjectResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class CreateProjectResponseBodyResultCustomFieldsValue : TeaModel {
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6398042ec98a4e4e33xxxxxx</para>
            /// </summary>
            [NameInMap("defaultCollectionId")]
            [Validation(Required=false)]
            public string DefaultCollectionId { get; set; }

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
            /// <para>&quot;<a href="https://tcs-ga.teambition.net/thumb/xxxxxxx">https://tcs-ga.teambition.net/thumb/xxxxxxx</a></para>
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>项目1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>taskflow</para>
            /// </summary>
            [NameInMap("normalType")]
            [Validation(Required=false)]
            public string NormalType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3b376ecxxxxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6398042ec98a4e4e33</para>
            /// </summary>
            [NameInMap("rootCollectionId")]
            [Validation(Required=false)]
            public string RootCollectionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3b376ecxxxxxxx</para>
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
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
            /// <para>project</para>
            /// </summary>
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

    }

}
