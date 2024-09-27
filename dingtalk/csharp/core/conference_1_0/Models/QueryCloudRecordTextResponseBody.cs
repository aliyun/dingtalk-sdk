// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordTextResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryCloudRecordTextResponseBodyParagraphList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7940</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1631172045153000</para>
            /// </summary>
            [NameInMap("nextTtoken")]
            [Validation(Required=false)]
            public long? NextTtoken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>嘿！你好，这里是小钉</para>
            /// </summary>
            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44444</para>
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryCloudRecordTextResponseBodyParagraphListSentenceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>7940</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这里是小钉</para>
                /// </summary>
                [NameInMap("sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7940</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WFBkgJvt0xxxxSaA1jK4sgiEiE</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("wordList")]
                [Validation(Required=false)]
                public List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7940</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7940</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>这里</para>
                    /// </summary>
                    [NameInMap("word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1631172050535000#0</para>
                    /// </summary>
                    [NameInMap("wordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7940</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WFBkgJvt0xxxxSaA1jK4sgiEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
