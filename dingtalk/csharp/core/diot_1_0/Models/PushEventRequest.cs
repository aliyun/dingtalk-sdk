// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class PushEventRequest : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("extraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("occurrenceTime")]
        [Validation(Required=false)]
        public long? OccurrenceTime { get; set; }

        [NameInMap("picUrls")]
        [Validation(Required=false)]
        public List<string> PicUrls { get; set; }

    }

}
