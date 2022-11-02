// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class AddUserAccountRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 渠道账号名
        /// </summary>
        [NameInMap("channelAccountName")]
        [Validation(Required=false)]
        public string ChannelAccountName { get; set; }

        /// <summary>
        /// 渠道用户标识
        /// </summary>
        [NameInMap("channelUserIdentify")]
        [Validation(Required=false)]
        public string ChannelUserIdentify { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 企业标识
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
