// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDeviceChatRoomRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>REPAIR_GROUP</para>
        /// </summary>
        [NameInMap("chatType")]
        [Validation(Required=false)]
        public string ChatType { get; set; }

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
        /// <para>xxxxxxx</para>
        /// </summary>
        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>设备维修群</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
