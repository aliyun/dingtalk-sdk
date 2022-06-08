// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateDeviceChatRoomRequest : TeaModel {
        /// <summary>
        /// 场景群类型，不填，为默认普通设备群，示例值--维修群：REPAIR_GROUP，点检群:INSPECT_GROUP,保养群：MAINTAIN_GROUP。
        /// </summary>
        [NameInMap("chatType")]
        [Validation(Required=false)]
        public string ChatType { get; set; }

        /// <summary>
        /// 设备编码，客户侧生成的设备标识，能够唯一标识一个设备，该字段与deviceUuids字段需要二选一，并且不能都填充。
        /// </summary>
        [NameInMap("deviceCodes")]
        [Validation(Required=false)]
        public List<string> DeviceCodes { get; set; }

        /// <summary>
        /// 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCodes字段需要二选一，并且不能都填充。
        /// </summary>
        [NameInMap("deviceUuids")]
        [Validation(Required=false)]
        public List<string> DeviceUuids { get; set; }

        /// <summary>
        /// 群主钉钉账户。
        /// </summary>
        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// 设备场景群名称。
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 需要被拉入群聊的钉钉账号，可以传多个，通过英文逗号分隔。
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
