// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SaveStudentLearningDataRequest : TeaModel {
        [NameInMap("assignNum")]
        [Validation(Required=false)]
        public int? AssignNum { get; set; }

        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("correctNum")]
        [Validation(Required=false)]
        public int? CorrectNum { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("fileSuffix")]
        [Validation(Required=false)]
        public string FileSuffix { get; set; }

        [NameInMap("generatedTime")]
        [Validation(Required=false)]
        public long? GeneratedTime { get; set; }

        [NameInMap("questionNum")]
        [Validation(Required=false)]
        public int? QuestionNum { get; set; }

        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

        [NameInMap("subjectCode")]
        [Validation(Required=false)]
        public string SubjectCode { get; set; }

        [NameInMap("submitNum")]
        [Validation(Required=false)]
        public int? SubmitNum { get; set; }

        [NameInMap("wrongQuestions")]
        [Validation(Required=false)]
        public List<SaveStudentLearningDataRequestWrongQuestions> WrongQuestions { get; set; }
        public class SaveStudentLearningDataRequestWrongQuestions : TeaModel {
            [NameInMap("knowledgePoints")]
            [Validation(Required=false)]
            public List<string> KnowledgePoints { get; set; }

            [NameInMap("questionNo")]
            [Validation(Required=false)]
            public string QuestionNo { get; set; }

            [NameInMap("questionPictureNum")]
            [Validation(Required=false)]
            public int? QuestionPictureNum { get; set; }

            [NameInMap("standardAnswerPictureNum")]
            [Validation(Required=false)]
            public int? StandardAnswerPictureNum { get; set; }

            [NameInMap("userAnswerPictureNum")]
            [Validation(Required=false)]
            public int? UserAnswerPictureNum { get; set; }

        }

    }

}
