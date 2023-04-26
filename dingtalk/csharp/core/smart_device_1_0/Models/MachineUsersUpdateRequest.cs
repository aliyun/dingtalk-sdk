// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class MachineUsersUpdateRequest : TeaModel {
        [NameInMap("addDeptIds")]
        [Validation(Required=false)]
        public List<long?> AddDeptIds { get; set; }

        [NameInMap("addUserIds")]
        [Validation(Required=false)]
        public List<string> AddUserIds { get; set; }

        [NameInMap("delDeptIds")]
        [Validation(Required=false)]
        public List<long?> DelDeptIds { get; set; }

        [NameInMap("delUserIds")]
        [Validation(Required=false)]
        public List<string> DelUserIds { get; set; }

        [NameInMap("devIds")]
        [Validation(Required=false)]
        public List<long?> DevIds { get; set; }

        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
