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
            [NameInMap("attendancePersonManage")]
            [Validation(Required=false)]
            public bool? AttendancePersonManage { get; set; }
            [NameInMap("bluetoothPunchManage")]
            [Validation(Required=false)]
            public bool? BluetoothPunchManage { get; set; }
            [NameInMap("deviceReset")]
            [Validation(Required=false)]
            public bool? DeviceReset { get; set; }
            [NameInMap("deviceSettings")]
            [Validation(Required=false)]
            public bool? DeviceSettings { get; set; }
            [NameInMap("facePunchManage")]
            [Validation(Required=false)]
            public bool? FacePunchManage { get; set; }
            [NameInMap("fingerPunchManage")]
            [Validation(Required=false)]
            public bool? FingerPunchManage { get; set; }
        };

        /// <summary>
        /// 设备id。
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public long? DeviceId { get; set; }

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
