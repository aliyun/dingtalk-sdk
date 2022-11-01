// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerInfoRequest : TeaModel {
        /// <summary>
        /// 服务窗帐号ID，可选参数。
        /// 帐号ID用于开发者应用为服务窗所属组织应用场景，此ID可以通过服务窗帐号信息查询接口获取。
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 待查询的服务窗关注者unionId。
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 待查询的服务窗关注者userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
