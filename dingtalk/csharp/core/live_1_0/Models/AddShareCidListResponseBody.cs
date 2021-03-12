// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddShareCidListResponseBody : TeaModel {
        /// <summary>
        /// 是否联播成功
        /// </summary>
        [NameInMap("hasShareSuccess")]
        [Validation(Required=false)]
        public bool? HasShareSuccess { get; set; }

        /// <summary>
        /// 本次请求成功联播的群列表
        /// </summary>
        [NameInMap("shareSuccessGroupList")]
        [Validation(Required=false)]
        public List<string> ShareSuccessGroupList { get; set; }

    }

}
