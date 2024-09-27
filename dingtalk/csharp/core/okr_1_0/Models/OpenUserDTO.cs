// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenUserDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0342464558835299</para>
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>小明</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64cd2e9bb80efb17244c650d</para>
        /// </summary>
        [NameInMap("userUid")]
        [Validation(Required=false)]
        public string UserUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2639402752-1812711657</para>
        /// </summary>
        [NameInMap("workNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
