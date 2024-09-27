// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgateway_1_0.Models
{
    public class OpenConnectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>wss://open-connection.dingtalk.com/connect</para>
        /// </summary>
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67e5aeb3-de99-11ed-897e-e251245ed5d2</para>
        /// </summary>
        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
