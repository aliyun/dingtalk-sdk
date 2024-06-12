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

        [NameInMap("pictureNum")]
        [Validation(Required=false)]
        public long? PictureNum { get; set; }

        [NameInMap("pictureSize")]
        [Validation(Required=false)]
        public string PictureSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
