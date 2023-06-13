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
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("localIp")]
        [Validation(Required=false)]
        public string LocalIp { get; set; }

        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<OpenConnectionRequestSubscriptions> Subscriptions { get; set; }
        public class OpenConnectionRequestSubscriptions : TeaModel {
            [NameInMap("topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
