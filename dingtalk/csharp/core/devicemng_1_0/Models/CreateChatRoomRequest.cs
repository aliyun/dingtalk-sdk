// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class CreateChatRoomRequest : TeaModel {
        [NameInMap("chatGroupName")]
        [Validation(Required=false)]
        public string ChatGroupName { get; set; }

        [NameInMap("deviceCodes")]
        [Validation(Required=false)]
        public List<string> DeviceCodes { get; set; }

        [NameInMap("deviceTypeId")]
        [Validation(Required=false)]
        public string DeviceTypeId { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("ownerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        [NameInMap("roleList")]
        [Validation(Required=false)]
        public List<string> RoleList { get; set; }

    }

}
