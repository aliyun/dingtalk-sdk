// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomDeviceRequest : TeaModel {
        /// <summary>
        /// 查询设备id
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// 查询设备unionId
        /// </summary>
        [NameInMap("deviceUnionId")]
        [Validation(Required=false)]
        public string DeviceUnionId { get; set; }

        /// <summary>
        /// 查询人unionId
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

    }

}
