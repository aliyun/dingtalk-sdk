// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class RecoverRecycleFilesRequest : TeaModel {
        /// <summary>
        /// 回收站item id列表
        /// </summary>
        [NameInMap("recycleItemIdList")]
        [Validation(Required=false)]
        public List<long?> RecycleItemIdList { get; set; }

        /// <summary>
        /// 回收站类型
        /// </summary>
        [NameInMap("recycleType")]
        [Validation(Required=false)]
        public string RecycleType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
