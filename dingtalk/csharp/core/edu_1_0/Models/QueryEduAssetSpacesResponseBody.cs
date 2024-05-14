// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryEduAssetSpacesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("spaces")]
        [Validation(Required=false)]
        public List<QueryEduAssetSpacesResponseBodySpaces> Spaces { get; set; }
        public class QueryEduAssetSpacesResponseBodySpaces : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTimeMillis")]
            [Validation(Required=false)]
            public long? CreateTimeMillis { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("modifyTimeMillis")]
            [Validation(Required=false)]
            public long? ModifyTimeMillis { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("permissionMode")]
            [Validation(Required=false)]
            public string PermissionMode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
