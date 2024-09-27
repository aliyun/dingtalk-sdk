// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class RegisterAccountsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hexaaaa</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acc-1732245789</para>
        /// </summary>
        [NameInMap("activeCode")]
        [Validation(Required=false)]
        public string ActiveCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding123</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
