// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoAddGeneralFileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaaa</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个财务制度相关的文件</para>
        /// </summary>
        [NameInMap("fileDesc")]
        [Validation(Required=false)]
        public string FileDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa.doc</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("tagList")]
        [Validation(Required=false)]
        public List<ChatMemoAddGeneralFileRequestTagList> TagList { get; set; }
        public class ChatMemoAddGeneralFileRequestTagList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>产品名</para>
            /// </summary>
            [NameInMap("tagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            [NameInMap("tagValueList")]
            [Validation(Required=false)]
            public List<string> TagValueList { get; set; }

        }

    }

}
