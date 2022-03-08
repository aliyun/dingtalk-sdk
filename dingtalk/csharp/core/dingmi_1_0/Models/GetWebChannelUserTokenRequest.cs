// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetWebChannelUserTokenRequest : TeaModel {
        /// <summary>
        /// 登录用户在业务账号体系内的用户id
        /// </summary>
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// 登录用户在业务账号体系内的昵称
        /// </summary>
        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        /// <summary>
        /// 调用方在小蜜客服平台申请的业务账号体系的id
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

    }

}
