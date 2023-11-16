// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RosterMetaAvailableFieldListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RosterMetaAvailableFieldListResponseBodyResult> Result { get; set; }
        public class RosterMetaAvailableFieldListResponseBodyResult : TeaModel {
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("optionText")]
            [Validation(Required=false)]
            public string OptionText { get; set; }

        }

    }

}
