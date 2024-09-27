// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public RestoreRecycleItemRequestOption Option { get; set; }
        public class RestoreRecycleItemRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AUTO_RENAME</para>
            /// </summary>
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
