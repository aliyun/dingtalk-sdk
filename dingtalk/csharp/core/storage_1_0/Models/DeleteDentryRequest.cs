// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentryRequest : TeaModel {
        /// <summary>
        /// 是否删除到回收站，默认不删除到回收站，直接删除
        /// 默认值:
        /// 	false
        /// </summary>
        [NameInMap("toRecycleBin")]
        [Validation(Required=false)]
        public bool? ToRecycleBin { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
