// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryMinutesTextResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryMinutesTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryMinutesTextResponseBodyParagraphList : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("paragraphId")]
            [Validation(Required=false)]
            public long? ParagraphId { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<QueryMinutesTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryMinutesTextResponseBodyParagraphListSentenceList : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("wordList")]
                [Validation(Required=false)]
                public List<QueryMinutesTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryMinutesTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    [NameInMap("word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    [NameInMap("wordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
