// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class DeleteTrustedDeviceRequest : TeaModel {
        /// <summary>
        /// 是否踢下线
        /// </summary>
        [NameInMap("kickOff")]
        [Validation(Required=false)]
        public bool? KickOff { get; set; }

        /// <summary>
        /// mac地址
        /// </summary>
        [NameInMap("macAddress")]
        [Validation(Required=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// 员工userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
