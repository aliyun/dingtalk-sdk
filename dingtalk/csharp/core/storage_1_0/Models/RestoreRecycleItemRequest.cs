// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public RestoreRecycleItemRequestOption Option { get; set; }
        public class RestoreRecycleItemRequestOption : TeaModel {
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }
        };

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
