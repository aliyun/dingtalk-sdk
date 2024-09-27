// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class DeviceConferenceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>设备的应急会议</para>
        /// </summary>
        [NameInMap("confTitle")]
        [Validation(Required=false)]
        public string ConfTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("conferencePassword")]
        [Validation(Required=false)]
        public string ConferencePassword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
