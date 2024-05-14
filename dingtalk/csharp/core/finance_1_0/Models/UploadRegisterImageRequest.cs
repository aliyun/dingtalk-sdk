// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadRegisterImageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("imageContent")]
        [Validation(Required=false)]
        public string ImageContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("imageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("imageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

    }

}
