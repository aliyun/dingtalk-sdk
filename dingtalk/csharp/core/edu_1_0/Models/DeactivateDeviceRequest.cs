// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeactivateDeviceRequest : TeaModel {
        /// <summary>
        /// 设备型号
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// 设备sn码
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
