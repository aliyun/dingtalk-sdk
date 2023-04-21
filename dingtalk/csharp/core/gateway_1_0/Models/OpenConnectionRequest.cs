/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgateway_1_0.Models
{
    public class OpenConnectionRequest : TeaModel {
        /// <summary>
        /// 企业三方应用为suiteKey
        /// 企业自建应用为appKey
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// 企业三方应用为suiteSecret
        /// 企业自己应用为appSecret
        /// </summary>
        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<OpenConnectionRequestSubscriptions> Subscriptions { get; set; }
        public class OpenConnectionRequestSubscriptions : TeaModel {
            /// <summary>
            /// 订阅的TOPIC
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// 订阅类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
