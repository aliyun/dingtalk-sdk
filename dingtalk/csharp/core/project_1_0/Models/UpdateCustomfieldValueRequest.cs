// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueRequest : TeaModel {
        [NameInMap("customFieldId")]
        [Validation(Required=false)]
        public string CustomFieldId { get; set; }

        [NameInMap("customFieldName")]
        [Validation(Required=false)]
        public string CustomFieldName { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public List<UpdateCustomfieldValueRequestValue> Value { get; set; }
        public class UpdateCustomfieldValueRequestValue : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
