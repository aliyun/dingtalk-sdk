// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class MachineUsersUpdateRequest : TeaModel {
        /// <summary>
        /// 新增的员工id列表
        /// </summary>
        [NameInMap("addUserIds")]
        [Validation(Required=false)]
        public List<string> AddUserIds { get; set; }

        /// <summary>
        /// 移除的员工id列表
        /// </summary>
        [NameInMap("delUserIds")]
        [Validation(Required=false)]
        public List<string> DelUserIds { get; set; }

        /// <summary>
        /// 设备唯一标识id列表，Long数组
        /// </summary>
        [NameInMap("devIds")]
        [Validation(Required=false)]
        public List<long?> DevIds { get; set; }

        /// <summary>
        /// 设备唯一标识id列表，字符串数组
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

    }

}
