// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoGetFileListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ChatMemoGetFileListResponseBodyData> Data { get; set; }
        public class ChatMemoGetFileListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>财务制度文件</para>
            /// </summary>
            [NameInMap("fileDesc")]
            [Validation(Required=false)]
            public string FileDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaaaa.doc</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyyyy-aaaaaa-bbbbb-cccccccccc.docx</para>
            /// </summary>
            [NameInMap("mediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            [NameInMap("tagMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> TagMap { get; set; }

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
