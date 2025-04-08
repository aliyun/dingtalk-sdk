// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class DeleteMessagesRequest : TeaModel {
        [NameInMap("deleteType")]
        [Validation(Required=false)]
        public string DeleteType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

    }

}
