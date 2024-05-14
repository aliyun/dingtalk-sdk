// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetFieldModifiedHistoryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetFieldModifiedHistoryResponseBodyResult> Result { get; set; }
        public class GetFieldModifiedHistoryResponseBodyResult : TeaModel {
            /// <summary>
            /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
