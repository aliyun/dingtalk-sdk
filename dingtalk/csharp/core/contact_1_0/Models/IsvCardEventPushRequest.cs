// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class IsvCardEventPushRequest : TeaModel {
        /// <summary>
        /// 事件参数
        /// </summary>
        [NameInMap("eventParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> EventParams { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// ISV名片ID
        /// </summary>
        [NameInMap("isvCardId")]
        [Validation(Required=false)]
        public string IsvCardId { get; set; }

        /// <summary>
        /// ISV用户TOKEN
        /// </summary>
        [NameInMap("isvToken")]
        [Validation(Required=false)]
        public string IsvToken { get; set; }

        /// <summary>
        /// ISV用户iD
        /// </summary>
        [NameInMap("isvUid")]
        [Validation(Required=false)]
        public string IsvUid { get; set; }

    }

}
