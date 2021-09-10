// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordTextResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// MP4格式下载链接
        /// </summary>
        [NameInMap("paragraphList")]
        [Validation(Required=false)]
        public List<QueryCloudRecordTextResponseBodyParagraphList> ParagraphList { get; set; }
        public class QueryCloudRecordTextResponseBodyParagraphList : TeaModel {
            /// <summary>
            /// 游标，下次查询时使用
            /// </summary>
            [NameInMap("nextTtoken")]
            [Validation(Required=false)]
            public long? NextTtoken { get; set; }

            /// <summary>
            /// 状态，暂不解析
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// 发言人unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 发言人昵称
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 云录制id
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// 开始时间，毫秒
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 结束时间，毫秒
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 段落内容
            /// </summary>
            [NameInMap("paragraph")]
            [Validation(Required=false)]
            public string Paragraph { get; set; }

            /// <summary>
            /// 句子列表
            /// </summary>
            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<QueryCloudRecordTextResponseBodyParagraphListSentenceList> SentenceList { get; set; }
            public class QueryCloudRecordTextResponseBodyParagraphListSentenceList : TeaModel {
                /// <summary>
                /// 用户unionId
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// 句子
                /// </summary>
                [NameInMap("sentence")]
                [Validation(Required=false)]
                public string Sentence { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// 单词列表
                /// </summary>
                [NameInMap("wordList")]
                [Validation(Required=false)]
                public List<QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList> WordList { get; set; }
                public class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList : TeaModel {
                    /// <summary>
                    /// 单词
                    /// </summary>
                    [NameInMap("word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                    /// <summary>
                    /// 开始时间
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// 结束时间
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// 单词id
                    /// </summary>
                    [NameInMap("wordId")]
                    [Validation(Required=false)]
                    public string WordId { get; set; }

                }

            }

        }

    }

}
