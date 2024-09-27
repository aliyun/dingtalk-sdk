// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class CopyDentryRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CopyDentryRequestOption Option { get; set; }
        public class CopyDentryRequestOption : TeaModel {
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
        /// <para>target_folder_id</para>
        /// </summary>
        [NameInMap("targetFolderId")]
        [Validation(Required=false)]
        public string TargetFolderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target_space_id</para>
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

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
