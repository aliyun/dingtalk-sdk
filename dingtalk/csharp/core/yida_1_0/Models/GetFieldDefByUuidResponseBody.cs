// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetFieldDefByUuidResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFieldDefByUuidResponseBodyResult> Result { get; set; }
        public class GetFieldDefByUuidResponseBodyResult : TeaModel {
            [NameInMap("behavior")]
            [Validation(Required=false)]
            public string Behavior { get; set; }

            [NameInMap("children")]
            [Validation(Required=false)]
            public string Children { get; set; }

            [NameInMap("componentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public object Label { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public object Props { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
