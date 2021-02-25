// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class PrivateDataValue : TeaModel {
        /// <summary>
        /// 卡片模板内容替换参数-普通文本类型
        /// </summary>
        [NameInMap("cardParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CardParamMap { get; set; }

        /// <summary>
        /// 卡片模板内容替换参数-多媒体类型
        /// </summary>
        [NameInMap("cardMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CardMediaIdParamMap { get; set; }

    }

}
