// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryDevicePropertiesRequest : TeaModel {
        /// <summary>
        /// 设备属性名称列表
        /// </summary>
        [NameInMap("propertyNames")]
        [Validation(Required=false)]
        public List<string> PropertyNames { get; set; }

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
