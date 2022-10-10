// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ActivateDeviceRequest : TeaModel {
        /// <summary>
        /// 授权码
        /// </summary>
        [NameInMap("licenseKey")]
        [Validation(Required=false)]
        public string LicenseKey { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
