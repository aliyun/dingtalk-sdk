// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CreateApproveRequest : TeaModel {
        /// <summary>
        /// 三方审批单id，全局唯一
        /// </summary>
        [NameInMap("approveId")]
        [Validation(Required=false)]
        public string ApproveId { get; set; }

        /// <summary>
        /// 审批人员工id
        /// </summary>
        [NameInMap("opUserid")]
        [Validation(Required=false)]
        public string OpUserid { get; set; }

        /// <summary>
        /// 审批单关联的打卡信息
        /// </summary>
        [NameInMap("punchParam")]
        [Validation(Required=false)]
        public CreateApproveRequestPunchParam PunchParam { get; set; }
        public class CreateApproveRequestPunchParam : TeaModel {
            /// <summary>
            /// 地理位置标识：wifi:ssid_macAddress ble: deviceId gps:longitude_latitude
            /// </summary>
            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            /// <summary>
            /// 地理位置名称
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// 地理位置类型：wifi/ble/gps
            /// </summary>
            [NameInMap("positionType")]
            [Validation(Required=false)]
            public string PositionType { get; set; }

            /// <summary>
            /// 打卡时间，单位毫秒
            /// </summary>
            [NameInMap("punchTime")]
            [Validation(Required=false)]
            public long? PunchTime { get; set; }

        }

        /// <summary>
        /// 子类型名称，最大长度20个字符
        /// </summary>
        [NameInMap("subType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// 审批单类型名称，最大长度20个字符
        /// </summary>
        [NameInMap("tagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

    }

}
