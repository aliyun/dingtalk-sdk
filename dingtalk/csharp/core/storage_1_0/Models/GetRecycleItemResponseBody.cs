// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleItemResponseBody : TeaModel {
        [NameInMap("item")]
        [Validation(Required=false)]
        public GetRecycleItemResponseBodyItem Item { get; set; }
        public class GetRecycleItemResponseBodyItem : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_id</para>
            /// </summary>
            [NameInMap("dentryId")]
            [Validation(Required=false)]
            public string DentryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>recycle_item_id</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>operator_id</para>
            /// </summary>
            [NameInMap("operatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("operatorTime")]
            [Validation(Required=false)]
            public string OperatorTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_name</para>
            /// </summary>
            [NameInMap("originalName")]
            [Validation(Required=false)]
            public string OriginalName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dentry_path</para>
            /// </summary>
            [NameInMap("originalPath")]
            [Validation(Required=false)]
            public string OriginalPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>space_id</para>
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>file</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
