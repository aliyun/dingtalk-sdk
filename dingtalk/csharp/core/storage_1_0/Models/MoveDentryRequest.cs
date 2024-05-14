// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class MoveDentryRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public MoveDentryRequestOption Option { get; set; }
        public class MoveDentryRequestOption : TeaModel {
            [NameInMap("conflictStrategy")]
            [Validation(Required=false)]
            public string ConflictStrategy { get; set; }

            [NameInMap("presevePermissions")]
            [Validation(Required=false)]
            public bool? PresevePermissions { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetFolderId")]
        [Validation(Required=false)]
        public string TargetFolderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
