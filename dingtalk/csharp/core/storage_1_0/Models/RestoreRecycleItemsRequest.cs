// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemsRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public RestoreRecycleItemsRequestOption Option { get; set; }
        public class RestoreRecycleItemsRequestOption : TeaModel {
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("recycleItemIds")]
        [Validation(Required=false)]
        public List<string> RecycleItemIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
