// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class PushEventRequest : TeaModel {
        /// <summary>
        /// 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 触发事件设备ID。
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 事件ID。
        /// </summary>
        [NameInMap("eventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// 事件名称，长度4-20个字符，一个中文汉字算2个字符。
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// 事件类型，最长20个字符。
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// 第三方平台定制参数，企业内部系统忽略。
        /// </summary>
        [NameInMap("extraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

        /// <summary>
        /// 事件发生地点。
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 事件文字信息。
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// 事件发生事件，Unix时间戳，单位毫秒。
        /// </summary>
        [NameInMap("occurrenceTime")]
        [Validation(Required=false)]
        public long? OccurrenceTime { get; set; }

        /// <summary>
        /// 事件图片地址列表。
        /// </summary>
        [NameInMap("picUrls")]
        [Validation(Required=false)]
        public List<string> PicUrls { get; set; }

    }

}
