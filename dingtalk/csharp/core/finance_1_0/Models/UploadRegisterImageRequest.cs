// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UploadRegisterImageRequest : TeaModel {
        /// <summary>
        /// 图片内容
        /// </summary>
        [NameInMap("imageContent")]
        [Validation(Required=false)]
        public string ImageContent { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [NameInMap("imageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 图片类型
        /// </summary>
        [NameInMap("imageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// 主机构id
        /// </summary>
        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        /// <summary>
        /// 进件渠道
        /// </summary>
        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

    }

}
