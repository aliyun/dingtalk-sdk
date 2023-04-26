// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateCustomfieldValueRequest : TeaModel {
        [NameInMap("customfieldId")]
        [Validation(Required=false)]
        public string CustomfieldId { get; set; }

        [NameInMap("customfieldName")]
        [Validation(Required=false)]
        public string CustomfieldName { get; set; }

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
