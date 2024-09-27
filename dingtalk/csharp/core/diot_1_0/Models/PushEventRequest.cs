// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class PushEventRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123456</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>002</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sj123456</para>
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>火焰告警</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fireDetect</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        [NameInMap("extraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>社区南门</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>社区南门发生火焰告警</para>
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1638250958570</para>
        /// </summary>
        [NameInMap("occurrenceTime")]
        [Validation(Required=false)]
        public long? OccurrenceTime { get; set; }

        [NameInMap("picUrls")]
        [Validation(Required=false)]
        public List<string> PicUrls { get; set; }

    }

}
