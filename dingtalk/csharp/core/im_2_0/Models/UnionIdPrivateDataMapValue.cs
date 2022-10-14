// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class UnionIdPrivateDataMapValue : TeaModel {
        /// <summary>
        /// 卡片模板内容替换参数，包含普通文本类型和多媒体类型。
        /// </summary>
        [NameInMap("cardParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CardParamMap { get; set; }

    }

}
