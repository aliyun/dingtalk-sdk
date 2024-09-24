// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetFormComponentAliasListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFormComponentAliasListResponseBodyResult> Result { get; set; }
        public class GetFormComponentAliasListResponseBodyResult : TeaModel {
            [NameInMap("alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

        }

    }

}
