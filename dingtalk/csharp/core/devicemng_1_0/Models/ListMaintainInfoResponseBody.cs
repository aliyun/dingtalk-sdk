// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class ListMaintainInfoResponseBody : TeaModel {
        /// <summary>
        /// 结果集
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMaintainInfoResponseBodyResult> Result { get; set; }
        public class ListMaintainInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// 报修设备码
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
            /// 报修时间
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
            /// 报修人
            /// </summary>
            [NameInMap("maintenanceStaff")]
            [Validation(Required=false)]
            public List<string> MaintenanceStaff { get; set; }

            /// <summary>
            /// 处理结果，0:同意，1:拒绝，2:终止，3:删除，4:进行中
            /// </summary>
            [NameInMap("processState")]
            [Validation(Required=false)]
            public int? ProcessState { get; set; }

            /// <summary>
            /// 异常描述
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 总共的数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
