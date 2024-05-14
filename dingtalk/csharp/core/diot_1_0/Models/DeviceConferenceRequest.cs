// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class DeviceConferenceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
