// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class RenderBatchCallbackRequest : TeaModel {
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123789</para>
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss/com/a/b.pdf">https://oss/com/a/b.pdf</a></para>
        /// </summary>
        [NameInMap("ossUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>seq-xxx</para>
        /// </summary>
        [NameInMap("sequenceId")]
        [Validation(Required=false)]
        public string SequenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>宜搭</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GMT</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
