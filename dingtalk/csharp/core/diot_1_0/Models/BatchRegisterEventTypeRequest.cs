// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterEventTypeRequest : TeaModel {
        /// <summary>
        /// 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 事件类型列表，最多支持添加500个。
        /// </summary>
        [NameInMap("eventTypes")]
        [Validation(Required=false)]
        public List<BatchRegisterEventTypeRequestEventTypes> EventTypes { get; set; }
        public class BatchRegisterEventTypeRequestEventTypes : TeaModel {
            /// <summary>
            /// 事件类型(唯一)，最长20个字符。
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// 事件类型名称，长度4-20个字符，一个中文汉字算2个字符。
            /// </summary>
            [NameInMap("eventTypeName")]
            [Validation(Required=false)]
            public string EventTypeName { get; set; }

        }

    }

}
