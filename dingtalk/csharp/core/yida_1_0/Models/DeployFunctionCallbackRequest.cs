// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class DeployFunctionCallbackRequest : TeaModel {
        /// <summary>
        /// 云应用id
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 自定义域名
        /// </summary>
        [NameInMap("customDomain")]
        [Validation(Required=false)]
        public string CustomDomain { get; set; }

        /// <summary>
        /// 部署阶段
        /// </summary>
        [NameInMap("deployStage")]
        [Validation(Required=false)]
        public string DeployStage { get; set; }

        /// <summary>
        /// api网关实例的AppKey
        /// </summary>
        [NameInMap("gateWayAppKey")]
        [Validation(Required=false)]
        public string GateWayAppKey { get; set; }

        /// <summary>
        /// api网关实例的APPSecret
        /// </summary>
        [NameInMap("gateWayAppSecret")]
        [Validation(Required=false)]
        public string GateWayAppSecret { get; set; }

        /// <summary>
        /// api网关二级域名
        /// </summary>
        [NameInMap("gateWayDomain")]
        [Validation(Required=false)]
        public string GateWayDomain { get; set; }

    }

}
