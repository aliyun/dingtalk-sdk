// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EventTrackRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actionKey")]
        [Validation(Required=false)]
        public string ActionKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actionTime")]
        [Validation(Required=false)]
        public string ActionTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("bizReq")]
        [Validation(Required=false)]
        public string BizReq { get; set; }

        [NameInMap("bizResp")]
        [Validation(Required=false)]
        public string BizResp { get; set; }

        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("eventUnit")]
        [Validation(Required=false)]
        public string EventUnit { get; set; }

        [NameInMap("eventValue")]
        [Validation(Required=false)]
        public string EventValue { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
