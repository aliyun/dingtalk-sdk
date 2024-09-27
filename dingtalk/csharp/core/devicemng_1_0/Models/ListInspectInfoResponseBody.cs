// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListInspectInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInspectInfoResponseBodyResult> Result { get; set; }
        public class ListInspectInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testDeviceCode</para>
            /// </summary>
            [NameInMap("deviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试设备名称</para>
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-10 12:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-09-10 12:00</para>
            /// </summary>
            [NameInMap("handleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            [NameInMap("maintenanceStaff")]
            [Validation(Required=false)]
            public List<string> MaintenanceStaff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>巡检表F</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>巡检项1：高度（正常)</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("repairStatus")]
            [Validation(Required=false)]
            public int? RepairStatus { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inspect</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
