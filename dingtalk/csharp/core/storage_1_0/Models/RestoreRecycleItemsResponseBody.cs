// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RestoreRecycleItemsResponseBody : TeaModel {
        [NameInMap("resultItems")]
        [Validation(Required=false)]
        public List<RestoreRecycleItemsResponseBodyResultItems> ResultItems { get; set; }
        public class RestoreRecycleItemsResponseBodyResultItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("async")]
            [Validation(Required=false)]
            public bool? Async { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>permissionDenied</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>recyclebin_id</para>
            /// </summary>
            [NameInMap("recycleBinId")]
            [Validation(Required=false)]
            public string RecycleBinId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>recycle_item_id</para>
            /// </summary>
            [NameInMap("recycleItemId")]
            [Validation(Required=false)]
            public string RecycleItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task_id</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
