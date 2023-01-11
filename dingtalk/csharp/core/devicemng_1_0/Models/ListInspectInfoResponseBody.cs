// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListInspectInfoResponseBody : TeaModel {
        /// <summary>
        /// 结果集
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListInspectInfoResponseBodyResult> Result { get; set; }
        public class ListInspectInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// 设备码
            /// </summary>
            [NameInMap("deviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            [NameInMap("deviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 处理时间
            /// </summary>
            [NameInMap("handleTime")]
            [Validation(Required=false)]
            public string HandleTime { get; set; }

            /// <summary>
            /// 维修人员
            /// </summary>
            [NameInMap("maintenanceStaff")]
            [Validation(Required=false)]
            public List<string> MaintenanceStaff { get; set; }

            /// <summary>
            /// 巡检表名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 巡检/保养内容
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 处理结果（1:未修复，2:已修复）
            /// </summary>
            [NameInMap("repairStatus")]
            [Validation(Required=false)]
            public int? RepairStatus { get; set; }

            /// <summary>
            /// 巡检/保养结果：0:正常，1:异常
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 类型（inspect：巡检，protect：保养）
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 总共数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
