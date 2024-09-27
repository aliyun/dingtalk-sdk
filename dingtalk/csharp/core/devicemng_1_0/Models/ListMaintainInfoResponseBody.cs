// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListMaintainInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMaintainInfoResponseBodyResult> Result { get; set; }
        public class ListMaintainInfoResponseBodyResult : TeaModel {
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
            /// <para>2022-7-14 13:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022=12-25 15:00</para>
            /// </summary>
            [NameInMap("handleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            [NameInMap("maintenanceStaff")]
            [Validation(Required=false)]
            public List<string> MaintenanceStaff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("processState")]
            [Validation(Required=false)]
            public int? ProcessState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>温度过高导致异常</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
