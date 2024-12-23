// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateCustomfieldValueResponseBodyResult Result { get; set; }
        public class UpdateCustomfieldValueResponseBodyResult : TeaModel {
            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<UpdateCustomfieldValueResponseBodyResultCustomFields> CustomFields { get; set; }
            public class UpdateCustomfieldValueResponseBodyResultCustomFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>62fb0b77xxxxx</para>
                /// </summary>
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<UpdateCustomfieldValueResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class UpdateCustomfieldValueResponseBodyResultCustomFieldsValue : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("thumbUrl")]
                    [Validation(Required=false)]
                    public string ThumbUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>我是具体显示值</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

    }

}
