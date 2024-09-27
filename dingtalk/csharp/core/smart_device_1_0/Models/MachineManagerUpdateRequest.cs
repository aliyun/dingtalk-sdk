// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class MachineManagerUpdateRequest : TeaModel {
        [NameInMap("atmManagerRightMap")]
        [Validation(Required=false)]
        public MachineManagerUpdateRequestAtmManagerRightMap AtmManagerRightMap { get; set; }
        public class MachineManagerUpdateRequestAtmManagerRightMap : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("attendancePersonManage")]
            [Validation(Required=false)]
            public bool? AttendancePersonManage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("bluetoothPunchManage")]
            [Validation(Required=false)]
            public bool? BluetoothPunchManage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deviceReset")]
            [Validation(Required=false)]
            public bool? DeviceReset { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("deviceSettings")]
            [Validation(Required=false)]
            public bool? DeviceSettings { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("facePunchManage")]
            [Validation(Required=false)]
            public bool? FacePunchManage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("fingerPunchManage")]
            [Validation(Required=false)]
            public bool? FingerPunchManage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>165441111</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public long? DeviceId { get; set; }

        [NameInMap("scopeDeptIds")]
        [Validation(Required=false)]
        public List<long?> ScopeDeptIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
