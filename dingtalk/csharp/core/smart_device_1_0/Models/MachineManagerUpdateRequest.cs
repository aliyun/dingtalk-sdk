// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class MachineManagerUpdateRequest : TeaModel {
        /// <summary>
        /// 设备管理员权限点。
        /// </summary>
        [NameInMap("atmManagerRightMap")]
        [Validation(Required=false)]
        public MachineManagerUpdateRequestAtmManagerRightMap AtmManagerRightMap { get; set; }
        public class MachineManagerUpdateRequestAtmManagerRightMap : TeaModel {
            /// <summary>
            /// 添加/删除考勤人员。
            /// </summary>
            [NameInMap("attendancePersonManage")]
            [Validation(Required=false)]
            public bool? AttendancePersonManage { get; set; }

            /// <summary>
            /// 蓝牙打卡管理。
            /// </summary>
            [NameInMap("bluetoothPunchManage")]
            [Validation(Required=false)]
            public bool? BluetoothPunchManage { get; set; }

            /// <summary>
            /// 设备解绑并重置。
            /// </summary>
            [NameInMap("deviceReset")]
            [Validation(Required=false)]
            public bool? DeviceReset { get; set; }

            /// <summary>
            /// 设备设置。
            /// </summary>
            [NameInMap("deviceSettings")]
            [Validation(Required=false)]
            public bool? DeviceSettings { get; set; }

            /// <summary>
            /// 人脸打卡管理。
            /// </summary>
            [NameInMap("facePunchManage")]
            [Validation(Required=false)]
            public bool? FacePunchManage { get; set; }

            /// <summary>
            /// 指纹打卡管理。
            /// </summary>
            [NameInMap("fingerPunchManage")]
            [Validation(Required=false)]
            public bool? FingerPunchManage { get; set; }

        }

        /// <summary>
        /// 设备id。
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public long? DeviceId { get; set; }

        /// <summary>
        /// 权限范围：可管理的部门id列表，-1表示全公司
        /// </summary>
        [NameInMap("scopeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ScopeDeptIds { get; set; }

        /// <summary>
        /// 设备管理员的userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
