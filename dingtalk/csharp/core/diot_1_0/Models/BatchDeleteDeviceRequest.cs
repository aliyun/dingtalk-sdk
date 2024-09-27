// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BatchDeleteDeviceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding12345</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

    }

}
