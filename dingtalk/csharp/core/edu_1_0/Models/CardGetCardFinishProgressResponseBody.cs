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
                /// <summary>
                /// <b>Example:</b>
                /// <para>234234234</para>
                /// </summary>
                [NameInMap("cardBizId")]
                [Validation(Required=false)]
                public string CardBizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>二年级1班</para>
                /// </summary>
                [NameInMap("cardBizName")]
                [Validation(Required=false)]
                public string CardBizName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3424234</para>
                /// </summary>
                [NameInMap("classId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>二年级1班</para>
                /// </summary>
                [NameInMap("className")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("process")]
                [Validation(Required=false)]
                public List<CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess> Process { get; set; }
                public class CardGetCardFinishProgressResponseBodyResultClassStatisticsProcess : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-11-01</para>
                    /// </summary>
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("finishedStudentsNum")]
                    [Validation(Required=false)]
                    public long? FinishedStudentsNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>11</para>
                    /// </summary>
                    [NameInMap("needFinishStudentsNum")]
                    [Validation(Required=false)]
                    public long? NeedFinishStudentsNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CARD_TASK_CODE_0</para>
                    /// </summary>
                    [NameInMap("taskCode")]
                    [Validation(Required=false)]
                    public string TaskCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-11-01</para>
                    /// </summary>
                    [NameInMap("today")]
                    [Validation(Required=false)]
                    public string Today { get; set; }

                }

            }

            [NameInMap("patriarchStatistics")]
            [Validation(Required=false)]
            public List<CardGetCardFinishProgressResponseBodyResultPatriarchStatistics> PatriarchStatistics { get; set; }
            public class CardGetCardFinishProgressResponseBodyResultPatriarchStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>CARD_TASK_CODE_0</para>
                /// </summary>
                [NameInMap("cardTaskCode")]
                [Validation(Required=false)]
                public string CardTaskCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-01</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>23424234</para>
                /// </summary>
                [NameInMap("studentId")]
                [Validation(Required=false)]
                public string StudentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-11-01</para>
                /// </summary>
                [NameInMap("today")]
                [Validation(Required=false)]
                public string Today { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>234234234</para>
                /// </summary>
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
