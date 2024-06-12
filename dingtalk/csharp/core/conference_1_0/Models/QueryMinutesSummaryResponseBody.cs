// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryMinutesSummaryResponseBody : TeaModel {
        [NameInMap("summary")]
        [Validation(Required=false)]
        public QueryMinutesSummaryResponseBodySummary Summary { get; set; }
        public class QueryMinutesSummaryResponseBodySummary : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryActions Actions { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryActions : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("autoChapters")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryAutoChapters> AutoChapters { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryAutoChapters : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("headline")]
                [Validation(Required=false)]
                public string Headline { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("conversationalSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryConversationalSummary> ConversationalSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryConversationalSummary : TeaModel {
                [NameInMap("speakerId")]
                [Validation(Required=false)]
                public string SpeakerId { get; set; }

                [NameInMap("speakerName")]
                [Validation(Required=false)]
                public string SpeakerName { get; set; }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            [NameInMap("keySentences")]
            [Validation(Required=false)]
            public QueryMinutesSummaryResponseBodySummaryKeySentences KeySentences { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryKeySentences : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public long? SentenceId { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public long? Start { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("paragraphSummary")]
            [Validation(Required=false)]
            public string ParagraphSummary { get; set; }

            [NameInMap("questionsAnsweringSummary")]
            [Validation(Required=false)]
            public List<QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary> QuestionsAnsweringSummary { get; set; }
            public class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary : TeaModel {
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("sentenceIdsOfAnswer")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfAnswer { get; set; }

                [NameInMap("sentenceIdsOfQuestion")]
                [Validation(Required=false)]
                public List<long?> SentenceIdsOfQuestion { get; set; }

            }

        }

    }

}
