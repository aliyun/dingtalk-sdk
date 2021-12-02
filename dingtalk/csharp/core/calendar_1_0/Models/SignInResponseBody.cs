// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class SignInResponseBody : TeaModel {
        /// <summary>
        /// 签到时间戳
        /// </summary>
        [NameInMap("checkInTime")]
        [Validation(Required=false)]
        public long? CheckInTime { get; set; }

    }

}
