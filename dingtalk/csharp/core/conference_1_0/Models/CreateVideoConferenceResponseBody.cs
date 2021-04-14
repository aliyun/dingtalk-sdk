// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateVideoConferenceResponseBody : TeaModel {
        /// <summary>
        /// conferenceId
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// 会议密码
        /// </summary>
        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        /// <summary>
        /// 主持人密码
        /// </summary>
        [NameInMap("hostPassword")]
        [Validation(Required=false)]
        public string HostPassword { get; set; }

        /// <summary>
        /// 入会链接
        /// </summary>
        [NameInMap("externalLinkUrl")]
        [Validation(Required=false)]
        public string ExternalLinkUrl { get; set; }

        /// <summary>
        /// 电话入会号码
        /// </summary>
        [NameInMap("phoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

    }

}
