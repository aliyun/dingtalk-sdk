// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateWrongQuestionsRequest : TeaModel {
        [NameInMap("answerContent")]
        [Validation(Required=false)]
        public string AnswerContent { get; set; }

        [NameInMap("difficultyLevel")]
        [Validation(Required=false)]
        public int? DifficultyLevel { get; set; }

        [NameInMap("explainAudio")]
        [Validation(Required=false)]
        public string ExplainAudio { get; set; }

        [NameInMap("explainContent")]
        [Validation(Required=false)]
        public string ExplainContent { get; set; }

        [NameInMap("generateTime")]
        [Validation(Required=false)]
        public long? GenerateTime { get; set; }

        [NameInMap("knowledgePointList")]
        [Validation(Required=false)]
        public List<string> KnowledgePointList { get; set; }

        [NameInMap("ownerCode")]
        [Validation(Required=false)]
        public string OwnerCode { get; set; }

        [NameInMap("ownerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("proficiencyLevel")]
        [Validation(Required=false)]
        public int? ProficiencyLevel { get; set; }

        [NameInMap("questionAudio")]
        [Validation(Required=false)]
        public string QuestionAudio { get; set; }

        [NameInMap("questionContent")]
        [Validation(Required=false)]
        public string QuestionContent { get; set; }

        [NameInMap("questionExtension")]
        [Validation(Required=false)]
        public Dictionary<string, string> QuestionExtension { get; set; }

        [NameInMap("questionPicUrl")]
        [Validation(Required=false)]
        public string QuestionPicUrl { get; set; }

        [NameInMap("questionType")]
        [Validation(Required=false)]
        public string QuestionType { get; set; }

        [NameInMap("sourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}
