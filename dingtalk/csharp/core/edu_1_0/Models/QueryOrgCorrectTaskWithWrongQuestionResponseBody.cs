// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrgCorrectTaskWithWrongQuestionResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult> Result { get; set; }
        public class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResult : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("correctedPdfUrl")]
            [Validation(Required=false)]
            public string CorrectedPdfUrl { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            [NameInMap("gradeName")]
            [Validation(Required=false)]
            public string GradeName { get; set; }

            [NameInMap("paperName")]
            [Validation(Required=false)]
            public string PaperName { get; set; }

            [NameInMap("scannedPdfUrl")]
            [Validation(Required=false)]
            public string ScannedPdfUrl { get; set; }

            [NameInMap("studentWrongQuestions")]
            [Validation(Required=false)]
            public List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions> StudentWrongQuestions { get; set; }
            public class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestions : TeaModel {
                [NameInMap("assignmentPicUrlList")]
                [Validation(Required=false)]
                public List<string> AssignmentPicUrlList { get; set; }

                [NameInMap("studentId")]
                [Validation(Required=false)]
                public string StudentId { get; set; }

                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                [NameInMap("wrongQuestionRecords")]
                [Validation(Required=false)]
                public List<QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords> WrongQuestionRecords { get; set; }
                public class QueryOrgCorrectTaskWithWrongQuestionResponseBodyResultStudentWrongQuestionsWrongQuestionRecords : TeaModel {
                    [NameInMap("questionCutUrl")]
                    [Validation(Required=false)]
                    public string QuestionCutUrl { get; set; }

                    [NameInMap("questionId")]
                    [Validation(Required=false)]
                    public string QuestionId { get; set; }

                }

            }

            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            [NameInMap("taskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            [NameInMap("teacherPdfUrl")]
            [Validation(Required=false)]
            public string TeacherPdfUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
