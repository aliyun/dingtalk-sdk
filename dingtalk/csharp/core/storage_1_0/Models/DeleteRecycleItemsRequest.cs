// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteRecycleItemsRequest : TeaModel {
        /// <summary>
        /// 回收项id列表
        /// </summary>
        [NameInMap("recycleItemIds")]
        [Validation(Required=false)]
        public List<string> RecycleItemIds { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
