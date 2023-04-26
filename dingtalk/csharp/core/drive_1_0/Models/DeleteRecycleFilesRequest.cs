// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class DeleteRecycleFilesRequest : TeaModel {
        [NameInMap("recycleItemIdList")]
        [Validation(Required=false)]
        public List<long?> RecycleItemIdList { get; set; }

        [NameInMap("recycleType")]
        [Validation(Required=false)]
        public string RecycleType { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
