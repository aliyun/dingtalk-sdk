// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectCustomfieldStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectCustomfieldStatusResponseBodyResult Result { get; set; }
        public class CreateProjectCustomfieldStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>lookup2</para>
            /// </summary>
            [NameInMap("advancedCustomFieldObjectType")]
            [Validation(Required=false)]
            public string AdvancedCustomFieldObjectType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("customFieldId")]
            [Validation(Required=false)]
            public string CustomFieldId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>项目进度</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("originalId")]
            [Validation(Required=false)]
            public string OriginalId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>number</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateProjectCustomfieldStatusResponseBodyResultValue> Value { get; set; }
            public class CreateProjectCustomfieldStatusResponseBodyResultValue : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>63a5301e420637003f5dxxxx</para>
                /// </summary>
                [NameInMap("customFieldValueId")]
                [Validation(Required=false)]
                public string CustomFieldValueId { get; set; }

                [NameInMap("metaString")]
                [Validation(Required=false)]
                public string MetaString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
