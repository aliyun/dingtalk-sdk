// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class UpdateInterviewSignInInfoRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 面试签到时间（单位：毫秒）
        /// </summary>
        [NameInMap("signInTimeMillis")]
        [Validation(Required=false)]
        public long? SignInTimeMillis { get; set; }

    }

}
