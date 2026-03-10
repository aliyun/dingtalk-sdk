// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetDismissionRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDismissionRecordResponseBodyResult Result { get; set; }
        public class GetDismissionRecordResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public GetDismissionRecordResponseBodyResultList List { get; set; }
            public class GetDismissionRecordResponseBodyResultList : TeaModel {
                [NameInMap("lastWorkDay")]
                [Validation(Required=false)]
                public long? LastWorkDay { get; set; }

                [NameInMap("staffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
