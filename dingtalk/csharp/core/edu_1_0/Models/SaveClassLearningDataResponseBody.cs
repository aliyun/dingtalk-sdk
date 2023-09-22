// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SaveClassLearningDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SaveClassLearningDataResponseBodyResult Result { get; set; }
        public class SaveClassLearningDataResponseBodyResult : TeaModel {
            [NameInMap("questionUploadUrlList")]
            [Validation(Required=false)]
            public List<string> QuestionUploadUrlList { get; set; }

            [NameInMap("standardAnswerUploadUrlList")]
            [Validation(Required=false)]
            public List<string> StandardAnswerUploadUrlList { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
