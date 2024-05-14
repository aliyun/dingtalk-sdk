// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class DeleteFilesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deletePolicy")]
        [Validation(Required=false)]
        public string DeletePolicy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
