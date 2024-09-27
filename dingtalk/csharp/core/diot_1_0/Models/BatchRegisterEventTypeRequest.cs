// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterEventTypeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding12345</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("eventTypes")]
        [Validation(Required=false)]
        public List<BatchRegisterEventTypeRequestEventTypes> EventTypes { get; set; }
        public class BatchRegisterEventTypeRequestEventTypes : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fireDetect</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>火焰告警</para>
            /// </summary>
            [NameInMap("eventTypeName")]
            [Validation(Required=false)]
            public string EventTypeName { get; set; }

        }

    }

}
