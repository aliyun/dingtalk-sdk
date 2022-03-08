// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class BatchRegisterDeviceRequest : TeaModel {
        /// <summary>
        /// 设备列表
        /// </summary>
        [NameInMap("deviceList")]
        [Validation(Required=false)]
        public List<BatchRegisterDeviceRequestDeviceList> DeviceList { get; set; }
        public class BatchRegisterDeviceRequestDeviceList : TeaModel {
            /// <summary>
            /// 协助者userId列表
            /// </summary>
            [NameInMap("collaborators")]
            [Validation(Required=false)]
            public string Collaborators { get; set; }

            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public long? DepartmentId { get; set; }

            /// <summary>
            /// 设备描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// 管理员userId列表
            /// </summary>
            [NameInMap("managers")]
            [Validation(Required=false)]
            public string Managers { get; set; }

        }

        /// <summary>
        /// 创建者userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
