// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddShareCidListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasShareSuccess")]
        [Validation(Required=false)]
        public bool? HasShareSuccess { get; set; }

        [NameInMap("shareSuccessGroupList")]
        [Validation(Required=false)]
        public List<string> ShareSuccessGroupList { get; set; }

    }

}
