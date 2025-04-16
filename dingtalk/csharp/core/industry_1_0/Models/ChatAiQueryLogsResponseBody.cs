// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAiQueryLogsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatAiQueryLogsResponseBodyData> Data { get; set; }
        public class ChatAiQueryLogsResponseBodyData : TeaModel {
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            [NameInMap("feedbackState")]
            [Validation(Required=false)]
            public int? FeedbackState { get; set; }

            [NameInMap("feedbackStateDesc")]
            [Validation(Required=false)]
            public string FeedbackStateDesc { get; set; }

            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            [NameInMap("questionTime")]
            [Validation(Required=false)]
            public long? QuestionTime { get; set; }

            [NameInMap("response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            [NameInMap("runtime")]
            [Validation(Required=false)]
            public long? Runtime { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("sessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
