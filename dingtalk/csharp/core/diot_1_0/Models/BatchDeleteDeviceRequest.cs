// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchDeleteDeviceRequest : TeaModel {
        /// <summary>
        /// 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 设备ID列表，最多500条。
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
