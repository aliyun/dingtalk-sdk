// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ExclusivePcAlertRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("imageMediaId")]
        [Validation(Required=false)]
        public string ImageMediaId { get; set; }

        [NameInMap("openLink")]
        [Validation(Required=false)]
        public string OpenLink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
