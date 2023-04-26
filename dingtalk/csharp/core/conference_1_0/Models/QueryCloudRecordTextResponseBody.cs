// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordTextResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryCloudRecordTextResponseBodyParagraphList : TeaModel {
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("nextTtoken")]
            [Validation(Required=false)]
            public long? NextTtoken { get; set; }

            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryCloudRecordTextResponseBodyParagraphListSentenceList : TeaModel {
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
                public List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList : TeaModel {
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

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
