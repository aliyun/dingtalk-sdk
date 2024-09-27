// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoFaqListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatMemoFaqListResponseBodyData> Data { get; set; }
        public class ChatMemoFaqListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>办公室电话是：13223333233</para>
            /// </summary>
            [NameInMap("answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyyyy-aaaaaa-bbbbb-cccccccccc.docx</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>办公室电话是多少</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.dingtalk.com/">http://www.dingtalk.com/</a></para>
            /// </summary>
            [NameInMap("redirection")]
            [Validation(Required=false)]
            public string Redirection { get; set; }

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
