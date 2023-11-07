// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardGetCardFinishProgressResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CardGetCardFinishProgressResponseBodyResult Result { get; set; }
        public class CardGetCardFinishProgressResponseBodyResult : TeaModel {
            [NameInMap("classStatistics")]
            [Validation(Required=false)]
            public List<CardGetCardFinishProgressResponseBodyResultClassStatistics> ClassStatistics { get; set; }
            public class CardGetCardFinishProgressResponseBodyResultClassStatistics : TeaModel {
                [NameInMap("cardBizId")]
                [Validation(Required=false)]
                public string CardBizId { get; set; }

                [NameInMap("cardBizName")]
                [Validation(Required=false)]
                public string CardBizName { get; set; }

                [NameInMap("classId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                [NameInMap("className")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("process")]
                [Validation(Required=false)]
                public List<CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess> Process { get; set; }
                public class CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess : TeaModel {
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    [NameInMap("finishedStudentsNum")]
                    [Validation(Required=false)]
                    public long? FinishedStudentsNum { get; set; }

                    [NameInMap("needFinishStudentsNum")]
                    [Validation(Required=false)]
                    public long? NeedFinishStudentsNum { get; set; }

                    [NameInMap("taskCode")]
                    [Validation(Required=false)]
                    public string TaskCode { get; set; }

                    [NameInMap("today")]
                    [Validation(Required=false)]
                    public string Today { get; set; }

                }

            }

            [NameInMap("patriarchStatistics")]
            [Validation(Required=false)]
            public List<CardGetCardFinishProgressResponseBodyResultPatriarchStatistics> PatriarchStatistics { get; set; }
            public class CardGetCardFinishProgressResponseBodyResultPatriarchStatistics : TeaModel {
                [NameInMap("cardTaskCode")]
                [Validation(Required=false)]
                public string CardTaskCode { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("isFinished")]
                [Validation(Required=false)]
                public bool? IsFinished { get; set; }

                [NameInMap("isFinishedByReissueCard")]
                [Validation(Required=false)]
                public bool? IsFinishedByReissueCard { get; set; }

                [NameInMap("isLastDay")]
                [Validation(Required=false)]
                public bool? IsLastDay { get; set; }

                [NameInMap("reissueCard")]
                [Validation(Required=false)]
                public bool? ReissueCard { get; set; }

                [NameInMap("studentId")]
                [Validation(Required=false)]
                public string StudentId { get; set; }

                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                [NameInMap("today")]
                [Validation(Required=false)]
                public string Today { get; set; }

                [NameInMap("userSubTaskId")]
                [Validation(Required=false)]
                public long? UserSubTaskId { get; set; }

            }

            [NameInMap("studentNameList")]
            [Validation(Required=false)]
            public List<string> StudentNameList { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
