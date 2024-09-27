// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D:****.mp4</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87712****6723412</para>
        /// </summary>
        [NameInMap("mcnId")]
        [Validation(Required=false)]
        public string McnId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cd8b21090b6*********b78fa733</para>
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>视频描述。  长度不超过1024个字符。 UTF-8编码。</para>
        /// </summary>
        [NameInMap("mediaIntroduction")]
        [Validation(Required=false)]
        public string MediaIntroduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UploadTest</para>
        /// </summary>
        [NameInMap("mediaTitle")]
        [Validation(Required=false)]
        public string MediaTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https://<em><b><b>test.cn/image/D22F553</b></b></em>TEST.jpeg</para>
        /// </summary>
        [NameInMap("thumbUrl")]
        [Validation(Required=false)]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edb2*****1090b66</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
