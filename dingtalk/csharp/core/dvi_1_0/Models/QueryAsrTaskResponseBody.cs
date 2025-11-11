// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryAsrTaskResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAsrTaskResponseBodyResult Result { get; set; }
        public class QueryAsrTaskResponseBodyResult : TeaModel {
            [NameInMap("bizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("resultInfo")]
            [Validation(Required=false)]
            public QueryAsrTaskResponseBodyResultResultInfo ResultInfo { get; set; }
            public class QueryAsrTaskResponseBodyResultResultInfo : TeaModel {
                [NameInMap("paragraphList")]
                [Validation(Required=false)]
                public List<QueryAsrTaskResponseBodyResultResultInfoParagraphList> ParagraphList { get; set; }
                public class QueryAsrTaskResponseBodyResultResultInfoParagraphList : TeaModel {
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("paragraph")]
                    [Validation(Required=false)]
                    public string Paragraph { get; set; }

                    [NameInMap("sentenceList")]
                    [Validation(Required=false)]
                    public List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList> SentenceList { get; set; }
                    public class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceList : TeaModel {
                        [NameInMap("endTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("sentence")]
                        [Validation(Required=false)]
                        public string Sentence { get; set; }

                        [NameInMap("startTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                        [NameInMap("wordList")]
                        [Validation(Required=false)]
                        public List<QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList> WordList { get; set; }
                        public class QueryAsrTaskResponseBodyResultResultInfoParagraphListSentenceListWordList : TeaModel {
                            [NameInMap("endTime")]
                            [Validation(Required=false)]
                            public long? EndTime { get; set; }

                            [NameInMap("startTime")]
                            [Validation(Required=false)]
                            public long? StartTime { get; set; }

                            [NameInMap("text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                    }

                    [NameInMap("speakerId")]
                    [Validation(Required=false)]
                    public string SpeakerId { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

            }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
