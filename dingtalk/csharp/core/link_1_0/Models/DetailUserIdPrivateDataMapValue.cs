// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class DetailUserIdPrivateDataMapValue : TeaModel {
        /// <summary>
        /// 卡片模板的文本内容参数。
        /// </summary>
        [NameInMap("cardParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> CardParamMap { get; set; }

        /// <summary>
        /// 卡片模板的图片内容参数。
        /// </summary>
        [NameInMap("cardMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> CardMediaIdParamMap { get; set; }

    }

}
