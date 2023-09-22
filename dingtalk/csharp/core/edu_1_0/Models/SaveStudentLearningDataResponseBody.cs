// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SaveStudentLearningDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SaveStudentLearningDataResponseBodyResult Result { get; set; }
        public class SaveStudentLearningDataResponseBodyResult : TeaModel {
            [NameInMap("saveSuccess")]
            [Validation(Required=false)]
            public bool? SaveSuccess { get; set; }

            [NameInMap("wrongQuestions")]
            [Validation(Required=false)]
            public List<SaveStudentLearningDataResponseBodyResultWrongQuestions> WrongQuestions { get; set; }
            public class SaveStudentLearningDataResponseBodyResultWrongQuestions : TeaModel {
                [NameInMap("questionNo")]
                [Validation(Required=false)]
                public string QuestionNo { get; set; }

                [NameInMap("questionUploadUrlList")]
                [Validation(Required=false)]
                public List<string> QuestionUploadUrlList { get; set; }

                [NameInMap("standardAnswerUploadUrlList")]
                [Validation(Required=false)]
                public List<string> StandardAnswerUploadUrlList { get; set; }

                [NameInMap("userAnswerUploadUrlList")]
                [Validation(Required=false)]
                public List<string> UserAnswerUploadUrlList { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
