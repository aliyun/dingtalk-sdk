// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdiot_1_0.Models
{
    public class BindSystemRequest : TeaModel {
        /// <summary>
        /// 与三方平台绑定验证的临时授权码。
        /// </summary>
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// 三方平台的用户ID。
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// 三方平台的用户名。
        /// </summary>
        [NameInMap("clientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// 三方平台的用户的钉钉物联组织ID。
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 三方平台协定的其它参数。
        /// </summary>
        [NameInMap("extraData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraData { get; set; }

    }

}
