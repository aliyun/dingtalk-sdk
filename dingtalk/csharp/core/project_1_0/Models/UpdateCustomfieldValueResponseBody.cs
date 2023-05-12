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
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<UpdateCustomfieldValueResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class UpdateCustomfieldValueResponseBodyResultCustomFieldsValue : TeaModel {
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

        }

    }

}
