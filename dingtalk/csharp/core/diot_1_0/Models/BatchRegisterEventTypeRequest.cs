// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchRegisterEventTypeRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventTypes")]
        [Validation(Required=false)]
        public List<BatchRegisterEventTypeRequestEventTypes> EventTypes { get; set; }
        public class BatchRegisterEventTypeRequestEventTypes : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("eventTypeName")]
            [Validation(Required=false)]
            public string EventTypeName { get; set; }

        }

    }

}
