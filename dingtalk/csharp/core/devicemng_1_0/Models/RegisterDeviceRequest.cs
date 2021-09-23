// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class RegisterDeviceRequest : TeaModel {
        /// <summary>
        /// 组织id
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// 设备标识
        /// </summary>
        [NameInMap("deviceKey")]
        [Validation(Required=false)]
        public string DeviceKey { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// 管理员userId列表
        /// </summary>
        [NameInMap("managers")]
        [Validation(Required=false)]
        public string Managers { get; set; }

        /// <summary>
        /// 协助者userId列表
        /// </summary>
        [NameInMap("collaborators")]
        [Validation(Required=false)]
        public string Collaborators { get; set; }

        /// <summary>
        /// 设备描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 创建者userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
