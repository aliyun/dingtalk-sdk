// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCorpUserStatisticResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCorpUserStatisticResponseBodyList> List { get; set; }
        public class QueryCorpUserStatisticResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>w<a href="http://www.xxxxx.com/xxx.jpg">www.xxxxx.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("receiveCnt")]
            [Validation(Required=false)]
            public long? ReceiveCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("sendCnt")]
            [Validation(Required=false)]
            public long? SendCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RCsp7PJmmTUr7w0hbs9aKAiEiE</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
