// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class BatchUpdateExternalTitleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchUpdateExternalTitleResponseBodyResult Result { get; set; }
        public class BatchUpdateExternalTitleResponseBodyResult : TeaModel {
            [NameInMap("failedList")]
            [Validation(Required=false)]
            public List<BatchUpdateExternalTitleResponseBodyResultFailedList> FailedList { get; set; }
            public class BatchUpdateExternalTitleResponseBodyResultFailedList : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("modifyList")]
            [Validation(Required=false)]
            public List<BatchUpdateExternalTitleResponseBodyResultModifyList> ModifyList { get; set; }
            public class BatchUpdateExternalTitleResponseBodyResultModifyList : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
