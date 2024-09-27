// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class PullDeviceToGroupRequest : TeaModel {
        [NameInMap("deviceCodes")]
        [Validation(Required=false)]
        public List<string> DeviceCodes { get; set; }

        [NameInMap("deviceUuids")]
        [Validation(Required=false)]
        public List<string> DeviceUuids { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cide+m5TmAcxA3OU6Un59xxxx==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager1111</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

    }

}
