// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class TextToImageRequest : TeaModel {
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pictureNum")]
        [Validation(Required=false)]
        public long? PictureNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024*1024</para>
        /// </summary>
        [NameInMap("pictureSize")]
        [Validation(Required=false)]
        public string PictureSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>帮我生成一个小猫在草坪上奔跑的图片</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
