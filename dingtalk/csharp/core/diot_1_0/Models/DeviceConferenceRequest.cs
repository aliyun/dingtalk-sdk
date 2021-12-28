// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class DeviceConferenceRequest : TeaModel {
        /// <summary>
        /// 会议主题，最多不能超20个中文。
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        /// <summary>
        /// 钉钉会议ID，加入已存在的会议必填。
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 钉钉会议密码，加入已存在的会议必填。
        /// </summary>
        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        /// <summary>
        /// 需要邀请的设备ID，最多5个。
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
