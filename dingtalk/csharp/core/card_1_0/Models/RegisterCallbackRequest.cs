// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class RegisterCallbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mySecret</para>
        /// </summary>
        [NameInMap("apiSecret")]
        [Validation(Required=false)]
        public string ApiSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routeKey-12</para>
        /// </summary>
        [NameInMap("callbackRouteKey")]
        [Validation(Required=false)]
        public string CallbackRouteKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.myurl/callback">https://www.myurl/callback</a></para>
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("forceUpdate")]
        [Validation(Required=false)]
        public bool? ForceUpdate { get; set; }

    }

}
