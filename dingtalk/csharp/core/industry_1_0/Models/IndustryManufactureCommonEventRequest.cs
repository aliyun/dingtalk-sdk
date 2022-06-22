// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureCommonEventRequest : TeaModel {
        /// <summary>
        /// add 创建事件/update 更新事件
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// 应用appkey
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("bizData")]
        [Validation(Required=false)]
        public Dictionary<string, object> BizData { get; set; }

        /// <summary>
        /// 事件集合，目前仅1个有效
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public List<string> EventType { get; set; }

    }

}
