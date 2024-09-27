// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgateway_1_0.Models
{
    public class OpenConnectionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suiteudabcd123</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9W1berqrwfs</para>
        /// </summary>
        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("extras")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extras { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32.78.48.10</para>
        /// </summary>
        [NameInMap("localIp")]
        [Validation(Required=false)]
        public string LocalIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("subscriptions")]
        [Validation(Required=false)]
        public List<OpenConnectionRequestSubscriptions> Subscriptions { get; set; }
        public class OpenConnectionRequestSubscriptions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1.0/im/bot/messages/get</para>
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EVENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
