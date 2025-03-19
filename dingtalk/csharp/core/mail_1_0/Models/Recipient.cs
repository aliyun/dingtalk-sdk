// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class Recipient : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@b.com">zhangsan@b.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public Stream Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ZhangSan</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public Stream Name { get; set; }

    }

}
