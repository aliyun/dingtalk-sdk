// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class MoveFilesRequest : TeaModel {
        [NameInMap("addConflictPolicy")]
        [Validation(Required=false)]
        public string AddConflictPolicy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

        [NameInMap("targetParentId")]
        [Validation(Required=false)]
        public string TargetParentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
