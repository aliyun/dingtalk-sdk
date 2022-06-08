// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class EditDeviceAdminRequest : TeaModel {
        /// <summary>
        /// 需要处理的设备编号。客户侧生成的设备标识，能够唯一标识一个设备，该字段与uuid字段需要二选一，并且不能都填充。
        /// </summary>
        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 角色唯一标识
        /// </summary>
        [NameInMap("roleUuid")]
        [Validation(Required=false)]
        public string RoleUuid { get; set; }

        /// <summary>
        /// 需要编辑的角色唯一标识，非必填，不传默认为管理员。
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

        /// <summary>
        /// 设备唯一标识，钉钉侧生成的设备标识，能够唯一标识一个设备，该字段与deviceCode字段需要二选一，并且不能都填充。
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
