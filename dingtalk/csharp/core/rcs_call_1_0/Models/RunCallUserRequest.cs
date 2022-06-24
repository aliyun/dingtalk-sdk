// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrcs_call_1_0.Models
{
    public class RunCallUserRequest : TeaModel {
        /// <summary>
        /// 授权isv套件企业的corpid
        /// </summary>
        [NameInMap("authorizeCorpId")]
        [Validation(Required=false)]
        public string AuthorizeCorpId { get; set; }

        /// <summary>
        /// 授权isv套件企业的员工userid
        /// </summary>
        [NameInMap("authorizeUserId")]
        [Validation(Required=false)]
        public string AuthorizeUserId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// isv套件所属企业下的员工userid
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
